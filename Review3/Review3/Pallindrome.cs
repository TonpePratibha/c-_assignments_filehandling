using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    public class Pallindrome
    {
        public bool ispalindrome(string str) {

            char[] chararray = str.ToCharArray();
            Array.Reverse(chararray);
            string reverse=new string(chararray);
            return str == reverse;
        }

    }
}
