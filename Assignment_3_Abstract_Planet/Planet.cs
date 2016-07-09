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
        private double _rotationPeriod;

        // CONSTRUCTORS =====================================================================
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
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

        /**
         * This is the public property for private _mass field
         * 
         * @property {double} Mass
         */
        public double Mass
        {
            get
            {
                return this._mass;
            }   
        }

        /**
         * This is the public property for private _moonCount field
         * 
         * @property {int} MoonCount
         */
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }

            set
            {
                this._moonCount = value;
            }
        }

        /**
         * This is the public property for private _name field
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        /**
         * This is the public property for private _orbitalPeriod field
         * 
         * @property {double} OrbitalPeriod
         */
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }

            set
            {
                this._orbitalPeriod = value;
            }
        }

        /**
         * This is the public property for private _ringCount field
         * 
         * @property {int} RingCount
         */
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }

            set
            {
                this._ringCount = value;
            }
        }

        /**
         * This is the public property for private _rotationPeriod field
         * 
         * @property {double} RotationPeriod
         */
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }
        // PUBLIC METHODS===================================================================
        public override string ToString()
        {
            return Name.ToString() + ": " + Diameter.ToString() + Mass.ToString();
        }
    }
}
