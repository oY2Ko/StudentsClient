using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsClient.Models
{
    public class FillingInTest
    {
        public Test CorrectTest { get; set; }
        public int CurrentQuestion { get; set; }
        public double Score { get; private set; }
        public FillingInTest()
        {
            CurrentQuestion = 0;
            Score = 0;
        }
        public void AddScore(double score)
        {
            if (score <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Score += score;
        }
    }
}
