﻿public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public string InstructorName { get; set; }

    public Course(int courseID, string courseName, string courseCode, string instructorName)
    {
        CourseID = courseID;
        CourseName = courseName;
        CourseCode = courseCode;
        InstructorName = instructorName;
    }
}

