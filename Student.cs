using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DBTets;

namespace Testing_DB
{
    class Student
    {
        public Student(string naam, Klas klas)
        {
            this.naam = naam;
            this.klas = klas;
            System.Random random = new Random();
            this.studentID = random.Next(5000);
            cursussen = new List<Cursus>();
        }

        public void VoegCursusToe(Cursus cursus)
        {
            if (!cursussen.Contains(cursus))
                cursussen.Add(cursus);
        }

        public void ShowStudent()
        {
            Console.WriteLine($"naam = {naam}, id = {studentID}: \n" + $"Klas: {klas.ToString()}\n Cursussen: \n");
            foreach(Cursus cursus in cursussen)
            {
                Console.WriteLine(cursus.ToString());
            }
        }

        public Student(int studentID, string naam, Klas klas)
        {
            this.klas = klas;
            this.studentID = studentID;
            this.naam = naam;
            cursussen = new List<Cursus>();
        }

        public List<Cursus> cursussen { get; private set; }
        public Klas klas { get; private set; }
        public int studentID { get; private set; }
        public string naam { get; private set; }
    }
}
