using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the unique identifier of a competitor.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the first name of a competitor.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents teh last name of a competitor.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address of a competitor.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the cellphone number of a competitor.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName}";
            }
        }
    }
}
