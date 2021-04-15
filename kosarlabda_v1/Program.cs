using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace kosarlabda_v1
{
    class Program
    {
        static List<Merkozes> merkozesek = new List<Merkozes>();
        static void Main()
        {
            F02();
            F03();
            F04();
            F05();
            F06();
            F07();
            Console.ReadKey();
        }

        private static void F07()
        {
            Console.WriteLine("7. feladat:");

            var dic = new Dictionary<string, int>();

            foreach (var m in merkozesek)
            {
                if (!dic.ContainsKey(m.Helyszin)) dic.Add(m.Helyszin, 1);
                else dic[m.Helyszin]++;
            }

            foreach (var kvp in dic)
            {
                if (kvp.Value > 20) Console.WriteLine($"\t{kvp.Key}: {kvp.Value}");
            }
        }

        private static void F06()
        {
            Console.WriteLine("6. feladat:");
            foreach (var m in merkozesek)
            {
                if (m.Idopont == "2004-11-21")
                    Console.WriteLine($"\t{m.Hazai}-{m.Idegen} ({m.HazaiPont}:{m.IdegenPont})");
            }
        }

        private static void F05()
        {
            int i = 0;
            while (!merkozesek[i].Hazai.Contains("Barcelona"))
            {
                i++;
            }
            Console.WriteLine($"5. feladat: barcelonai csapat neve: {merkozesek[i].Hazai}");
        }

        private static void F04()
        {
            int i = 0;
            while (i < merkozesek.Count && merkozesek[i].HazaiPont != merkozesek[i].IdegenPont)
            {
                i++;
            }
            Console.Write("4. feladat: Volt döntetlen? ");
            if (i < merkozesek.Count) Console.WriteLine("igen");
            else Console.WriteLine("nem");
        }

        private static void F03()
        {
            int hazai = 0;
            int idegen = 0;

            foreach (var m in merkozesek)
            {
                if (m.Hazai == "Real Madrid") hazai++;
                else if (m.Idegen == "Real Madrid") idegen++;
            }

            Console.WriteLine($"3. feladat: real Madrid: Hazai: {hazai}, Idege: {idegen}");
        }

        private static void F02()
        {
            var sr = new StreamReader(@"eredmenyek.csv", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                merkozesek.Add(new Merkozes(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
