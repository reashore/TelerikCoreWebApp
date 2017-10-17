using System;

namespace TelerikCoreWebApp.Models
{
    public enum FundingModel
    {
        FundingModel1,    
        FundingModel2,    
        FundingModel3,    
        FundingModel4,    
        FundingModel5,    
        FundingModel6
    }

    public class ClbcProgram
    {
        public int ProgramId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public FundingModel FundingModel { get; set; }
    }
}
