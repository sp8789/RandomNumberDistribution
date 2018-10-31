using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberDistribution
{
   public class RNumber
    {
        public static readonly Random RandomGenerator = new Random();

        public string GetDistributedRandomNumber(IEnumerable<double> probs)
        {
            try
            {
                double totalCount = 0.0;
                double numberprob = 0.0;
                string outputValue = string.Empty;
                List<double> tmpprobs = new List<double>();
                foreach (var p in probs)
                {
                    tmpprobs.Add(p);
                    totalCount += p;
                }
                double total_random = RandomGenerator.NextDouble();
                double mx = -1, mn = -1;

                foreach (var p in tmpprobs)
                {
                    if (p < 0) throw new ArgumentException("probs contains a negative probability.");
                    mx = (mx < 0 || p > mx) ? p : mx;
                    mn = (mn < 0 || p < mn) ? p : mn;
                }
                if (mx == mn)
                {
                    return outputValue = Convert.ToString("0 to " + (tmpprobs.Count - 1) + "with equal probability.");
                }
                for (int i = 0; i < tmpprobs.Count; i++)
                {
                    numberprob = tmpprobs[i] / totalCount;
                    if (tmpprobs[i] > total_random)
                    {
                        outputValue += Convert.ToString(i + " with " + numberprob + " probability ") + ",";
                    }
                }
                return outputValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
