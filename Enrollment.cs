class Enrollment
{
    public Student Student { get; set; }
    public Course Course { get; set; }
    public int Grade { get; set; }

    public Enrollment(Student student, Course course, int grade)
    {
        Student = student;
        Course = course;
        Grade = grade;
    }

    public void EditEnrollment(int newGrade)
    {
        Grade = newGrade;
    }
}