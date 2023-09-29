using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Department
{
    public string Name { get; set; }
    public List<Student> Students { get; private set; }
    public List<Course> Courses { get; private set; }

    public Department(string name)
    {
        Name = name;
        Students = new List<Student>();
        Courses = new List<Course>();
    }
    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
    public void RemoveStudent(Student student)
    {
        Students.Remove(student);
    }
    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
    public void RemoveCourse(Course course)
    {
        Courses.Remove(course);
    }
}