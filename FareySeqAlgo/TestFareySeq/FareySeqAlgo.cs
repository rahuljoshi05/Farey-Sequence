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
            double tempX = 0, tempY = 0;
            try
            {
                result = "{";
                if (p < 0)
                {
                    throw new FormatException("Number has to be greater or equal to 0");
                }
                // We know first two terms are 0/1 and 1/n
                double x1 = 0, y1 = 1, x2 = 1, y2 = p;
                result = result + x1 + "/" + y1;
                result = result+", " + x2 + "/" + y2;

                while (tempY != 1.0)
                {
                    // Using recurrence relation to find the next term
                    tempX = Math.Floor((y1 + p) / y2) * x2 - x1;
                    tempY = Math.Floor((y1 + p) / y2) * y2 - y1;
                    //Capture result
                    result = result + ", " + tempX + "/" + tempY;
                    // Update x1, y1, x2 and y2 for next iteration
                    x1 = x2;
                    x2 = tempX;
                    y1 = y2;
                    y2 = tempY;
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
