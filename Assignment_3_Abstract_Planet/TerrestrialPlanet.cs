using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3_Abstract_Planet
{
    class TerrestrialPlanet : Planet ,IHabitable,IHasMoons
    {
        // PRIVATE INSTANCE VARIABLES========================================================
        private bool _oxygen;

        // CONSTRUCTORS =====================================================================
        /**
        * <summary>
        * This is the constructor for the GiantPlanet class. 
        * It  take all the parameters of the Planet base class as well as oxygen as a local variable 
        * and set the related instance variable (_oxygen) to its value.
        * </summary>
        * 
        * @extends Planet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {bool} oxygen
        * @constructor TerrestrialPlanet
        */
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // PUBLIC METHODS====================================================================
        /**
        * <summary>
        * This Method return true if the MoonCount property is greater than zero.
        * </summary>
        * 
        * @method HasMoons
        * @returns {bool}
        */
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
        * <summary>
        * This Method return true if the oxygen instance variable is greater than zero.
        * </summary>
        * 
        * @method Habitable
        * @returns {bool}
        */
        public bool Habitable()
        {
            if (_oxygen == true)
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
