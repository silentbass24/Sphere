using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaoloCiolaProvaFinale
{
    //Declaration of Sfera class
    class Sfera
    {
        //Declaration of private class variables
        private double _raggio, _superficie, _volume;

        //Default constructor
        public Sfera()
        {
            this._raggio = 0.0;
            this._superficie = 0.0;
            this._volume = 0.0;
        }

        //Second type of constructor 
        public Sfera(double r, double v, double s)
        {
            this._raggio = r;
            this._superficie = s;
            this._volume = v;
        }

        //Sphere properties
        //Radius property
        public double Raggio
        {
            get { return this._raggio; }
            set 
            { 
                if (value <= 0)
                {
                    throw new Exception("Il raggio deve essere >=0");
                }
                else
                {
                    this._raggio = value;
                }
            }
        }
        //Area property
        public double Superficie
        {
            get { return this._superficie; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("La superficie deve essere >=0");
                }
                else
                    this._superficie = value;
            }
        }
        //Volume property
        public double Volume
        {
            get { return this._volume; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Il volume deve essere >=0");
                }
                else
                    this._volume = value;
            }
        }
        //Area Calculation from radius
        public double Area()
        {
            double sup = 0;

            sup = 4 * Math.PI * Math.Pow(this._raggio, 2);

            return sup;
        }
        //Volume Calculation from radius
        public double VolumeSfera()
        {
            double vol = 0.0;
            double rapp = (double)4 / (double)3;
            vol = rapp * Math.PI * Math.Pow(this._raggio, 3);
            return vol;
        }
        //Radius Calculation from Area
        public double SuptoRaggio()
        {
            double r;
            r = Math.Sqrt(this._superficie / (4 * Math.PI));
            return r;

        }
        //Radius Calculation from Area
        public double VoltoRaggio()
        {
            double r, inter, esp;
            inter = ((double)3 / (double)4 * this._volume) / Math.PI;
            esp = (double)1 / (double)3;
            r = Math.Pow(inter, esp);
            return r;

        }
        //Volume Calculation from Area
        public double SuptoVol()
        {
            double vol, r;
            r = SuptoRaggio();
            double rapp = (double)4 / (double)3;
            vol = rapp * Math.PI * Math.Pow(r, 3);
            return vol;
        }
        //Area Calculation from Volume
        public double VoltoSup()
        {
            double sup, r;
            r = VoltoRaggio();
            sup = 4 * Math.PI * Math.Pow(r, 2);
            return sup;
        }
        //File text for radius input selection
        public string StampaSferaRaggio()
        {
            return "Raggio della Sfera in metri: " + this._raggio + "\nArea della sfera in metri quadri: " + Math.Round(this.Area(),2) + "\nVolume della sfera i metri cubi: " + Math.Round(this.VolumeSfera(),2);
        }
        //File text for Area input selection
        public string StampaSferaArea()
        {
            return "Raggio della Sfera in metri: " + Math.Round(this.SuptoRaggio(),2) + "\nArea della sfera in metri quadri: " + this._superficie + "\nVolume della sfera i metri cubi: " + Math.Round(this.SuptoVol(),2);
        }
        //File text for Volume input selection
        public string StampaSferaVolume()
        {
            return "Raggio della Sfera in metri: " + Math.Round(this.VoltoRaggio(), 2) + "\nArea della sfera in metri quadri: " + Math.Round(this.VoltoSup(),2) + "\nVolume della sfera i metri cubi: " + this._volume;
        }


    }
}
