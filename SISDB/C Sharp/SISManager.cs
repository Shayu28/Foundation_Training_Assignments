using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class SISManager
{
    private DatabaseHelper _dbHelper = new DatabaseHelper();

    public void EnrollStudentInCourse(Student student, Course course)
    {
        // Check if student is already enrolled
        string checkQuery = "SELECT COUNT(*) FROM Enrollments WHERE StudentID = @StudentID AND CourseID = @CourseID";
        SqlParameter[] parameters = {
            new SqlParameter("@StudentID", student.StudentID),
            new SqlParameter("@CourseID", course.CourseID)
        };

        int existingEnrollments = _dbHelper.ExecuteScalar<int>(checkQuery, parameters);

        if (existingEnrollments > 0)
        {
            throw new Exception("Student is already enrolled in this course.");
        }

        string enrollQuery = "INSERT INTO Enrollments (StudentID, CourseID, EnrollmentDate) VALUES (@StudentID, @CourseID, @EnrollmentDate)";
        SqlParameter[] enrollParams = {
            new SqlParameter("@StudentID", student.StudentID),
            new SqlParameter("@CourseID", course.CourseID),
            new SqlParameter("@EnrollmentDate", DateTime.Now)
        };

        _dbHelper.ExecuteQuery(enrollQuery, enrollParams);
    }

    public void AssignTeacherToCourse(Course course, Teacher teacher)
    {
        string updateCourseQuery = "UPDATE Courses SET InstructorName = @InstructorName WHERE CourseID = @CourseID";
        SqlParameter[] parameters = {
            new SqlParameter("@InstructorName", teacher.FirstName + " " + teacher.LastName),
            new SqlParameter("@CourseID", course.CourseID)
        };

        _dbHelper.ExecuteQuery(updateCourseQuery, parameters);
    }

    public void RecordPayment(Student student, decimal amount)
    {
        string paymentQuery = "INSERT INTO Payments (StudentID, Amount, PaymentDate) VALUES (@StudentID, @Amount, @PaymentDate)";
        SqlParameter[] paymentParams = {
            new SqlParameter("@StudentID", student.StudentID),
            new SqlParameter("@Amount", amount),
            new SqlParameter("@PaymentDate", DateTime.Now)
        };

        _dbHelper.ExecuteQuery(paymentQuery, paymentParams);
    }
}
