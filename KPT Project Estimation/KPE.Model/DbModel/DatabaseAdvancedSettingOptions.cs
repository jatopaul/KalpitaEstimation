using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPE.Model.DbModel
{
    public class DatabaseAdvancedSettingOptions
    {

        public TimeSpan CommandTimeout { get; set; } = new TimeSpan(0, 0, 30);
        public string? DatabaseConnectionString { get; set; }
    }
}
