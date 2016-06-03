using depb;

namespace depa
{
    public class DepAConfiguration
    {
        public Logging Logging { get; set; }
        public Smtp Smtp { get; set; }
        public DepBConfiguration DepBConfiguration { get; set; }
    
    }

    public class LogLevel
    {
        public string Default { get; set; }
        public string System { get; set; }
        public string Microsoft { get; set; }
    }

    public class Logging
    {
        public bool IncludeScopes { get; set; }
        public LogLevel LogLevel { get; set; }
    }
}