using System;

namespace StringOfObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            Enemy[] enemies =                    //string of class Enemy
            {
                new Enemy("Monster"),            //object of class Enemy
                new Enemy("Dragon")              //another object
            };

            foreach(Enemy enemy in enemies)     //variable enemy of data-type Enemy, enemies is the instance
            {
                enemy.Attack();
            }
        }
    }

    class Enemy
    {
        private string name;

        public Enemy(string name)               //constructor
        {
            this.name = name;
        }

        public void Attack()
        {
            Console.WriteLine(name + " attacked.");
        }
    }
}
