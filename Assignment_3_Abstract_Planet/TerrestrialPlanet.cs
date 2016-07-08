using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3_Abstract_Planet
{
    class TerrestrialPlanet : Planet ,IHabitable,IHasMoons
    {
        private bool _oxygen;

        public TerrestrialPlanet()
        {
            throw new System.NotImplementedException();
        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }

        public bool Habitable()
        {
            throw new System.NotImplementedException();
        }
    }
}
