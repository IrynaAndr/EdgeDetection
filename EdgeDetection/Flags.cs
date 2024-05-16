using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetection
{
    internal class Flags
    {
        public static bool imageIsGrey = false;
        public static double[] variance = null;

        public static void restoreDefault()
        {
            imageIsGrey = false;
            variance = null;
        }
    }
}
