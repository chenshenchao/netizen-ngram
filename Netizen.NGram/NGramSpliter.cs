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
            int max = Math.Min(MaxSize, text.Length);
            int min = Math.Min(MinSize, text.Length);
            int sc = text.Length - min + 1;
            int ec = text.Length - max + 1;
            int count = (sc + ec) * (sc - ec + 1) / 2;
            List<string> result = new List<string>(count);
            for (int i = min; i <= max; i++)
            {
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
