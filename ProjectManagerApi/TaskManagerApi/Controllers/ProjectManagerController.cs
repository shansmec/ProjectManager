using System;
using System.Collections.Generic;
using System.Web.Http;
using TaskManagerApi.Models;
using TaskManagerBusiness;
using DA = TaskManagerDataAccess;

namespace TaskManagerApi.Controllers
{
    public class ProjectManagerController : ApiController
    {
        [HttpGet]
        [ActionName("GetAllTasks")]
        // GET: api/TaskManager
        public IEnumerable<Task> GetAllTasks()
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            List<Task> lstTask = new List<Task>();
            foreach (var task in taskManagerBL.ReadAllTask())
            {
                lstTask.Add(new Task()
                {
                    Name = task.Task1,
                    EndDate = task.End_Date.ToString("dd/MM/yyyy"),
                    ParentId = task.Parent__ID,
                    StartDate = task.Start_Date.ToString("dd/MM/yyyy"),
                    Priority = task.Priority,
                    TaskId = task.Task_ID,
                    ParentTaskName = task.Parent__ID == null ? "" : taskManagerBL.ReadParentTask(task.Parent__ID).Parent_Task,
                    ProjectId=task.Project_ID
                });
            }
            return lstTask;
        }

        [HttpGet]
        [ActionName("GetAllParentTasks")]
        // GET: api/TaskManager/5
        public IEnumerable<ParentTask> GetAllParentTasks()
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            List<ParentTask> lstTask = new List<ParentTask>();
            foreach (var task in taskManagerBL.ReadAllParentTask())
            {
                lstTask.Add(new ParentTask()
                {
                    ParentId = task.Parent_ID,
                    ParentTaskName = task.Parent_Task
                });
            }
            return lstTask;
        }

        [HttpGet]
        [ActionName("GetTask")]
        // GET: api/TaskManager/5
        public Task GetTask(int id)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            DA.Task task = taskManagerBL.ReadTask(id);

            if (task != null)
                return new Task()
                {
                    Name = task.Task1,
                    EndDate = task.End_Date.ToString("dd/MM/yyyy"),
                    ParentId = task.Parent__ID,
                    StartDate = task.Start_Date.ToString("dd/MM/yyyy"),
                    Priority = task.Priority,
                    TaskId = task.Task_ID
                };
            return null;
        }

        [HttpPost]
        [ActionName("AddTask")]
        // POST: api/TaskManager
        public void AddTask([FromBody]Task task)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();

            taskManagerBL.AddTask(new DA.Task()
            {
                Task1 = task.Name,
                Parent__ID = task.ParentId,
                Priority = task.Priority,
                End_Date = Convert.ToDateTime(task.EndDate),
                Start_Date = Convert.ToDateTime(task.StartDate),
                Project_ID= task.ProjectId,
                
            });
        }

        [HttpPost]
        [ActionName("UpdateTask")]
        // PUT: api/TaskManager/5
        public void UpdateTask([FromBody]Task task)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();

            taskManagerBL.UpdateTask(new DA.Task()
            {
                Task_ID = task.TaskId,
                Task1 = task.Name,
                Parent__ID = task.ParentId,
                Priority = task.Priority,
                End_Date = Convert.ToDateTime(task.EndDate),
                Start_Date = Convert.ToDateTime(task.StartDate)
            });
        }

        [HttpGet]
        [ActionName("DeleteTask")]
        // DELETE: api/TaskManager/5
        public void DeleteTask(int id)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            taskManagerBL.EndTask(id);
        }

        [HttpGet]
        [ActionName("GetAllUsers")]
        // GET: api/TaskManager
        public IEnumerable<User> GetAllUsers()
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            List<User> lstUser = new List<User>();
            foreach (var user in taskManagerBL.ReadAllUsers())
            {
                lstUser.Add(new User()
                {
                    UserId = user.User_ID,
                    EmployeeId = user.Employee_ID,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    ProjectId = user.Project_ID,
                    TaskId = user.Task_ID
                });
            }
            return lstUser;
        }

        [HttpGet]
        [ActionName("GetUser")]
        // GET: api/TaskManager/5
        public User GetUser(int id)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            DA.User user = taskManagerBL.ReadUser(id);

            if (user != null)
                return new User()
                {
                    UserId = user.User_ID,
                    EmployeeId = user.Employee_ID,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    ProjectId = user.Project_ID,
                    TaskId = user.Task_ID
                };
            return null;
        }

        [HttpPost]
        [ActionName("AddUser")]
        // POST: api/TaskManager
        public void AddUser([FromBody]User user)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();

            taskManagerBL.AddUser(new DA.User()
            {
                Task_ID = user.TaskId,
                Project_ID = user.ProjectId,
                LastName = user.LastName,
                FirstName = user.FirstName,
                Employee_ID = user.EmployeeId
            });
        }

        [HttpPost]
        [ActionName("UpdateUser")]
        // PUT: api/TaskManager/5
        public void UpdateUser([FromBody]User user)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();

            taskManagerBL.UpdateUser(new DA.User()
            {
                User_ID = user.UserId,
                Task_ID = user.TaskId,
                Project_ID = user.ProjectId,
                LastName = user.LastName,
                FirstName = user.FirstName,
                Employee_ID = user.EmployeeId
            });
        }

        [HttpGet]
        [ActionName("DeleteUser")]
        // DELETE: api/TaskManager/5
        public void DeleteUser(int id)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            taskManagerBL.DeleteUser(id);
        }

        [HttpGet]
        [ActionName("GetAllProjects")]
        // GET: api/TaskManager
        public IEnumerable<Project> GetAllProjects()
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            List<Project> lstProject = new List<Project>();
            foreach (var project in taskManagerBL.ReadAllProjects())
            {
                lstProject.Add(new Project()
                {
                    Name = project.Project1,
                    ProjectId = project.Project_ID,
                    EndDate = project.End_Date.ToString("dd/MM/yyyy"),
                    StartDate = project.Start_Date.ToString("dd/MM/yyyy"),
                    Priority = project.Priority
                });
            }
            return lstProject;
        }

        [HttpGet]
        [ActionName("GetProject")]
        // GET: api/TaskManager/5
        public Project GetProject(int id)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            DA.Project project = taskManagerBL.ReadProject(id);

            if (project != null)
                return new Project()
                {
                    Name = project.Project1,
                    ProjectId = project.Project_ID,
                    EndDate = project.End_Date.ToString("dd/MM/yyyy"),
                    StartDate = project.Start_Date.ToString("dd/MM/yyyy"),
                    Priority = project.Priority
                };
            return null;
        }

        [HttpPost]
        [ActionName("AddProject")]
        // POST: api/TaskManager
        public void AddProject([FromBody]Project project)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();

            taskManagerBL.AddProject(new DA.Project()
            {
                Project1 = project.Name,
                Priority = project.Priority,
                End_Date = Convert.ToDateTime(project.EndDate),
                Start_Date = Convert.ToDateTime(project.StartDate)
            });
        }

        [HttpPost]
        [ActionName("UpdateProject")]
        // PUT: api/TaskManager/5
        public void UpdateProject([FromBody]Project project)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();

            taskManagerBL.UpdateProject(new DA.Project()
            {
                Project_ID = project.ProjectId,
                Project1 = project.Name,
                Priority = project.Priority,
                End_Date = Convert.ToDateTime(project.EndDate),
                Start_Date = Convert.ToDateTime(project.StartDate)
            });
        }

        [HttpGet]
        [ActionName("DeleteProject")]
        // DELETE: api/TaskManager/5
        public void DeleteProject(int id)
        {
            ProjectManagerBL taskManagerBL = new ProjectManagerBL();
            taskManagerBL.DeleteProject(id);
        }
    }
}
