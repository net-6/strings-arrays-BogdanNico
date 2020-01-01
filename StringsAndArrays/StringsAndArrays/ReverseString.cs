using System;
using System.Collections.Generic;
using System.Text;

namespace StringsAndArrays
{
    class ReverseString
    {
        public string Reverse(string anything)
        {
            StringBuilder newAnything = new StringBuilder();

            for (int i = anything.Length - 1; i >= 0; i--)
            {
                newAnything.Append(anything[i].ToString());
              
            }

            return newAnything.ToString();

        }
    }
}
