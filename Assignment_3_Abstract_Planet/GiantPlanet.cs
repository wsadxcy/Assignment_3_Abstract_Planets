using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Abstract_Planet
{
    /**
     * <summary>
     * This is the GiantPlanet class. It is derived from the Planet class
     * </summary>
     * 
     * @class GiantPlanet
     * @extends Planet
     */
    class GiantPlanet : Planet , IHasMoons , IHasRings
    {
        // PRIVATE INSTANCE VARIABLES========================================================
        private string _type;

        // CONSTRUCTORS =====================================================================
        /**
        * <summary>
        * This is the constructor for the GiantPlanet class. 
        * It take all the parameters of the Planet bass class as well as type as a local variable 
        * and set the related instance variable (_type) to its value.
        * </summary>
        * 
        * @extends Planet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {string} type
        * @constructor GiantPlanet
        */
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
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
        * This Method return true if the RingCount property is greater than zero.
        * </summary>
        * 
        * @method HasRings
        * @returns {bool}
        */
        public bool HasRings()
        {
            if (RingCount > 0)
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
