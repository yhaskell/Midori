using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Midori.Lexer
{
    class Lexer
    {
        public Lexer(string filePath, Encoding enc = null)
        {
            chars = System.IO.File.ReadAllText(filePath, enc ?? Encoding.UTF8).ToCharArray();
        }

        int currentPosition = 0;
        char[] chars;
       
        private IToken getNextToken()
        {
            int start = currentPosition;
            int end = currentPosition;
            int i = start;
            while (i < chars.Length)
            {

                 
            }
            return null;
        }

        public IEnumerable<IToken> Parse()
        {
            IToken result = null;
            while ((result = getNextToken())!=null) yield return result;
            yield break;
        }
    }
}
