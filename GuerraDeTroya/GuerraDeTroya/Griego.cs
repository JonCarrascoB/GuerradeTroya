using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuerraDeTroya
{
    class Griego
    {

        private string name;
        private int age;
        private int strength;
        private bool injured;
        private bool dead;

        //***************************** CONSTRUCTORES ************************************
        public Griego()
        {
            name = "GreekX";
            age = 20;
            strength = 8;
        }


        public Griego(string name, int age, int strength, bool injured, bool dead)
        {
            this.name = name;
            if (CheckAge(this.age))
            {
                this.age = age;
            }
            else
            {
                age = 25;
            }

            if (CheckStrength(this.strength))
            {
                this.strength = strength;
            }
            else
            {
                strength = 5;
            }
            this.injured = injured;
            this.dead = dead;
        }




        //****************** GET Y SET *******************
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetStrength()
        {
            return strength;
        }
        public void SetStrength(int strength)
        {
            this.strength = strength;
        }

        //********************* METODOS *****************************
        public bool Retire()
        {
            bool retirarse = false;
            if (dead )
            {
                Console.WriteLine("Los muertos no se pueden retirar");
            }
            else if (!dead && injured)
            {
                Console.WriteLine("El COBARDE guerrero griego huye con el rabo entre las piernas");
                retirarse = true;
            }
            else if (!dead && !injured)
            {
                Console.WriteLine("El VALIENTE guerrero griego se mantiene firme bajo la nube de flechas");
            }
            return retirarse;
        }

        public bool CheckAge(int age)
        {
            if (this.age >= 15 || this.age <= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckStrength(int strength)
        {
            if (this.strength >= 1 || this.strength <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
