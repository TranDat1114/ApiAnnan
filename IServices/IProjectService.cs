using ApiAnnan.Models;

namespace ApiAnnan.IServices
{
    public interface IProjectService
    {
        public Project GetProjectById(int projectId);
        public Task< List<Project>> Get100Projects();
        public void DeleteProject(int projectId);
        public void AddProject(Project project);
        public void UpdateProject(Project project);
        
    }
}
