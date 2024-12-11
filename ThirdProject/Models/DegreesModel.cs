namespace ThirdProject.Models
{
    public class DegreesModel
    {
        public List<Degree> undergraduate { get; set; }
        public List<Degree> graduate { get; set; }
        public string pageTitle { get; set; }
    }

    public class Degree
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<String> concentrations { get; set; }
        public List<String> availableCertificates { get; set; }

    }
}
