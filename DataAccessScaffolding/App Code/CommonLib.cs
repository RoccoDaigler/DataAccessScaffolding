using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessScaffolding
{
    internal class CommonLib
    {
        public static string sqlclean(string str)
        {
            string strOut = "";
            if (str != null)
            {
                strOut = str.Replace("'", "''");
            }
            return strOut;
        }

        public static string GetDisplayName(string table_name)
        {
            string displayName = "";
            string[] words = table_name.Split('_');

            foreach (string word in words)
            {
                displayName = displayName + CapitlizeFirstLetter(word);
            }

            return displayName;
        }

        public static string GetDisplayNameWithSpaces(string table_name)
        {
            string displayName = "";
            string[] words = table_name.Split('_');

            foreach (string word in words)
            {
                displayName = displayName + CapitlizeFirstLetter(word) + " ";
            }

            return displayName;
        }

        public static string CapitlizeFirstLetter(string word)
        {
            return char.ToUpper(word.ToCharArray()[0]).ToString() + word.Substring(1);
        }
    }
}