using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Abstract_Planet
{
    class GiantPlanet : Planet , IHasMoons , IHasRings
    {
        private string _type;


        public GiantPlanet(string name, double diameter, double mass) : base(name, diameter, mass)
        {
        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }

        public bool HasRings()
        {
            throw new System.NotImplementedException();
        }
    }
}
