using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*
        Janelle Heron
        300839820 
        COMP 123 - Summer 2016
        
     */
namespace SuperHero
{
    /**
    * This class is the "driver" class for our Program
    * 
    * @class Program
    * <summary>The purpose of this program, is to create a superhero class and add a prexisting class Hero 
    * into the mix, to see the synchronization, and simplicity that the concept of "Inheritance" brings to Object Oriented
    * Programming
    * </summary>
    * Version 0.6 - Added some comments for readability
    */
     public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         * @returns {void}
         */
        static void Main(string[] args)
        {
            string superheroName;// declares a string superheroName

            Console.Write("Enter your Superhero's name: "); //Prompts user for name
            superheroName = Console.ReadLine();

            SuperHero userSuperHero = new SuperHero(superheroName); //creates a new SuperHero instance with user input as the hero's name
            userSuperHero.fight(); //Inherits the Fight method from the Hero Class
        }
    }
}
