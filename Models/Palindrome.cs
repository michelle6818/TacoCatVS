using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TacoCat.Models
{
    //This is a view model - it helps my views not my database
    public class Palindrome
    {
        //The word the user inputs  Set by user
        public string InputWord { get; set; }

        //that word reversed...set by code
        public string RevWord { get; set; }

        //is it a palindrome.....false by default...code will set value
        public bool IsPalindrome { get; set; }

        //what do i output?....
        public string Message { get; set; }

    }
}
