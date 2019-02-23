using System;

namespace EzeckiasApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EzeckiasContext())
            {
                Console.WriteLine("enter movie title");
                string title = Console.ReadLine();
                    Console.WriteLine("enter movie category");
                string category = Console.ReadLine();
                    Console.WriteLine("enter movie release year");
                string year = Console.ReadLine();
                db.Ezeckiass.Add(new Ezeckiastbl { title = title});
                db.Ezeckiass.Add(new Ezeckiastbl { year = year });
                db.Ezeckiass.Add(new Ezeckiastbl { category_name = category });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var Ezeckiastbl in db.Ezeckiass)
                {
                    Console.WriteLine("{0}{1}{2}",Ezeckiastbl.title,Ezeckiastbl.year,Ezeckiastbl.category_name);
                
                }
            }
        }
    }
}