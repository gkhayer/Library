using System;
using System.Collections.Generic;

namespace library.Models
{
    public interface IDepartment
    {
        Instructor Administrator { get; set; }
        decimal Budget { get; set; }
        ICollection<Course> Courses { get; set; }
        int DepartmentID { get; set; }
        int? InstructorID { get; set; }
        string Name { get; set; }
        DateTime StartDate { get; set; }
    }
}