namespace DBTets
{
    class Cursus
    {
        public string cursusnaam { get; set; }
        public int id { get; set; }
        public Cursus(string cursusnaam)
        {
            this.cursusnaam = cursusnaam;
        }
        public Cursus(int id, string cursusnaam)
        {
            this.id = id;
            this.cursusnaam = cursusnaam;
        }
        public override string ToString()
        {
            return $"cursus : {cursusnaam} , id {id}";
        }

    }
}
