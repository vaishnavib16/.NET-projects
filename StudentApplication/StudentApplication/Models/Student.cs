namespace StudentApplication.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public DateTime admission_date {  get; set; }
        public float fees {  get; set; }
        public string status { get; set; }
    }
}
