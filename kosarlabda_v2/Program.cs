using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace kosarlabda_v2
{
    class Program
    {
        static void Main()
        {
            var merkozesek = new List<Merkozes>();
            var sr = new StreamReader("eredmenyek.csv", Encoding.UTF8);
            sr.ReadLine();
            while(!sr.EndOfStream) merkozesek.Add(new Merkozes(sr.ReadLine()));

            int realHazaiMeccs = 0;
            int realIdegenMeccs = 0;
            bool voltDontetlen = false;
            string barcaNeve = null;
            var nov21 = new List<Merkozes>();
            var stadionok = new Dictionary<string, int>();

            foreach (var m in merkozesek)
            {
                if (m.Hazai == "Real Madrid") realHazaiMeccs++;
                if (m.Idegen == "Real Madrid") realIdegenMeccs++;
                if (m.HazaiPont == m.IdegenPont) voltDontetlen = true;
                if (m.Hazai.Contains("Barcelona")) barcaNeve = m.Hazai;
                if (m.Idopont == "2004-11-21") nov21.Add(m);
                if (!stadionok.ContainsKey(m.Helyszin)) stadionok.Add(m.Helyszin, 1);
                else stadionok[m.Helyszin]++;
            }

            Console.WriteLine($"3. feladat: Real Madrid: Hazai: {realHazaiMeccs}, Idegen: {realIdegenMeccs}");
            Console.WriteLine($"4. Volt döntetlen? {(voltDontetlen ? "igen" : "nem")}");
            Console.WriteLine($"5. feladat: barcelonai csapat neve: {barcaNeve}");
            Console.WriteLine("6. feladat:");
            foreach (var m in nov21)
                Console.WriteLine($"\t{m.Hazai}-{m.Idegen} ({m.HazaiPont}:{m.IdegenPont})");
            Console.WriteLine("7. feladat:");
            foreach (var s in stadionok)
                if (s.Value > 20) Console.WriteLine($"\t{s.Key}: {s.Value}");

            Console.ReadKey();
        }
    }
}
