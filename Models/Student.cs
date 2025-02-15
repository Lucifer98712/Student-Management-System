namespace Student_Management_System.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set;  }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
