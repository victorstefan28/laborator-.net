namespace Models
{
    public class Student
    {
        private string Nume { get; set; }
        private string Prenume { get; set; }

        private string Clasa { get; set; }


        public List<Materie> Materii { get; set; } = new List<Materie>();

        public Student(string nume, string prenume)
        {
            Nume = nume;
            Prenume = prenume;
        }

        public void AfisareMaterii()
        {
            Console.WriteLine($"Student: {Nume} {Prenume}");
            Console.WriteLine("Materii:");
            foreach (var materie in Materii)
            {
                Console.WriteLine($"- {materie.Titlu}, Durata: {materie.Durata}");
            }
        }
    }
}
