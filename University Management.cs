using System;
using System.Collections.Generic;

class UniversityManagementSystem
{
    private List<Student> students;
    private List<Course> courses;
    private List<Enrollment> enrollments;
    private List<Department> departments;

    public UniversityManagementSystem()
    {
        students = new List<Student>();
        courses = new List<Course>();
        enrollments = new List<Enrollment>();
        departments = new List<Department>();
    }

    // Метод для додавання студента
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    // Метод для додавання предмету
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    // Метод для запису студента на предмет
    public void EnrollStudent(Student student, Course course, int grade)
    {
        enrollments.Add(new Enrollment(student, course, grade));
    }
    // Метод для виведення інформації про студентів на певному предметі
    public void PrintStudentsInCourse(Course course)
    {
        Console.WriteLine($"Предмет: {course.Name} | Викладач: {course.Teacher} | Кредити: {course.Credits} \n\nСтудентiв на курсi:");
        foreach (var enrollment in enrollments)
        {
            if (enrollment.Course == course)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Iм'я студента: {enrollment.Student.name}");
                Console.WriteLine($"Вiк: {enrollment.Student.age}");
                Console.WriteLine($"Оцiнка: {enrollment.Grade}");
                Console.WriteLine($"Студентський номер: {enrollment.Student.studentNumber}");
                Console.WriteLine($"Номер групи студента: {enrollment.Student.group}");
                Console.WriteLine($"Факультет: {enrollment.Student.department.Name}");
                Console.WriteLine("-------------------------");
            }
        }
    }

    // Метод для виведення інформації про всіх студентів
    public void PrintAllStudents()
    {
        Console.WriteLine("Список студентiв:");
        foreach (var student in students)
        {
            student.Print();
        }
    }

    // Метод для виведення інформації про всі предмети
    public void PrintAllCourses()
    {
        Console.WriteLine("Список предметiв:");
        foreach (var course in courses)
        {
            Console.WriteLine($"Назва предмету: {course.Name}");
        }
    }

    // Метод для додавання факультету
    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }

    // Метод для виведення інформації про всі факультети
    public void PrintAllDepartments()
    {
        Console.WriteLine("Список факультетiв:");
        foreach (var department in departments)
        {
            Console.WriteLine($"Назва факультету: {department.Name}");
        }
    }
}


class Program
{
    static void Main()
    {
        bool isValidLogin = false;

        while (!isValidLogin)
        {
            Console.WriteLine("Введіть логін:");
            string login = Console.ReadLine();

            Console.WriteLine("Введіть пароль:");
            string password = Console.ReadLine();

            if (IsValidLogin(login, password))
            {
                isValidLogin = true; // Логін і пароль правильні, виходимо з циклу
            }
            else
            {
                Console.WriteLine("Неправильний логін або пароль. Спробуйте ще раз.");
            }
        }
        
            UniversityManagementSystem system = new UniversityManagementSystem();

            //додавання студентів і предметів
            Department fit = new Department("ФIТ");
            Department ftm = new Department("ФТМ");
            Department fmtp = new Department("ФМТП");
            Department femp = new Department("ФЕМП");

            Student Ivan = new Student("Iван", 20, 12345, 101, fmtp);
            Student Maria = new Student("Марiя", 21, 2321, 102, fmtp);
            Student Kostya = new Student("Костянтин", 19, 2131, 102, fit);
            Course math = new Course("Математика", "Лiтковська В.В.", 4);
            Course history = new Course("Iсторiя", "Парфенюк С.А.", 3);

            system.AddStudent(Ivan);
            system.AddStudent(Maria);
            system.AddStudent(Kostya);
            system.AddCourse(math);
            system.AddCourse(history);
            system.AddDepartment(fit);
            system.AddDepartment(ftm);
            system.AddDepartment(fmtp);
            system.AddDepartment(femp);

            //запис студентів на предмети
            system.EnrollStudent(Ivan, math, 90);
            system.EnrollStudent(Maria, history, 85);
            system.EnrollStudent(Kostya, math, 78);


            //виведення інформації про студентів на предметі
            system.PrintStudentsInCourse(math);
            system.PrintStudentsInCourse(history);

            //Виведення факультетів
            system.PrintAllDepartments();
    }

    static bool IsValidLogin(string login, string password)
    {
        return login == "sultr1cs" && password == "1234";
    }
}


