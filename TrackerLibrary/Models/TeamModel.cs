using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {

        public int Id { get; set; }
        /// <summary>
        /// Represents the team's name.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Represents the Members of this team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        
        

        
    }
}
