using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class MatchPattern
    {
        public  string RegexRules = "^[a]{1,2}[b]{1,3}$";
        public  bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
