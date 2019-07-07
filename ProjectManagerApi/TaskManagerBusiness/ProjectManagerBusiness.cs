using System.Collections.Generic;
using TaskManagerDataAccess;

namespace TaskManagerBusiness
{
    public class ProjectManagerBL
    {
        public List<Task> ReadAllTask()
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            return taskManagerDA.ReadAllTask();
        }

        public List<ParentTask> ReadAllParentTask()
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            return taskManagerDA.ReadAllParentTask();
        }

        public Task ReadTask(int TaskId)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            return taskManagerDA.ReadTask(TaskId);
        }

        public ParentTask ReadParentTask(int? TaskId)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            return taskManagerDA.ReadParentTask(TaskId);
        }

        public void AddTask(Task task)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            taskManagerDA.AddTask(task);
        }

        public void EndTask(int taskId)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            taskManagerDA.EndTask(taskManagerDA.ReadTask(taskId));
        }

        public void UpdateTask(Task task)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            taskManagerDA.UpdateTask(task);
        }

        public List<User> ReadAllUsers()
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            return taskManagerDA.ReadAllUsers();
        }

        public User ReadUser(int? userId)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            return taskManagerDA.ReadUser(userId);
        }

        public void AddUser(User user)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            taskManagerDA.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            taskManagerDA.UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            taskManagerDA.DeleteUser(taskManagerDA.ReadUser(userId));
        }

        public List<Project> ReadAllProjects()
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            return taskManagerDA.ReadAllProjects();
        }

        public Project ReadProject(int? projectId)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            return taskManagerDA.ReadProject(projectId);
        }

        public void AddProject(Project project)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            taskManagerDA.AddProject(project);
        }

        public void UpdateProject(Project project)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            taskManagerDA.UpdateProject(project);
        }

        public void DeleteProject(int projectId)
        {
            ProjectManagerDA taskManagerDA = new ProjectManagerDA();
            taskManagerDA.DeleteProject(taskManagerDA.ReadProject(projectId));
        }
    }
}