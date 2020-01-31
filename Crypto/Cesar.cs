using System.Collections.Generic;

namespace Crypto
{
    public class Cesar
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
            List<char> decoded = new List<char>();
            foreach (char ch in arr)
            {
                char tmp = (char)((int)(ch) - shift);
                decoded.Add(tmp);
            }
            return new string(decoded.ToArray());
        }
    }
}
