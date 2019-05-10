using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Customer : ILoyaltyCardHolder
    {
        private int totalPoints;
        public int TotalPoints
        {
            get { return totalPoints; }
        }

        public int AddPoints(decimal transactionValue)
        {
            int points = decimal.ToInt32(transactionValue);
            return totalPoints += points;
        }

        public void ResetPoints()
        {
            totalPoints = 0;
        }
    }
}
