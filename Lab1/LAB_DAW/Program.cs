using Models;


class Program
{
    static void Main()
    {
        Materie materie1 = new Materie("Matematica", "30 ore");
        Materie materie2 = new Materie("Fizica", "25 ore");
        Materie materie3 = new Materie("Informatica", "40 ore");

        List<Student> students = new List<Student>();

        Student student1 = new Student("Andrei", "Ion");
        student1.Materii.Add(materie1);
        student1.Materii.Add(materie2);

        Student student2 = new Student("Stefan", "Bogdan");
        student2.Materii.Add(materie2);
        student2.Materii.Add(materie3);

        students.Add(student1);
        students.Add(student2);


        foreach (var item in students)
        {
            item.AfisareMaterii();
            Console.WriteLine();
        }
    }
}