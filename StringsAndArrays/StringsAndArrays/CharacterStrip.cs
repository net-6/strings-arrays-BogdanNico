using System;
using System.Collections.Generic;
using System.Text;

namespace StringsAndArrays
{
    class CharacterStrip
    {
        public string Strip(string anything)
        {
            StringBuilder newAnything = new StringBuilder();

            char[] CharsToDelete = { ' ', '/', '<', '1', '2', '3', '4', '5', '7', '8', '9' };

            for (int i = 0; i < anything.Length; i++)
            {
               // if (anything[i] != CharsToDelete)
                {
                    newAnything.Append(anything[i].ToString());
                }
            }

            return newAnything.ToString();
        }

    }
}
