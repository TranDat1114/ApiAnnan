using System.Collections.Generic;

using ApiAnnan.IServices;
using ApiAnnan.Models;

using Microsoft.EntityFrameworkCore;

namespace ApiAnnan.Services
{
    public class ProjectServices : IProjectService
    {
        private readonly CrowdFundingDbContext _context;

        public ProjectServices(CrowdFundingDbContext context)
        {
            _context = context;
        }

        public void AddProject(Project project)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Project>> Get100Projects()
        {
            List<Project> projects = new List<Project>();

            projects = await _context.Projects.IgnoreAutoIncludes().Select(p => new Project()
            {
                ProjectId = p.ProjectId,
                Name = p.Name,
                Description = p.Description,
                EndDate = p.EndDate,
                StartDate = p.StartDate,
                CurrentAmount = p.CurrentAmount,
                TargetAmount = p.TargetAmount,
                Donations = p.Donations.Select(pi => new Donation()
                {
                    DonationId = pi.DonationId
                }).ToList(),
                UserId = p.UserId,
                User = p.User,
            })
       .AsSingleQuery().ToListAsync();
            return projects;
        }

        public Project GetProjectById(int projectId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
