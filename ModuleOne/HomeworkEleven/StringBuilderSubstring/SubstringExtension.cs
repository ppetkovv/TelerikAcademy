using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            return new StringBuilder((str.ToString().Substring(index, length)));
        }
    }
}