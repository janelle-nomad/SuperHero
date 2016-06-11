using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    public class Hero
    {
        /**
         * Private Instance Variables
         * <summary> Creating Private Properties </summary>
         *
         */
        string AwesomeOutput = "************************"; //adding format text from SuperHero Class
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        /**
         * PUBLIC PROPERTIES
         * <summary> Creating Public Properties </summary>
         * 
         * @assigns _strength as a value, through public Strength method
         * @assigns _speed as a value, through public Speed method
         * @assigns _health as a value, through public Health method
         * @assigns _name as a value, through public Name method
         */

        //Adjusting the _strength private variable to a public property through get and sets
        public int Strength
        {
            get { return this._strength; }
            set { this._strength = value; }
        }

        //Adjusting the _speed private variable to a public property through get and sets
        public int Speed
        {
            get { return this._speed; }
            set { this._speed = value; }
        }
        //Adjusting the _health private variable to a public property through get and sets
        public int Health
        {
            get { return this._health; }
            set { this._health = value; }
        }
        //Adjusting the _name private variable to a public property through get and sets
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /**
         * Description: This is the hero constructor for the hero class takes a string param in the constructor
         * @Constructor Hero
         * @param {string name}
         */


        //Making the stats into local variables, except for name, so they can be easily accessible
        public Hero(string name)
        {
            int strength;
            int speed;
            int health;

            this.Name = name;        /* Declared that the private _name, is associated with "name",
                                     which is a public property 
                                      */
            this.Strength = Strength; //Redefining the strength property
            this.Speed = Speed;
            this.Health = Health;

            _generateAbilities();
            Console.WriteLine();
            show();
        }
        private void _generateAbilities() //declaring the private method, generate abilities
        {
            Random stats = new Random();//Random generator in order to generate random numbers for the hero's abilities

            this.Strength = stats.Next(1, 101); //strength can be an integer ranging between 1 - 100
            this.Speed = stats.Next(1, 101);    // speed can be an integer ranging between 1 - 100
            this.Health = stats.Next(1, 101);  //health can be an integer ranging between 1 - 100
        }
        /**
         *  
         *  @method _hitAttempt
         *  @description: Uses a random number generator to determine the hero's hitChance towards its target
         */

        private void _hitAttempt()  //hit Attempt Method: This will determine the success of the attack
        {
            Random rnd = new Random();
            int hitChance = rnd.Next(1, 101); // generates random int between 1 and 100
            Console.WriteLine();
            Console.WriteLine("Your hit chance is {0}", hitChance);
            if (hitChance > 80) //Player hits with 20% accuracy - this rule was defined in the requirements
            {
                Console.WriteLine(AwesomeOutput);
            
                Console.WriteLine("You landed a hit!, Great Job!"); // Here the _hitAttempt = true, so the _damage method is called
                _hitDamage(); // on a hit, calls the hitDamage method
                Console.WriteLine(AwesomeOutput);
            }
            else
            {
                Console.WriteLine("You missed! Better luck next time! =("); // on a miss, prints result and terminates
            }
        }

        // _hitDamage to determine the damage, that the hero can dish out
        // created three local variables to handle smaller things, potientialDmg (hero's potential damage 1-6), damageBoost is a number multiplied by the hero's strength, & damage dealt = player damage
        private int _hitDamage()
        {
            int potentialDmg, damageBoost, dmgDealt;
            Random rnd = new Random();
            potentialDmg = rnd.Next(6) + 1; //The hero's potential damage is a number between 1 and 6 this number will then be multiplied by the hero's strength 
            damageBoost = this.Strength; // multiplies damage with hero strength
            dmgDealt = potentialDmg * damageBoost;
            Console.WriteLine();
            Console.WriteLine("You damage is {0}\nYou dealt {1} damage!", potentialDmg, dmgDealt);
            return dmgDealt; //sends final damage result with modifiers
        }

        /**PUBLIC METHODS
         * 
         * @methods: fight method; show method 
         */

        // method to start a fight
        public void fight()
        {
            _hitAttempt(); //calls hitAttempt method
        }
        public void show() // method to show character's current stats
        {
            Console.WriteLine("_________________________");
            Console.WriteLine();
            Console.WriteLine("{0}'s Stats\nStrength  Speed  Health \n========  =====  ======\n{1, 6}{2, 8}{3, 8}", this.Name, this.Strength, this.Speed, this.Health); // Shows hero's stats, it's better to call this before calling the fight method
        }
    }
}
