using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Lecture_11_Interfaces
{
    internal interface ISlamShut
    {
        // Constant Fields
        const string _slammingSound = "soundLocation";

        // Method Signatures
        public void SlamShut();
    }
}
