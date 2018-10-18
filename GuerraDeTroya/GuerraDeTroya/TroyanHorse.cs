using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuerraDeTroya
{
    class TroyanHorse
    {
        private int capacity;
        private int occupation;
        

        public TroyanHorse(int capacity, int occupation)
        {
            capacity = 50;
            occupation++;
            List<Griego> horseOccupants = new List<Griego>();
        }




        public int SearchName(string warriorName, List<Griego> greekWarriors)
        {
            foreach (Griego x in greekWarriors)
            {
                if (warriorName = Griego. 
                {
                    int pos = greekWarriors.IndexOf(warriorName);
                    if (pos != -1)
                    {
                        Console.WriteLine(warriorName + " se ha encontrado en la posición: " + pos);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(warriorName + " no se ha encontrado");
                        return;

                    }
                }
                else
                {
                    Console.WriteLine("El guerrero no es un guerrero griego. ¡¡¡CUIDADO un traidor troyano!!!");
                    return;
                }
            }
            
        }
        
        public int SeeWarriorPos(int pos, List<Griego> greekWarriors)
        {
            if (pos>=0)
            {
                Console.WriteLine(greekWarriors.ElementAt(pos));
            }
            else
            {
                Console.WriteLine("No es una posición valida");
            }
            
        }
        public void GoHorse(string greekWarrior)
        {
            if (occupation<= capacity)
            {
                horseOccupants.Add(greekWarrior);
                Console.WriteLine("El gerrero griego " + greekWarrior + " montado en el caballo");
            }
            else
            {
                Console.WriteLine("No hay capacidad para más guerreros griegos");
            }
        }

        public void SeeData()
        {
            Console.WriteLine("La capacidad del caballo es "+capacity+" con una ocupación de "+occupation+" los guerreros " +Griego.gre);
        }
    }
}
