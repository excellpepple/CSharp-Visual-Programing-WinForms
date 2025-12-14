using System;
using System.Collections.Generic;
using System.Text;
/*
 * Helper utilities for GPA calculation
 * @author Excell Pepple
 */
namespace GPA_Calculator
{
    internal static class GPA_Utilities
    {
        

    }
    /*
     * Enum representing letter grades
     */
    public enum Grade
    {
        A,
        B, 
        C,
        D,
        F
    }

    /*
     * Class representing a semester with courses
     */
    public class Semester
    {
        public Guid Id { get; set; } // REQUIRED: Unique identifier for the semester
        public string Name { get; set; } 
        public int Year { get; set; }
        public Dictionary<Guid, Course> Courses { get; set; } // REQUIRED: Using a dictionary to store courses with their unique IDs

        /*
         * Default constructor
         *
         */
        public Semester()
        {
            Courses = new Dictionary<Guid, Course>(); // Initialize the courses dictionary
            Id = Guid.NewGuid(); // Generate a new unique identifier
            Year = DateTime.Now.Year; // Default to current year
        }

        /*
         * Semester constructor with name and year
         * @param name The name of the semester (string)
         * @param year The year of the semester (int)
         */
        public Semester(string name, int year)
        {
            Courses = new Dictionary<Guid, Course>();
            Id = Guid.NewGuid();
            Name = name;
            Year = year;
        }

        /*
         * Semester constructor with name only
         * @param name The name of the semester
         */
        public Semester(string name)
        {
            Courses = new Dictionary<Guid, Course>();
            Id = Guid.NewGuid();
            Name = name;
            Year = DateTime.Now.Year;
        }

        /*
         * Copy constructor
         * @param other The semester to copy from
         */
        public Semester(Semester other)
        {
            Courses = new Dictionary<Guid, Course>();
            Id = Guid.NewGuid(); // Generate a new unique identifier
            Name = other.Name;
            // Copy each course from the other semester
            foreach (var course in other.Courses)
            {
                var tempCourse = new Course(course.Value) { Id = course.Key }; // Create a copy of the course
                Courses.Add(tempCourse.Id, tempCourse); // Add the copied course to the new semester
            }
        }

        /*
         * Calculate the GPA for the semester
         * @return The calculated GPA (double)
         */
        public double CalculateGPA()
        {
            double totalPoints = 0;
            int totalCredits = 0;
            // Iterate through each course to calculate total points and credits
            foreach (var course in Courses)
            {
                totalCredits += course.Value.Credits; // sums up total credits
                totalPoints += course.Value.GetGradePoint() * course.Value.Credits; // sums up total grade points
            }
            
            return totalCredits == 0 ? 0 : totalPoints / totalCredits; // if no credits, return 0 to avoid division by zero
        }

        /*
         * Calculate the total credit hours for the semester
         * @return The total credit hours (int)
         */
        public int TotalCreditHours()
        {
            int credits = 0;
            // Iterate through each course to sum up credit hours
            foreach (var course in Courses)
            {
                credits += course.Value.Credits; //REQUIRED: Use if arithmetic operations to sum credit hours
            }
            return credits;
        }

        // override ToString method to represent the semester as a string
        public override string ToString()
        {
            string result = $"{Name},{Year},{Courses.Count}\n"; // Header with semester name, year, and number of courses
            // Append each course's string representation
            foreach (var (key, course) in Courses)
            {
                result += course.ToString() + "\n";
            }
            return result.TrimEnd(); // Remove the trailing newline character
        }

        /*
         * Clear the semester data
         */
        public void Clear()
        {
            Name = "";
            Year = DateTime.Now.Year;
            Courses.Clear();
        }
    }

    /*
     * Class representing a course
     */
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public Grade letterGrade { get; set; } // REQUIRED: Letter grade for the course

        /*
         * Default constructor
         */
        public Course()
        {
            Id = Guid.NewGuid(); // Generate a new unique identifier
            Name = string.Empty;
            Credits = 4; // Default to 4 credits
            letterGrade = Grade.F; // Default to F if not specified
        }

        /*
         * Constructor with parameters
         * @param name The name of the course (string)
         * @param credits The number of credits for the course (int)
         * @param grade The letter grade for the course (Grade enum)
         */
        public Course(string name, int credits, Grade grade)
        {
            Id = Guid.NewGuid();

            Name = name;
            Credits = credits;
            letterGrade = grade;
        }

        /*
         * Get the grade point value for the course based on the letter grade
         * @return The grade point value (double)
         */
        public double GetGradePoint()
        {
            return letterGrade switch // Using switch expression to map letter grades to grade points
            {
                Grade.A => 4.0,
                Grade.B => 3.0,
                Grade.C => 2.0,
                Grade.D => 1.0,
                Grade.F => 0.0,
                _ => 0.0,
            };
        }

        /*
         * Copy constructor
         * @param other The course to copy from
         */
        public Course(Course other)
        {
            Id = Guid.NewGuid();

            Name = other.Name;
            Credits = other.Credits;
            letterGrade = other.letterGrade;
        }

        // override ToString method to represent the course as a string
        public override string ToString()
        {
            return $"{Name},{Credits},{letterGrade.ToString()}";
        }
    }
}
