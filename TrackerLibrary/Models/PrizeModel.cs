using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the unique Identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the which place a team is in.(Example: 1 for 1st place, 2 for 2nd place etc.)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the place.(Example: Champion for 1st place, 1st Runner-Up for secont place etc.)
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize money the team gets in a particular place.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the total prize pool.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;



        }
    }
}
