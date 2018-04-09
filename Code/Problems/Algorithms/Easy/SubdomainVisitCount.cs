using System;
using System.Collections.Generic;
using System.Text;

namespace Raw.LeetCode.Code.Problems.Algorithms.Easy
{
    public static class SubdomainVisitCount
    {
        public static IList<string> Solution(string[] cpdomains)
        {
            IDictionary<string, int> subdomains = new Dictionary<string, int>();
            IList<string> result = new List<string>();

            foreach(string cpdomain in cpdomains)
            {
                string fullDomain = string.Empty;
                string[] mapping = cpdomain.Split(' ');
                string[] domains = mapping[1].Split('.');
                int count = int.Parse(mapping[0]);
                for(int i = domains.Length - 1; i >= 0; i--)
                {
                    fullDomain = domains[i] + fullDomain;
                    if(!subdomains.ContainsKey(fullDomain))
                    {
                        subdomains.Add(fullDomain, count);
                    }
                    else
                    {
                        subdomains[fullDomain] = subdomains[fullDomain] + count;
                    }

                    fullDomain = '.' + fullDomain;
                }
            }
            
            foreach(string key in subdomains.Keys)
            {
                result.Add(string.Format("{0} {1}", subdomains[key], key));
            }

            return result;
        }
    }
}
