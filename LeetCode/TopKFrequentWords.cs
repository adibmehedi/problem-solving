using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetCode
{
    internal class TopKFrequentWords
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var wordDict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordDict.ContainsKey(word))
                {
                    int count = wordDict[word];
                    wordDict.Remove(word);
                    wordDict.Add(word, ++count);
                }
                else
                {
                    wordDict.Add(word, 1);
                }
            }

            List<KeyValuePair<string, int>> resultList = wordDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(k).ToList();

            return resultList.Select(x => x.Key).ToList();

        }
    }
}
