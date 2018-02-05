namespace codingclub.Models
{

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int ProjectID { get; set; }
        public int MemberID { get; set; }
        public Project Project{get; set;}
        public Member Member { get; set; }
    }
}