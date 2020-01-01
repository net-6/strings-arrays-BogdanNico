using System;
using System.Collections.Generic;
using System.Text;

namespace StringsAndArrays
{
    class RemoveOddIndexes
    {
        public string RemoveOdd(string anything)
        {
            StringBuilder newAnything = new StringBuilder();

            for (int i = 0; i < anything.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newAnything.Append(anything[i].ToString());
                }
            }

            return newAnything.ToString();

        }
    }
}
