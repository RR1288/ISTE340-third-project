namespace ThirdProject.Models
{
    public class MinorsModel
    {
        public List<Minor> UgMinors { get; set; }
        public string pageTitle { get; set; }
    }

    public class Minor
    {
        public string name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<String> courses { get; set; }
    }
}
