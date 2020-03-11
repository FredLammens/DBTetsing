using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_DB
{
    class Klas
    {
        public Klas(int id,string klasnaam)
        {
            this.id = id;
            this.klasnaam = klasnaam;
        }
        public Klas(string klasnaam)
        {
            this.klasnaam = klasnaam;
        }

        public override string ToString()
        {
            return $"id = {id}, naam = {klasnaam}" ;
        }
        public int id { get; private set; }
        public string klasnaam { get; private set; }
    }
}
