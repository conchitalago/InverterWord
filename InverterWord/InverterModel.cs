using System;
using System.Collections.Generic;
using System.Text;

namespace InverterWord
{
    public class InverterModel
    {
        public static string InvertWord(string word)
        {
            string result = "";
            if (word.Length == 0)//Si la palabra solo tiene un caracter devuelve la misma palabra
            {
                result = word;
            }
            else
            {
                result = InvertWord(word.Substring(1)) + word[0];
            }
            return result;
        }
    }
}
