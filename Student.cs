using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Student
{
    public string name { get; set; }
    public int age { get; set; }
    public int studentNumber { get; set; }
    public int group { get; set; }
    public Department department { get; set; }
    public Enrollment grade { get; set; }

    // Конструктор класу
    public Student(string name, int age, int studentNumber, int group, Department department)
    {
        this.name = name;
        this.age = age;
        this.studentNumber = studentNumber;
        this.group = group;
        this.department = department;
    }

    // Вивід даних
    public void Print()
    {
        Console.WriteLine($"Iм'я: {name} \nВiк: {age} \nСтудентський номер: {studentNumber} \nНомер групи студента: {group} \n {department}");
    }

    // Метод для редагування інформації про студента
    public void EditStudent(string newName, int newAge, int newStudentNumber, int newGroup)
    {
        name = newName;
        age = newAge;
        studentNumber = newStudentNumber;
        group = newGroup;
    }
}