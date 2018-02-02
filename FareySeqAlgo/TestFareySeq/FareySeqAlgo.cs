using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFareySeq
{
    class FareySeqAlgo
    {
        public string getFareySeqForNumber(int p)
        {
            string result = "";
            try
            {
                result = "{";
                if (p < 0)
                {
                    throw new FormatException("Number has to be greater or equal to 0");
                }
                int a = 0, b = 1, c = 1, d = p, k = 0;
                result = result + a + "/" + b;
                while (c <= p)
                {
                    k = Convert.ToInt32((p + b) / d);
                    //    a, b, c, d = c, d, (k*c-a), (k*d-b)
                    a = c;
                    b = d;
                    c = (k * c - a);
                    d = (k * d - b);
                    result = result+", " + a + "/" + b;
                }
                result = result+ "}";

            }
            catch (FormatException ex)
            {

                throw;
            }
            return result;
        }
    }
}
