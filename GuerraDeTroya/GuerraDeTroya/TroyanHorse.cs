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
        List<Griego> horseOccupants;

        public TroyanHorse(int capacity)
        {
            if (capacity <= horseOccupants.Count())
            {
                Console.WriteLine("No puede haber más ocupantes que la capcidad del caballo");
            }
            else
            {
            this.capacity = capacity;
            occupation

            }
            List<Griego> horseOccupants = new List<Griego>();
        }




        public int SearchName(string warriorName, List<Griego> greekWarriors)
        {
            foreach (Griego x in greekWarriors)
            {
                if (x.GetName() == warriorName) 
                {
                    return greekWarriors.IndexOf(x);
                }
            }
            return -1;
            
        }
        
        public int SeeWarriorPos(int pos)
        {
            pos = pos - 1;
            try
            {
                horseOccupants.ElementAt(pos).Retire();
            }
            catch
            {
                Console.WriteLine("No es una posición valida");
            }
            
        }
        public void GoHorse(string greekWarrior)
        {
            if (capacity >horseOccupants.Count())
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
            Console.WriteLine("La capacidad del caballo es "+capacity+" con una ocupación de "+occupation+" los guerreros ");
            foreach(Griego x in horseOccupants)
            {
                x.Retire();
            }
        }
    }
}
