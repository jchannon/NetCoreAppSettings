namespace depb
{
    public class DepBConfiguration
    {
        public Smtp Smtp { get; set; }
    }
    public class Smtp
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Port { get; set; }
    }

}
