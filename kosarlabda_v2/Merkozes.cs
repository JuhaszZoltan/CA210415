namespace kosarlabda_v2
{
    class Merkozes
    {
        public string Hazai { get; set; }
        public string Idegen { get; set; }
        public string HazaiPont { get; set; }
        public string IdegenPont { get; set; }
        public string Helyszin { get; set; }
        public string Idopont { get; set; }

        public Merkozes(string r)
        {
            var a = r.Split(';');
            Hazai = a[0];
            Idegen = a[1];
            HazaiPont = a[2];
            IdegenPont = a[3];
            Helyszin = a[4];
            Idopont = a[5];
        }
    }
}
