using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    public class SuperHero : Hero //subclass of Hero
    {
        string[] _superPowers = new string[3]; //Private instance variable 


        /* Public Properties */

        /**
         * This constructor inherits the Hero's 
         * @Constructor SuperHero
         * @param {string name}
         */
        public SuperHero(string name) :
            base(name)
        {
            _generateRandomPowers();
            ShowPowers();
        }
        /*Private Methods*/

        /**
         * The _generateRandomPowers method is responsible for generating 3 random powers, based on the string array superPowers  
         * @method _private _generateRandomPowers 
         * @string[] superPowers
         */

        private void _generateRandomPowers()
        {
            string[] superPowers = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control", "Telepathy", "Mind Control", "Control Time", "Telekenesis", "Power of Flight", "Shapeshifting" };
            Random rnd = new Random(); //Created a random generator, for choosing 3 superhero abilities
            int numbOfPowers = 3; //assigns number of super powers, there is only a limit of 3
            int holder; //t

            /* Created a basic loop with the _generateSuperPowers method generates 
             * three random powers from the 
             */

            while (numbOfPowers > 0) /*Uses random number to choose and assign SuperPower a value from superPowers list*/
            {
                holder = rnd.Next(superPowers.Length); //assigns random number to holder variable variable

                this._superPowers[numbOfPowers - 1] = superPowers[holder];

                if (superPowers[holder] != "Not your lucky day, try again") //These are intialized as place holder strings if the suoerpower[Holder] chooses a power, that is out of the valid Super power number scope 
                {

                    superPowers[holder] = "OMG... pretend it never happend, try again"; //These are intialized as place holder strings if the suoerpower[Holder] chooses a power, that is out of the valid Super power number scope
                    numbOfPowers--; //number of Powers decrementor
                }
            }
        }

        /*Public Methods*/

        /**
         * The method below shows all the magic, it displays the user's superhero abilities, and formats the the output to the console
         * @method public ShowPowers
         * Description: Displays output rellating to the superhero class to the console
         * 
         */
        public void ShowPowers() //Displays	the	Hero’s	superpowers to	the	console
        {
            string AwesomeOutput = "_________________________";
            int pFactor = 0; //sets the superpower number, used later for displaying to the console, once the program starts  
            Console.WriteLine();
            Console.WriteLine("_________________________");
            Console.WriteLine();
            Console.WriteLine("{0}'s Super Abilities!\n{1}", this.Name, AwesomeOutput);
            Console.WriteLine(AwesomeOutput);
            foreach (string ability in _superPowers)
            {
                Console.WriteLine("{0}. {1}\n{2}", pFactor + 1, ability, AwesomeOutput); 
                pFactor++;
            }
            Console.WriteLine(AwesomeOutput);
        }
    }
}

