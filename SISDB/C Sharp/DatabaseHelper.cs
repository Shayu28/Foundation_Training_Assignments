using System;
using System.Data.SqlClient;

public class DatabaseHelper
{
    private string connectionString = "Server=SHAYU; Database=SISDB; trusted_Connection=True";

    // Initialize Database
    public void InitializeDatabase()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string createTablesQuery = @"
                CREATE TABLE Students (
                    StudentID INT PRIMARY KEY IDENTITY,
                    FirstName NVARCHAR(100),
                    LastName NVARCHAR(100),
                    DOB DATE,
                    Email NVARCHAR(100),
                    PhoneNumber NVARCHAR(15)
                );
                
                CREATE TABLE Courses (
                    CourseID INT PRIMARY KEY IDENTITY,
                    CourseName NVARCHAR(100),
                    CourseCode NVARCHAR(20),
                    InstructorName NVARCHAR(100)
                );

                CREATE TABLE Enrollments (
                    EnrollmentID INT PRIMARY KEY IDENTITY,
                    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
                    CourseID INT FOREIGN KEY REFERENCES Courses(CourseID),
                    EnrollmentDate DATE
                );

                CREATE TABLE Payments (
                    PaymentID INT PRIMARY KEY IDENTITY,
                    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
                    Amount DECIMAL(10, 2),
                    PaymentDate DATE
                );

                CREATE TABLE Teachers (
                    TeacherID INT PRIMARY KEY IDENTITY,
                    FirstName NVARCHAR(100),
                    LastName NVARCHAR(100),
                    Email NVARCHAR(100),
                    Expertise NVARCHAR(100)
                );
            ";

            SqlCommand command = new SqlCommand(createTablesQuery, connection);
            command.ExecuteNonQuery();
        }
    }

    // Helper Method to Execute Queries
    public void ExecuteQuery(string query, SqlParameter[] parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            command.ExecuteNonQuery();
        }
    }
}
