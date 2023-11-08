using System;

class Program
{
    static void Main()
    {
        // Создаем экземпляры классов Студент и Дисциплина
        Student student = new Student("Иванов Иван Иванович");
        Discipline discipline = new Discipline("Математика");

        // Создаем экземпляр класса Экзамен, передавая параметрами экземпляры Студент и Дисциплина
        Exam<Student, Discipline> exam = new Exam<Student, Discipline>(student, discipline);

        // Выполняем метод и выводим результат в консоль
        exam.PrintExamResult();
    }
}

class Exam<TStudent, TDiscipline> where TStudent: Student where TDiscipline: Discipline
{
    public TStudent Student { get; private set; }
    public TDiscipline Discipline { get; private set; }

    public Exam(TStudent student, TDiscipline discipline)
    {
        Student = student;
        Discipline = discipline;
    }

    public void PrintExamResult()
    {
        Console.WriteLine($"Студент {Student.FIO} сдал экзамен по дисциплине {Discipline.Title}");
    }
}

class Student
{
    public string FIO { get; private set; }

    public Student(string fio)
    {
        FIO = fio;
    }
}

class Discipline
{
    public string Title { get; private set; }

    public Discipline(string title)
    {
        Title = title;
    }
}