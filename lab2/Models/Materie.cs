﻿namespace Models
{
    public class Materie
    {
        public string Titlu { get; set; }
        public string Durata { get; set; }

        public Materie(string titlu, string durata)
        {
            Titlu = titlu;
            Durata = durata;
        }
    }
}
