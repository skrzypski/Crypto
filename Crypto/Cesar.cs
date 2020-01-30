using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Cesar
    {
        public int shift { get; private set; }

        public Cesar(int shift)
        {
            this.shift = shift;
        }

        public string Encode(string text)
        {
            char[] arr = text.ToCharArray();
            List<char> encoded = new List<char>();
            foreach(char ch in arr)
            {
                char tmp = (char)((int)(ch) + shift);
                encoded.Add(tmp);
            }
            return new string(encoded.ToArray());
        }

        public string Decode(string text)
        {
            char[] arr = text.ToCharArray();
            List<char> encoded = new List<char>();
            foreach (char ch in arr)
            {
                char tmp = (char)((int)(ch) - shift);
                encoded.Add(tmp);
            }
            return new string(encoded.ToArray());
        }
    }
}
