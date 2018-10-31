using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String strResult = Console.ReadLine();
                if (strResult == string.Empty)
                {
                    Console.WriteLine("Please enter a value");
                    strResult = Console.ReadLine();
                }
                RNumber objRNumber = new RNumber();
                List<double> ProbTag = strResult.Split(',').Select(double.Parse).ToList();
                string strOutput = objRNumber.GetDistributedRandomNumber(ProbTag);
                strOutput = strOutput.Replace(",", System.Environment.NewLine);
                Console.Write(strOutput);
                Console.Read();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
