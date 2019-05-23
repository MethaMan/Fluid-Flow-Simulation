using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Numerics;

// commit 2?
namespace Simulator
{
    class ViscFluid: IFluid
    {
        private double Density { get; set; }
        private double Viscosity { get; set; }
        private double Mass { get; set; }
        private double RenoldsNumber { get; set; }
        private double StartVelocity { get; set; } // m/s or mach?
        private double Compressibility { get; set; }
        //private Vec


        public ViscFluid(double rho, double v, double Re)
        {
            StartVelocity = v;
            RenoldsNumber = Re;
            Density = rho;
        }

        public void Diffuse()
        {

        }

        public void Project()
        {

        }

        public void Advect()
        {

        }
    }
}
