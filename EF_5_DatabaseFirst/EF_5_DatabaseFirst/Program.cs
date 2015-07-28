using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_5_DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MeuBancoEntity())
            {
                var book = new titles() 
                {                    
                    title = "Intro to Entity Framework 5.0",
                };

                var book2 = new titles()
                {
                    title = "Intro to Entity Framework 5.0 - Part 2",
                };

                var publisher = new publishers() 
                {
                    pub_name = "Chéder Franco",
                };

                publisher.titles.Add(book);
                publisher.titles.Add(book2);

                db.publishers.Add(publisher);
                
                db.SaveChanges();

            }
        }
    }
}
