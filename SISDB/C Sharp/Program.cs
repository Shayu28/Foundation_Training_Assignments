using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialize Database
        DatabaseHelper dbHelper = new DatabaseHelper();
        dbHelper.InitializeDatabase();

        // Create Instances of Students, Teachers, and Courses
        Student johnDoe = new Student(1, "John", "Wick", new DateTime(1995, 8, 15), "john.doe@example.com", "123-456-7890");
        Course introProgramming = new Course(1, "Introduction to Programming", "CS101", null);
        Course math101 = new Course(2, "Mathematics 101", "MATH101", null);
        Teacher sarahSmith = new Teacher(1, "Sarah", "Smith", "sarah.smith@example.com", "Computer Science");

        // Create SISManager
        SISManager sisManager = new SISManager();

        // Enroll John in Courses
        sisManager.EnrollStudentInCourse(johnWick, introProgramming);
        sisManager.EnrollStudentInCourse(johnWick, math101);

        // Assign Sarah as Instructor to a Course
        sisManager.AssignTeacherToCourse(introProgramming, sarahSmith);

        // Record a Payment for John
        sisManager.RecordPayment(johnWick, 500);

        Console.WriteLine("Student Enrollment and Payment Process Completed.");
    }
}
