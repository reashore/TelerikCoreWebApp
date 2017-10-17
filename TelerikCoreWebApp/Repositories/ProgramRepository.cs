using System;
using System.Collections.Generic;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Repositories
{
    public interface IClbcProgramRepository
    {
        IEnumerable<ClbcProgram> ClbcPrograms { get; }
        void AddClbcProgram(ClbcProgram clbcProgram);
    }

    public class ClbcProgramRepository : IClbcProgramRepository
    {
        private readonly List<ClbcProgram> _clbcProgramList = new List<ClbcProgram>
        {
            new ClbcProgram
            {
                ProgramId = 1, Name = "Program", Description = "A long program description", StartDate = DateTime.Now, FundingModel = FundingModel.FundingModel1
            },
            new ClbcProgram
            {
                ProgramId = 1, Name = "Program", Description = "A long program description", StartDate = DateTime.Now, FundingModel = FundingModel.FundingModel2
            },
            new ClbcProgram
            {
                ProgramId = 1, Name = "Program", Description = "A long program description", StartDate = DateTime.Now, FundingModel = FundingModel.FundingModel3
            },
            new ClbcProgram
            {
                ProgramId = 1, Name = "Program", Description = "A long program description", StartDate = DateTime.Now, FundingModel = FundingModel.FundingModel4
            },
            new ClbcProgram
            {
                ProgramId = 1, Name = "Program", Description = "A long program description", StartDate = DateTime.Now, FundingModel = FundingModel.FundingModel5
            }
        };

        public IEnumerable<ClbcProgram> ClbcPrograms => _clbcProgramList;

        public void AddClbcProgram(ClbcProgram clbcProgram)
        {
            _clbcProgramList.Add(clbcProgram);
        }
    }
}
