using System;
using Testing_DB;

namespace DBTets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            DataBeheer dh = new DataBeheer("Data Source = BIEBEM; Initial Catalog = TesDBt; Integrated Security = True");
            //dh.VoegCursusToe(new Cursus(3, "Programmeren"));
            //Console.WriteLine(dh.GeefCursus(3));
            Student student = new Student(1, "Ubutu", new Klas(2, " African"));
            dh.VoegStudentMetCursussenToe(student);

        }
    }
}
