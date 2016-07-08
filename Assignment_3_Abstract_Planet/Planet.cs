using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Abstract_Planet
{
    abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES=====================================================
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private int _rotationPeriod;

        // CONSTRUCTORS =====================================================================
        public Planet()
        {
            throw new System.NotImplementedException();
        }

        // PUBLIC PROPERTIES==============================================================
        /**
         * This is the public property for private _diameter field
         * 
         * @property {double} Diameter
         */
        public double Diameter
        {
            get
            {
                return this._diameter;
            }

            
        }

        public double Mass
        {
            get
            {
                throw new System.NotImplementedException();
            }

            
        }

        public int MoonCount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            
        }

        public double OrbitalPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int RingCount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double RotationPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
