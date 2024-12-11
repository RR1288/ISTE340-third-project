namespace ThirdProject.Models
{
    public class FooterModel
    {
        public SocialInfo Social { get; set; }
        public List<QuickLink> QuickLinks { get; set; }
        public CopyrightInfo Copyright { get; set; }

        public class SocialInfo
        {
            public string Title { get; set; }
            public string Tweet { get; set; }
            public string By { get; set; }
            public string Twitter { get; set; }
            public string Facebook { get; set; }
        }

        public class QuickLink
        {
            public string Title { get; set; }
            public string Href { get; set; }
        }

        public class CopyrightInfo
        {
            public string Title { get; set; }
            public string Html { get; set; }
        }
    }
}