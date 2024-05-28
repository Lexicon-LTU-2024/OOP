using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

internal static class StringExtensions
{
    public static string AddString(this string firstWord, string secondWord)
    {
        return $"{firstWord} {secondWord}";
    }  
    
    
    public static void ChangeName(this Person person, string newname)
    {
       person.Name = newname;
    }
}
