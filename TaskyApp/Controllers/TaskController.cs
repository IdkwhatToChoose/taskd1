using Microsoft.AspNetCore.Mvc;
using TaskyApp.Model;

namespace TaskyApp.Controllers
{
    public class TaskController : Controller
    {
        private Taskd1Context db=new Taskd1Context();
        public IActionResult NewTask()
        {
            return View("/Views/Tasks/NewTask.cshtml");
        }
        [HttpPost]
        public IActionResult NewTask(TaskProp taskProp)
        {
            TaskProp taskProp2 = new TaskProp();
            taskProp2.Task=taskProp.Task;
            taskProp2.TaskDescription=taskProp.TaskDescription;
            taskProp2.Completed=taskProp.Completed;
            taskProp2.DateOfCreation=DateTime.Now.ToString("dd.MM.yyyy");
            taskProp2.HourOfCreation = DateTime.Now.ToString("HH:mm");
            db.TaskProps.Add(taskProp2);
            db.SaveChanges();
            return RedirectToAction("Index", "Home", new {isLoginI=true});
        }
    }
}
