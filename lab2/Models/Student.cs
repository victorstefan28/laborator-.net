namespace Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public string Clasa { get; set; }


        //public List<Materie> Materii { get; set; } = new List<Materie>();

        public Student(int id, string nume, string prenume)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
        }

        public void AfisareMaterii()
        {
            Console.WriteLine($"Student: {Nume} {Prenume}");
            Console.WriteLine("Materii:");

        }
    }
}
