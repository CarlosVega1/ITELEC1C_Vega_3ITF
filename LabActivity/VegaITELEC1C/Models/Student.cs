namespace VegaITELEC1C.Models
{
    public enum IsRegular
    {
        Regular, Irregular, Conditional, Debarred
    }
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IsRegular IsRegular { get; set; }
        public Course Course { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Email { get; set; }

    }
}