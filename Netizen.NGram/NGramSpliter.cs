using System;
using System.Collections.Generic;

namespace Netizen.NGram
{
    public class NGramSpliter
    {
        public int MinSize { private set; get; }
        public int MaxSize { private set; get; }

        public NGramSpliter(int size, int? max=null)
        {
            MinSize = size;
            MaxSize = Math.Max(max ?? size, size);
        }

        public List<string> Split(string text)
        {
            List<string> result = new List<string>();
            if (text.Length < MinSize)
            {
                result.Add(text);
                return result;
            }

            for (int i = MinSize; i <= MaxSize; i++)
            {
                if (text.Length < i)
                {
                    break;
                }
                int end = text.Length - i;
                for (int j = 0; j <= end; j++)
                {
                    result.Add(text.Substring(j, i));
                }
            }
            return result;
        }
    }
}
