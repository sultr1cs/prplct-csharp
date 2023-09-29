using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Клас Course (Предмет):
//Поля: назва предмету, викладач, кількість кредитів.
//Методи: конструктор, редагування інформації про предмет.

class Course
{
    public string Name; //назва предмету
    public string Teacher; //викладач
    public int Credits; //кількість кредитів

    public Course(string name, string teacher, int credits)
    {
        Name = name;
        Teacher = teacher;
        Credits = credits;
    }

    public void EditCourse(string newName, string newTeacher, int newCredits)
    {
        Name = newName;
        Teacher = newTeacher;
        Credits = newCredits;
    }
}