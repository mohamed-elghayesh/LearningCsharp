using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Partner : ILoyaltyCardHolder
    {
        private int totalPoints;
        public int TotalPoints
        {
            get { return totalPoints; }
        }

        public int AddPoints(decimal transactionValue)
        {
            int points = decimal.ToInt32(transactionValue);
            return totalPoints += (2 * points);
        }

        public void ResetPoints()
        {
            totalPoints = 0;
        }
    }
}
