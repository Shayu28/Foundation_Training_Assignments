public class Enrollment
{
    public int EnrollmentID { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
    public DateTime EnrollmentDate { get; set; }

    public Enrollment(int enrollmentID, Student student, Course course, DateTime enrollmentDate)
    {
        EnrollmentID = enrollmentID;
        Student = student;
        Course = course;
        EnrollmentDate = enrollmentDate;
    }
}

