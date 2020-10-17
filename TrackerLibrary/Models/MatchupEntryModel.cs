using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents the unique identifier for the entry
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the unique identifier for the team
        /// </summary>
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represents one of the teams in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score of this team in particular.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the unique identifier for the parent matchup.
        /// </summary>
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Represents the matchup that this team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        

    }
}
