namespace kosarlabda_v1
{
    class Merkozes
    {
        public string Hazai { get; set; }
        public string Idegen { get; set; }
        public int HazaiPont { get; set; }
        public int IdegenPont { get; set; }
        public string Helyszin { get; set; }
        public string Idopont { get; set; }

        public Merkozes(string r)
        {
            var a = r.Split(';');
            Hazai = a[0];
            Idegen = a[1];
            HazaiPont = int.Parse(a[2]);
            IdegenPont = int.Parse(a[3]);
            Helyszin = a[4];
            Idopont = a[5];
        }
    }
}
