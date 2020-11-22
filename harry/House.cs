using System;
using System.Collections.Generic;
using System.Text;

namespace harry
{
    abstract class House
    {

        string consonants = "BCDFGHJKLMNPQRSTVXZbcdfghjklmnpqrstvxz";
        string vowels = "AEIOUYÅÄÖaeiouyåäö";

        public bool HasCorrectPasswordFormat(string house, string password)
        {
            if (house == "Slytherin")
            {
                foreach (char c in consonants)
                {
                    if (c == password[(password.Length - 1)] && password.Length >= 8)
                    {
                        foreach (char d in consonants)
                        {
                            if (d == password[0])
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
            else
            {
                foreach (char c in consonants)
                {
                    if (c == password[(password.Length - 1)] && password.Length >= 5)
                    {
                        foreach (char d in vowels)
                        {
                            if (d == password[0])
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }

        public string SetPassword(string house, string password)
        {
            if (HasCorrectPasswordFormat(house, password))
            {
                return password;
            }
            return null;
        }
    }
}
