using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Author : Chenyuan Xie
 * Date : Jul 7th, 2016
 * Date Modified: Jul 8th, 2016
 * Description : Assignment 3
 * Version : 0.9 - 
 *                  Finished Part 7
 *                  
 */
namespace Assignment_3_Abstract_Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet Saturn = new GiantPlanet("Saturn",25000, 95.159,"Gas");
            TerrestrialPlanet Earth = new TerrestrialPlanet("Earth",3474.8,1,true);
        }

        public void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
