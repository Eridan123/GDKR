using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gkdr.Consumer.Data.AppModel
{
    [Table("gdkr_logs")]
    public class GDKRLog
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public int EntityId { get; set; }
        public DateTime DateTime { get; set; }
        public ActionType ActionType { get; set; }
        public string Username { get; set; }
        public string Details { get; set; }
    }

    public enum ActionType
    {
        Login,
        Logout,
        Add,
        Edit,
        Delete,
        Tunduk
    }
}
