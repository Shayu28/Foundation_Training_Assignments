public class Teacher
{
    public int TeacherID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Expertise { get; set; }

    public Teacher(int teacherID, string firstName, string lastName, string email, string expertise)
    {
        TeacherID = teacherID;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Expertise = expertise;
    }
}
