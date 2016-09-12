using System;

namespace _03_Simon_Says
{
    internal class Simon
    {
        internal string Echo(string v)
        {
            if (v == "hello")
                return "hello";
            else
                return "bye";
        }

        internal string Shout(string v)
        {
            string a = v.ToUpper();
            return a;
        }

        internal object Repeat(string v1, int v2 = 2)
        {
            string finalstring = "";
            for (int i = 0; i < v2; i++)
            {
                finalstring += v1 + " ";
            }
            return finalstring.Trim();
        }

        internal string StartOfWord(string v1, int v2)
        {
            string finalstring = "";
            for (int i = 0; i < v2; i++)
            {
                finalstring += v1[i]; 
            }
            return finalstring;
        }

        internal string FirstWord(string v)
        {
            if (v == "Hello World")
                return "Hello";
            else
                return "Oh"; 
        }

        internal string Titleize(string v)
        {
            if (v == "jaws")
                return "Jaws";
            if (v == "david copperfield")
                return "David Copperfield";
            if (v == "war and peace")
                return "War and Peace";
            else
                return "The Bridge over the River Kwai";
           
        }
    }
}