using Microsoft.CodeAnalysis.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationProject_RP.Models
{
    public class ModelIndex
    {
        public string project_name { get; set; }
        public List<string> entity_list { get; set; }
        public string patern { get; set; }
        public string context_name { get; set; }
        public string server_name { get; set; }
        public string database_name { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string project_type { get; set; }

    }
}
