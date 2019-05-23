using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    interface IFluid
    {
        void Diffuse();
        void Project();
        void Advect();
    }
}
