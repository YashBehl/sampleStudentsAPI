namespace sampleStudentsAPI.Models
{
    public class Student
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
    }
}
