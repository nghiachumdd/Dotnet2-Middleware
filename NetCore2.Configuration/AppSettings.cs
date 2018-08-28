using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore2.Configuration
{
    public class AppSettings
    {
        public AppSetingsSection1 Section1 { get; set; }
        public AppSetingsSection2 Section2 { get; set; }
    }

    public class AppSetingsSection1
    {
        public string SettingA { get; set; }
        public string SettingB { get; set; }
    }

    public class AppSetingsSection2
    {
        public string SettingC { get; set; }
    }
}
