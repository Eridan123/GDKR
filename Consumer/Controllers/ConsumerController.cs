using System;
using System.IO;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Gkdr.Consumer.Data;
using Gkdr.Consumer.Data.AppModel;
using Gkdr.Consumer.Services;
using GrsAddress;
using GrsForeign;
using GrsPassport;
using GrsZags;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinjustService_getSubjectByName;
using MinjustService_getSubjectByTin;
using asbAddress = GrsAddress.asbAddress;
using asbAddressRequest = GrsAddress.asbAddressRequest;
using asbAddressResponseResponse = GrsAddress.asbAddressResponseResponse;

namespace Gkdr.Consumer.Controllers
{
    [Route("api/")]
    [ApiController]
    // [Authorize]
    public class ConsumerController : ControllerBase
    {
        private const string RemoteAddress = "http://192.168.1.210";
        private const string XRoadInstance = "central-server";
        private const string MemberClass = "GOV";
        private const string ClientMemberCode = "70000009";
        private const string ClientSubSystemCode = "gkdr-service";

        private readonly string Id = Guid.NewGuid().ToString();
        private const string UserId = "gkdr";
        private const string Issue = "CA";
        private const string ProtocolVersion = "4.0";
        private const string ServiceVersion = "v1";

        private readonly AppDbContext _appContext;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ConsumerController(AppDbContext context, IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _appContext = context;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }



        //************************** GRS ***************************************************************
        [HttpPost]
        [Route("getAddressByPin")]
        public async Task<asbAddressResponseResponse> GetAddressByPinAsync([FromBody] string pin)
        {
            LogWriter("getAddressByPin","ПИН: " + pin);

            var client =
                new GrsAddress.InfocomServicePortTypeClient(
                    GrsAddress.InfocomServicePortTypeClient.EndpointConfiguration.InfocomServicePort, RemoteAddress);

            var request = new asbAddressRequest1
            {
                id = Id,
                userId = UserId,
                issue = Issue,
                protocolVersion = ProtocolVersion,
                client = new Tunduk.XRoadClientIdentifierType
                {
                    xRoadInstance = XRoadInstance,
                    memberClass = MemberClass,
                    memberCode = ClientMemberCode,
                    subsystemCode = ClientSubSystemCode,
                    objectType = Tunduk.XRoadObjectType.SUBSYSTEM
                },
                service = new Tunduk.XRoadServiceIdentifierType
                {
                    xRoadInstance = "central-server",
                    memberClass = "GOV",
                    memberCode = "70000005",
                    subsystemCode = "asb-service",
                    serviceCode = "asbAddress",
                    serviceVersion = ServiceVersion,
                    objectType = Tunduk.XRoadObjectType.SERVICE
                },
                asbAddress = new asbAddress
                {
                    request = new asbAddressRequest
                    {
                        pin = pin
                    }
                }
            };
            var response = await client.asbAddressAsync(request);

            return response.asbAddressResponse.response;
        }

        [HttpPost]
        [Route("getZagsByPin")]
        public async Task<ZAGS.zagsDataByPinResponseResponse> GetZagsByPinAsync([FromBody] string pin)
        {
            LogWriter("getZagsByPin", "ПИН: " + pin);

            var client = new ZAGS.InfocomServicePortTypeClient(ZAGS.InfocomServicePortTypeClient.EndpointConfiguration.InfocomServicePort, RemoteAddress);

            var request = new ZAGS.zagsDataByPinRequest1
            {
                id = Id,
                userId = UserId,
                issue = Issue,
                protocolVersion = ProtocolVersion,
                client = new ZAGS.XRoadClientIdentifierType
                {
                    xRoadInstance = XRoadInstance,
                    memberClass = MemberClass,
                    memberCode = ClientMemberCode,
                    subsystemCode = ClientSubSystemCode,
                    objectType = ZAGS.XRoadObjectType.SUBSYSTEM
                },
                service = new ZAGS.XRoadServiceIdentifierType
                {
                    xRoadInstance = "central-server",
                    memberClass = "GOV",
                    memberCode = "70000005",
                    subsystemCode = "zags-service",
                    serviceCode = "zagsDataByPin",
                    serviceVersion = ServiceVersion,
                    objectType = ZAGS.XRoadObjectType.SERVICE
                },
                zagsDataByPin = new ZAGS.zagsDataByPin
                {
                    request = new ZAGS.zagsDataByPinRequest
                    {
                        pin = pin,
                        datetimeFormat = true
                    }
                }
            };
            var response = await client.zagsDataByPinAsync(request);
            return response.zagsDataByPinResponse.response;
        }

        [HttpPost]
        [Route("zagsPinsByNSPDate")]
        public async Task<string[]> GetZagsPinsByNSPDate(zagsPinsByNSPDateRequest req)
        {
            LogWriter("zagsPinsByNSPDate", "Имя: " + req.name + ", Фамилия: " + req.surname + ", Отчество: " + req.patronymic + ", Дата рождения: " + req.birthdate.ToString("dd.MM.yyyy"));

            var client = new GrsZags.InfocomServicePortTypeClient(GrsZags.InfocomServicePortTypeClient.EndpointConfiguration.InfocomServicePort, RemoteAddress);

            var request = new GrsZags.zagsPinsByNSPDateRequest1
            {
                id = Id,
                userId = UserId,
                issue = Issue,
                protocolVersion = ProtocolVersion,
                client = new GrsZags.XRoadClientIdentifierType
                {
                    xRoadInstance = XRoadInstance,
                    memberClass = MemberClass,
                    memberCode = ClientMemberCode,
                    subsystemCode = ClientSubSystemCode,
                    objectType = GrsZags.XRoadObjectType.SUBSYSTEM
                },
                service = new GrsZags.XRoadServiceIdentifierType
                {
                    xRoadInstance = "central-server",
                    memberClass = "GOV",
                    memberCode = "70000005",
                    subsystemCode = "zags-service",
                    serviceCode = "zagsPinsByNSPDate",
                    serviceVersion = ServiceVersion,
                    objectType = GrsZags.XRoadObjectType.SERVICE
                },
                zagsPinsByNSPDate = new zagsPinsByNSPDate
                {
                    request = new zagsPinsByNSPDateRequest
                    {
                        name = req.name,
                        surname = req.surname,
                        patronymic = req.patronymic,
                        birthdate = req.birthdate.Date
                    }
                }
            };
            var response = await client.zagsPinsByNSPDateAsync(request);

            return response.zagsPinsByNSPDateResponse.response;
        }

        [HttpPost]
        [Route("passportDataByPSN")]
        public async Task<passportDataByPSNResponseResponse> GetPassportDataByPSN(passportDataByPSNRequest req)
        {
            LogWriter("passportDataByPSN", "ПИН: " +req.pin+", Серия: "+req.series+", №: "+ req.number);

            var client = new GrsPassport.InfocomServicePortTypeClient(GrsPassport.InfocomServicePortTypeClient.EndpointConfiguration.InfocomServicePort, RemoteAddress);

            var request = new GrsPassport.passportDataByPSNRequest1
            {
                id = Id,
                userId = UserId,
                issue = Issue,
                protocolVersion = ProtocolVersion,
                client = new GrsPassport.XRoadClientIdentifierType
                {
                    xRoadInstance = XRoadInstance,
                    memberClass = MemberClass,
                    memberCode = ClientMemberCode,
                    subsystemCode = ClientSubSystemCode,
                    objectType = GrsPassport.XRoadObjectType.SUBSYSTEM
                },
                service = new GrsPassport.XRoadServiceIdentifierType
                {
                    xRoadInstance = "central-server",
                    memberClass = "GOV",
                    memberCode = "70000005",
                    subsystemCode = "passport-service",
                    serviceCode = "passportDataByPSN",
                    serviceVersion = ServiceVersion,
                    objectType = GrsPassport.XRoadObjectType.SERVICE
                },
                passportDataByPSN = new passportDataByPSN
                {
                    request = new passportDataByPSNRequest
                    {
                        number = req.number,
                        series = req.series,
                        pin = req.pin
                    }
                }
            };
            var response = await client.passportDataByPSNAsync(request);

            return response.passportDataByPSNResponse.response;
        }

        [HttpPost]
        [Route("foreignByDocRequest")]
        public async Task<foreignByDocResponseResponse> GetPassportDataByPSN(foreignByDocRequest req)
        {
            LogWriter("foreignByDocRequest","Документ: " + req.doc +", Код: " + req.code);

            var client = new GrsForeign.InfocomServicePortTypeClient(GrsForeign.InfocomServicePortTypeClient.EndpointConfiguration.InfocomServicePort, RemoteAddress);

            var request = new foreignByDocRequest1
            {
                id = Id,
                userId = UserId,
                issue = Issue,
                protocolVersion = ProtocolVersion,
                client = new GrsForeign.XRoadClientIdentifierType
                {
                    xRoadInstance = XRoadInstance,
                    memberClass = MemberClass,
                    memberCode = ClientMemberCode,
                    subsystemCode = ClientSubSystemCode,
                    objectType = GrsForeign.XRoadObjectType.SUBSYSTEM
                },
                service = new GrsForeign.XRoadServiceIdentifierType
                {
                    xRoadInstance = "central-server",
                    memberClass = "GOV",
                    memberCode = "70000005",
                    subsystemCode = "foreign-service",
                    serviceCode = "foreignByDoc",
                    serviceVersion = ServiceVersion,
                    objectType = GrsForeign.XRoadObjectType.SERVICE
                },
                foreignByDoc = new foreignByDoc
                {
                    request = new foreignByDocRequest
                    {
                        doc = req.doc,
                        code = req.code
                    }
                }
            };
            var response = await client.foreignByDocAsync(request);
            return response.foreignByDocResponse.response;
        }

        //******************** MINJUST **********************************************************

        [HttpPost]
        [Route("getsubjectbyname")]
        public async Task<subjects[]> getSubjectByNameFunc([FromBody] string subjectName)
        {
            LogWriter("getsubjectbyname", "Название: " + subjectName);

            var client = new SubjectByNamePortClient(SubjectByNamePortClient.EndpointConfiguration.SubjectByNamePortSoap11, RemoteAddress);
            var request = new getSubjectByNameRequest1
            {
                id = Id,
                userId = UserId,
                protocolVersion = ProtocolVersion,
                client = new MinjustService_getSubjectByName.XRoadClientIdentifierType
                {
                    xRoadInstance = XRoadInstance,
                    memberClass = MemberClass,
                    memberCode = ClientMemberCode,
                    subsystemCode = ClientSubSystemCode,
                    objectType = MinjustService_getSubjectByName.XRoadObjectType.SUBSYSTEM
                },
                service = new MinjustService_getSubjectByName.XRoadServiceIdentifierType
                {
                    xRoadInstance = "central-server",
                    memberClass = "GOV",
                    memberCode = "70000024",
                    subsystemCode = "minjust-service",
                    serviceCode = "getSubjectByName",
                    objectType = MinjustService_getSubjectByName.XRoadObjectType.SERVICE
                },
                getSubjectByNameRequest = new getSubjectByNameRequest
                {
                    query = "%" + subjectName + "%",
                    type = QueryType.NAME
                }
            };

            var response = await client.getSubjectByNameAsync(request);

            return response.getSubjectByNameResponse.subjects;
        }

        [HttpPost]
        [Route("getsubjectbytin")]
        public async Task<getSubjectByTinResponse> getSubjectByTinnFunc([FromBody] string subjectTin)
        {
            LogWriter("getsubjectbytin","ИНН: " + subjectTin);

            var client = new SubjectPortClient(SubjectPortClient.EndpointConfiguration.SubjectPortSoap11, RemoteAddress);
            var request = new getSubjectByTinRequest1
            {
                id = Id,
                userId = UserId,
                protocolVersion = ProtocolVersion,
                client = new MinjustService_getSubjectByTin.XRoadClientIdentifierType
                {
                    xRoadInstance = XRoadInstance,
                    memberClass = MemberClass,
                    memberCode = ClientMemberCode,
                    subsystemCode = ClientSubSystemCode,
                    objectType = MinjustService_getSubjectByTin.XRoadObjectType.SUBSYSTEM
                },
                service = new MinjustService_getSubjectByTin.XRoadServiceIdentifierType
                {
                    xRoadInstance = "central-server",
                    memberClass = "GOV",
                    memberCode = "70000024",
                    subsystemCode = "minjust-service",
                    serviceCode = "getSubjectByTin",
                    objectType = MinjustService_getSubjectByTin.XRoadObjectType.SERVICE
                },
                getSubjectByTinRequest = new getSubjectByTinRequest
                {
                    tin = subjectTin
                }
            };
            var response = await client.getSubjectByTinAsync(request);

            return response.getSubjectByTinResponse;
        }

        public void LogWriter(string type, string details)
        {
            var currentUserName = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
            // var currentUser = _userService.GetById(Convert.ToInt32(currentUserId));

            GDKRLog log = new GDKRLog();
            log.Username = currentUserName;
            log.ActionType = ActionType.Tunduk;
            log.DateTime = System.DateTime.Now;
            log.EntityName = type;
            log.Details = details;
            _appContext.GDKRLogs.AddAsync(log);
            _appContext.SaveChanges();
        }
    }
}
