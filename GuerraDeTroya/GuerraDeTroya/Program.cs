using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuerraDeTroya
{
    class Program
    {
        static void Main(string[] args)
        {

            Troyano troy1 = new Troyano();
            Troyano troy2 = new Troyano("Paris",18,10,false,false);
            Troyano troy3 = new Troyano("Hector",25,8,false,true);
            Troyano troy4 = new Troyano("Cicno", 32, 7, true, false);

            Griego gre1 = new Griego();
            Griego gre2 = new Griego("Aquiles", 30,10,false,true);
            Griego gre3 = new Griego("Agammenon",50,6,false,false);
            Griego gre4 = new Griego("Melenao",36,5,false,false);
            Griego gre5 = new Griego("Ayax",26,9,true,false);

            List<Troyano> troyanWarriors = new List<Troyano>();
            troyanWarriors.Add(troy1);
            troyanWarriors.Add(troy2);
            troyanWarriors.Add(troy3);
            troyanWarriors.Add(troy4);
            List<Griego> greekWarriors = new List<Griego>();
            greekWarriors.Add(gre1);
            greekWarriors.Add(gre2);
            greekWarriors.Add(gre3);
            greekWarriors.Add(gre4);
            greekWarriors.Add(gre5);

            foreach (Troyano x in troyanWarriors)
            {
                Console.WriteLine("El guerrero " + x.GetName() + " cuya edad es " + x.GetAge()+ " y su fuerza " + x.GetStrength());
                x.Retire();
            }

            foreach (Griego x in greekWarriors)
            {
                Console.WriteLine("El guerrero " + x.GetName() + " cuya edad es " + x.GetAge() + " y su fuerza " + x.GetStrength());
                x.Retire();
            }

            //*************************** EJERCICIO 2 *********************************

            Console.WriteLine("Inserte el nombre de un guerrero griego");
            string answer = Console.ReadLine();
            TroyanHorse.SearchName(answer);




            Console.ReadLine();

        }
    }
}
