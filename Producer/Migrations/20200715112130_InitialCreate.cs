using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gkdr.Producer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "logevents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateLog = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(type: "int(11)", nullable: false),
                    EntityType = table.Column<int>(type: "int(11)", nullable: false),
                    Result = table.Column<string>(nullable: false),
                    Action = table.Column<short>(type: "smallint(6)", nullable: false),
                    IdEntry = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logevents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organizationtypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizationtypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    IdCountry = table.Column<short>(type: "smallint(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "religious",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_religious", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "speciality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speciality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    login = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    password = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    SecondName = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    IdType = table.Column<short>(type: "smallint(6)", nullable: false, defaultValueSql: "'3'"),
                    Read = table.Column<ulong>(type: "bit(1)", nullable: false, defaultValueSql: "b'0'"),
                    Add = table.Column<ulong>(type: "bit(1)", nullable: false, defaultValueSql: "b'0'"),
                    Modify = table.Column<ulong>(type: "bit(1)", nullable: false, defaultValueSql: "b'0'"),
                    IdRegion = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "violationtypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_violationtypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "distinct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    IdRegion = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_distinct", x => x.Id);
                    table.ForeignKey(
                        name: "fk_region_distinct",
                        column: x => x.IdRegion,
                        principalTable: "regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "subreligious",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    IdReligion = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subreligious", x => x.Id);
                    table.ForeignKey(
                        name: "fksubreligious",
                        column: x => x.IdReligion,
                        principalTable: "religious",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUser = table.Column<int>(type: "int(11)", nullable: false),
                    IdRegion = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_regions", x => x.Id);
                    table.ForeignKey(
                        name: "fk_region_user2",
                        column: x => x.IdRegion,
                        principalTable: "regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_region_user",
                        column: x => x.IdUser,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "violations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdOrganization = table.Column<int>(type: "int(11)", nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    PersonNameViolation = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "'NULL'"),
                    IdType = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_violations", x => x.Id);
                    table.ForeignKey(
                        name: "fkviolationtype",
                        column: x => x.IdType,
                        principalTable: "violationtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    IdDistinct = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.Id);
                    table.ForeignKey(
                        name: "fkregioncity",
                        column: x => x.IdDistinct,
                        principalTable: "distinct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Surname = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    Lastname = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "'NULL'"),
                    Telephone = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    PassportNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    IdSpeciality = table.Column<int>(type: "int(11)", nullable: false),
                    IdCity = table.Column<int>(type: "int(11)", nullable: false),
                    PasportAddress = table.Column<string>(unicode: false, maxLength: 101, nullable: true, defaultValueSql: "'NULL'"),
                    Address = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "'NULL'"),
                    Education = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "'NULL'"),
                    DateBirth = table.Column<DateTime>(nullable: true, defaultValueSql: "'NULL'"),
                    Photo = table.Column<byte[]>(type: "longblob", nullable: true, defaultValueSql: "'NULL'"),
                    LicenseMessioner = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    LicecnseMesionerIssueDate = table.Column<DateTime>(nullable: true, defaultValueSql: "'NULL'"),
                    Contacts = table.Column<string>(unicode: false, maxLength: 300, nullable: true, defaultValueSql: "'NULL'"),
                    UniqueId = table.Column<string>(unicode: false, maxLength: 20, nullable: true, defaultValueSql: "'NULL'"),
                    Comments = table.Column<string>(unicode: false, maxLength: 2000, nullable: true, defaultValueSql: "'NULL'"),
                    IdOrganization = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    OtherWorkplace = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "'NULL'"),
                    Email = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    IdCitizenship = table.Column<short>(type: "smallint(6)", nullable: true, defaultValueSql: "'NULL'"),
                    IsMissioner = table.Column<ulong>(type: "bit(1)", nullable: false, defaultValueSql: "b'0'"),
                    DateDepart = table.Column<DateTime>(nullable: true, defaultValueSql: "'NULL'"),
                    IdInviteOrganization = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employers", x => x.Id);
                    table.ForeignKey(
                        name: "fk_citizenship_employer",
                        column: x => x.IdCitizenship,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_city_employer",
                        column: x => x.IdCity,
                        principalTable: "cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_spec_employer",
                        column: x => x.IdSpeciality,
                        principalTable: "speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "missioner_licences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmployer = table.Column<int>(type: "int(11)", nullable: false),
                    DateIssue = table.Column<DateTime>(nullable: false),
                    Number = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Status = table.Column<ulong>(type: "bit(1)", nullable: false, defaultValueSql: "b'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_missioner_licences", x => x.Id);
                    table.ForeignKey(
                        name: "fk_missioner_licences_employer",
                        column: x => x.IdEmployer,
                        principalTable: "employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    CertificateNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "'NULL'"),
                    RegistrationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "'NULL'"),
                    IdSubReligion = table.Column<int>(type: "int(11)", nullable: false),
                    IdCity = table.Column<int>(type: "int(11)", nullable: false),
                    IsBranch = table.Column<ulong>(type: "bit(1)", nullable: false, defaultValueSql: "b'0'"),
                    IdMainOrganization = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    Address = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "'NULL'"),
                    IdManager = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    IdType = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    WebSite = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "'NULL'"),
                    Email = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    UniqueId = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    Forbidden = table.Column<ulong>(type: "bit(1)", nullable: false, defaultValueSql: "b'0'"),
                    Phone = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    IdDepartment = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizations", x => x.Id);
                    table.ForeignKey(
                        name: "fkcityorganization",
                        column: x => x.IdCity,
                        principalTable: "cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fkmanagerorganization",
                        column: x => x.IdManager,
                        principalTable: "employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fksubreligion",
                        column: x => x.IdSubReligion,
                        principalTable: "subreligious",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fkorganizationtype",
                        column: x => x.IdType,
                        principalTable: "organizationtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "adjudications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdOrganzation = table.Column<int>(type: "int(11)", nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(unicode: false, maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adjudications", x => x.Id);
                    table.ForeignKey(
                        name: "fk_adjudications_organizations",
                        column: x => x.IdOrganzation,
                        principalTable: "organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employer_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmployer = table.Column<int>(type: "int(11)", nullable: false),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: true, defaultValueSql: "'NULL'"),
                    IdOrganization = table.Column<int>(type: "int(11)", nullable: false),
                    IdSpeciality = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
                    Status = table.Column<short>(type: "smallint(3)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employer_history", x => x.Id);
                    table.ForeignKey(
                        name: "fk_employer_history",
                        column: x => x.IdEmployer,
                        principalTable: "employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_organization_histoy",
                        column: x => x.IdOrganization,
                        principalTable: "organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_speciality_history",
                        column: x => x.IdSpeciality,
                        principalTable: "speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "lawlicences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    DateIssue = table.Column<DateTime>(nullable: false),
                    IdOrganization = table.Column<int>(type: "int(11)", nullable: false),
                    Status = table.Column<ulong>(type: "bit(1)", nullable: false, defaultValueSql: "b'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lawlicences", x => x.Id);
                    table.ForeignKey(
                        name: "fk_lawlicenses_organization",
                        column: x => x.IdOrganization,
                        principalTable: "organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "licences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    IdOrganization = table.Column<int>(type: "int(11)", nullable: false),
                    DateIssue = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    Status = table.Column<ulong>(type: "bit(1)", nullable: false),
                    OrderNumber = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_licences", x => x.Id);
                    table.ForeignKey(
                        name: "fkorganization_license",
                        column: x => x.IdOrganization,
                        principalTable: "organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "otherlicences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    DateIssue = table.Column<DateTime>(nullable: false),
                    IdOrganization = table.Column<int>(type: "int(11)", nullable: false),
                    Status = table.Column<ulong>(type: "bit(1)", nullable: false, defaultValueSql: "b'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_otherlicences", x => x.Id);
                    table.ForeignKey(
                        name: "fk_otherlicenses_organization",
                        column: x => x.IdOrganization,
                        principalTable: "organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fk_adjudications_organizations_idx",
                table: "adjudications",
                column: "IdOrganzation");

            migrationBuilder.CreateIndex(
                name: "fk_region_cities_idx",
                table: "cities",
                column: "IdDistinct");

            migrationBuilder.CreateIndex(
                name: "fk_region_distinct_idx",
                table: "distinct",
                column: "IdRegion");

            migrationBuilder.CreateIndex(
                name: "fk_employer_history_idx",
                table: "employer_history",
                column: "IdEmployer");

            migrationBuilder.CreateIndex(
                name: "fk_organization_histoy_idx",
                table: "employer_history",
                column: "IdOrganization");

            migrationBuilder.CreateIndex(
                name: "fk_speciality_history_idx",
                table: "employer_history",
                column: "IdSpeciality");

            migrationBuilder.CreateIndex(
                name: "fk_citizenship_employer_idx",
                table: "employers",
                column: "IdCitizenship");

            migrationBuilder.CreateIndex(
                name: "fk_city_employer_idx",
                table: "employers",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "fk_invite_organization_idx",
                table: "employers",
                column: "IdInviteOrganization");

            migrationBuilder.CreateIndex(
                name: "fk_organization_emploer_idx",
                table: "employers",
                column: "IdOrganization");

            migrationBuilder.CreateIndex(
                name: "fk_spec_employer_idx",
                table: "employers",
                column: "IdSpeciality");

            migrationBuilder.CreateIndex(
                name: "UniqueId_UNIQUE",
                table: "employers",
                column: "UniqueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_lawlicenses_organization_idx",
                table: "lawlicences",
                column: "IdOrganization");

            migrationBuilder.CreateIndex(
                name: "fkorganization_license_idx",
                table: "licences",
                column: "IdOrganization");

            migrationBuilder.CreateIndex(
                name: "fk_missioner_licences_employer_idx",
                table: "missioner_licences",
                column: "IdEmployer");

            migrationBuilder.CreateIndex(
                name: "fk_city_orgaization_idx",
                table: "organizations",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IdDepartment",
                table: "organizations",
                column: "IdDepartment");

            migrationBuilder.CreateIndex(
                name: "fk_manager_organization_idx",
                table: "organizations",
                column: "IdManager");

            migrationBuilder.CreateIndex(
                name: "fkreligionorganization_idx",
                table: "organizations",
                column: "IdSubReligion");

            migrationBuilder.CreateIndex(
                name: "fkorganizationtype_idx",
                table: "organizations",
                column: "IdType");

            migrationBuilder.CreateIndex(
                name: "fk_otherlicenses_organization_idx",
                table: "otherlicences",
                column: "IdOrganization");

            migrationBuilder.CreateIndex(
                name: "Fk_country_regions_idx",
                table: "regions",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "fksubreligious_idx",
                table: "subreligious",
                column: "IdReligion");

            migrationBuilder.CreateIndex(
                name: "fk_region_user2_idx",
                table: "user_regions",
                column: "IdRegion");

            migrationBuilder.CreateIndex(
                name: "fk_region_user_idx",
                table: "user_regions",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "fkviolationtype_idx",
                table: "violations",
                column: "IdType");

            migrationBuilder.AddForeignKey(
                name: "fk_invite_organization",
                table: "employers",
                column: "IdInviteOrganization",
                principalTable: "organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_organization_emploer",
                table: "employers",
                column: "IdOrganization",
                principalTable: "organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_invite_organization",
                table: "employers");

            migrationBuilder.DropForeignKey(
                name: "fk_organization_emploer",
                table: "employers");

            migrationBuilder.DropTable(
                name: "adjudications");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "employer_history");

            migrationBuilder.DropTable(
                name: "lawlicences");

            migrationBuilder.DropTable(
                name: "licences");

            migrationBuilder.DropTable(
                name: "logevents");

            migrationBuilder.DropTable(
                name: "missioner_licences");

            migrationBuilder.DropTable(
                name: "otherlicences");

            migrationBuilder.DropTable(
                name: "user_regions");

            migrationBuilder.DropTable(
                name: "violations");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "violationtypes");

            migrationBuilder.DropTable(
                name: "organizations");

            migrationBuilder.DropTable(
                name: "employers");

            migrationBuilder.DropTable(
                name: "subreligious");

            migrationBuilder.DropTable(
                name: "organizationtypes");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "speciality");

            migrationBuilder.DropTable(
                name: "religious");

            migrationBuilder.DropTable(
                name: "distinct");

            migrationBuilder.DropTable(
                name: "regions");
        }
    }
}
