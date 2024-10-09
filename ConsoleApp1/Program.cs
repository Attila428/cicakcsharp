using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Színe { Zöld, Rozsaszin, Lila, Fekete}
    enum Neme { Fiu,Lany}
    class Cica
    {
        public int ID { get; set; }
        public string Neve { get; set; }
        public Színe Szine { get; set; }
        public DateTime Szuletesidatum { get; set; }
        public Neme Neme { get; set; }
        public int Suly { get; set; }
        public int Kor => DateTime.Now.Year - Szuletesidatum.Year;

        public override string ToString()
        {
            return $"{ID,-5}{Neve,-20}{Szine,-10}{Szuletesidatum.ToString("yyyy-mm-dd"),-15}{Neme,-15}{Suly,-10}{Kor,-10}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Cica> cicak = new List<Cica>()
            {
                new Cica
                {
                    ID = 1,
                    Neme = Neme.Fiu,
                    Neve = "megatron",
                    Suly = 18,
                    Szine = Színe.Fekete,
                    Szuletesidatum = new DateTime(2018, 08, 02),
                },
                new Cica
                {
                    ID = 2,
                    Neme = Neme.Fiu,
                    Neve = "picur",
                    Suly = 14,
                    Szine = Színe.Rozsaszin,
                    Szuletesidatum = new DateTime(2013, 03, 01),
                },
                new Cica
                {
                    ID = 3,
                    Neme = Neme.Fiu,
                    Neve = "kaszás",
                    Suly = 4,
                    Szine = Színe.Zöld,
                    Szuletesidatum = new DateTime(2024, 02, 01),
                },
                new Cica
                {
                    ID = 4,
                    Neme = Neme.Lany,
                    Neve = "halál",
                    Suly = 50,
                    Szine = Színe.Fekete,
                    Szuletesidatum = new DateTime(2014, 05, 22),
                },
            };
            //elso cica
            Cica elsocica = cicak.First();
            Console.WriteLine(elsocica);


            //utolso cica

            Cica utolsocica = cicak.Last();
            Console.WriteLine(utolsocica);

            //összes súj.

            int xd2 = cicak.Sum(x => x.Suly);

            Console.WriteLine($"a cicák össz súlya:{xd2}");

            //atlag eletkor

            double xd3 = cicak.Average(x => x.Kor);
            Console.WriteLine($"a cicák átlag életkora:{xd3:0.00}");

            //lany macskak darab.

            int lanydb = cicak.Count(x => x.Neme == Neme.Lany);

            Console.WriteLine($"ennyi lány macska van :{lanydb}");

            //a legvékonyabb macska:

            int legveznabb = cicak.Min(x => x.Suly);

            Console.WriteLine($"a legvéznább sulya:{legveznabb}");

            //a harmadik cica:

            Cica masodikikcica = cicak[2];
            Console.WriteLine(masodikikcica);

            //3évnél nagyobb cicák száma:

            cicak.Where(x => x.Kor > 3)
                .ToList()
                .ForEach(x => Console.WriteLine(x.Neve));
            Console.ReadKey();
        }
    }
}
