﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuerraDeTroya
{
    class Troyano
    {
        private string name;
        private int age;
        private int strength;
        private bool injured;
        private bool dead;

        //***************************** CONSTRUCTORES ************************************
        public Troyano()
        {
            name = "TroyanoX";
            age = 18;
            strength = 10;
            injured = false;
            dead = false;
        }


        public Troyano(string name, int age, int strength, bool injured, bool dead)
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

        public bool GetInjured()
        {
            return injured;
        }
        public void Setinjured(bool injured)
        {
            this.injured = injured;
        }

        public bool GetDead()
        {
            return dead;
        }
        public void SetDead(bool dead)
        {
            this.dead = dead;
        }

        //********************* METODOS *****************************
        public bool Retire()
        {

            Console.WriteLine("El guerrero " + GetName() + " cuya edad es " + GetAge() + " y su fuerza " + .GetStrength());
            if (injured&&!dead)
            {
                Console.WriteLine("El guerrero esta herido");
            }
            else if (dead)
            {
                Console.WriteLine("El guerrero esta muerto");
            }
            else
            {
                Console.WriteLine("El guerrero no esta herido");
            }
            Console.WriteLine("Los guerreros troyanos no pueden ¡¡¡NUNCA RETIRARSE!!!");
            return false;
        }

        public bool CheckAge(int age)
        {
            if (this.age >= 15 && this.age <= 60)
            {
                return true;
            }
            return false;
            
        }

        public bool CheckStrength(int strength)
        {
            if (this.strength >=1 && this.strength <=10)
            {
                return true;
            }
            return false;
            
        }





    }
}
