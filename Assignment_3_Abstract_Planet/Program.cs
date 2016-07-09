using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Author : Chenyuan Xie
 * Date : Jul 7th, 2016
 * Date Modified: Jul 8th, 2016
 * Description : Assignment 3
 * Version : 1.0 - 
 *                  Added Documentary for everything.
 *                  
 */
namespace Assignment_3_Abstract_Planet
{
    /**
    * This class is the driver class for the program
    * 
    * @class program
    */
    class Program
    {
        /**
         * this is the main method for my driver class
         * 
         * @method Main
         * @param {sting[]} args
         */
        static void Main(string[] args)
        {
            GiantPlanet Saturn = new GiantPlanet("Saturn",25000, 95.159,"Gas");
            TerrestrialPlanet Earth = new TerrestrialPlanet("Earth",3474.8,1,true);
        }
        /**
         * This is the method reads the console for any key press before the console is closed
         * 
         * @method WaitForAnyKey
         */
        public void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
