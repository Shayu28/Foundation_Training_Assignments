public class Student
{
    public int StudentID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DOB { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public Student(int studentID, string firstName, string lastName, DateTime dob, string email, string phoneNumber)
    {
        StudentID = studentID;
        FirstName = firstName;
        LastName = lastName;
        DOB = dob;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    // Enroll in Course
    public void EnrollInCourse(Course course)
    {
        // Logic for enrollment
    }
}
