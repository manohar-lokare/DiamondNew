using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DiamondKataNew
{
    public class Diamond
    {
        private static readonly char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
        public static string Create(char v)
        {

            string diamondStr = string.Empty;
            if(v < 'A' || v > 'Z')
            {
                throw new ArgumentException(nameof(v));
            }
            else
            {
                try
                {
                    //get the letter Index
                    var letterIndex = Array.IndexOf(alphabet, v);
                    //calculate the size of array that needs to be created
                    var size = (letterIndex * 2) + 1;
                    var diamond = new string[size];

                    for (int i = 0; i <= letterIndex; i++)
                    {
                        //Add a blank space 
                        var strLine = Enumerable.Repeat(' ', letterIndex + 1).ToArray();
                        //get the alphabet from the alphabet array and assign it to string array created above
                        strLine[i] = alphabet[i];

                        // reverse the string array
                        var curLineMirrored = strLine.Reverse().Concat(strLine.Skip(1));
                        //assign the diamond value based on the below logic
                        diamond[i] = diamond[size - 1 - i] = string.Concat(curLineMirrored);
                    }
                    diamondStr = string.Join('\n', diamond);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                
            }
            return diamondStr;
        }
    }
}
