//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnterpriseComputingTeamProject1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public int Week { get; set; }
        public int Team1ID { get; set; }
        public int Team2ID { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        public int NumberOfSpectators { get; set; }
        public Nullable<int> TotalScore { get; set; }
        public Nullable<int> WinningID { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
    }
}
