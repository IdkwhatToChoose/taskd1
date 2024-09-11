using TaskyApp.Helps;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskyApp.Model;
using TaskyApp.ViewModels;

namespace TaskyApp.Helps
{
    public class TaskMappep:ITaskMapper
    {
        public TaskPropViewModel TaskToTaskVM(TaskProp estate)
        {
            TaskPropViewModel viewModel = new TaskPropViewModel()
            {
                Id = estate.Id,
                Task = estate.Task,
                TaskDescription = estate.TaskDescription
               
            };
            return viewModel;
        }

        public List<TaskPropViewModel> ListClientToListEstateVm(List<TaskProp> estates)
        {
            List<TaskPropViewModel> estateViewModels = new List<TaskPropViewModel>();
            foreach (var estate in estates)
            {
                TaskPropViewModel evm = TaskToTaskVM(estate);
                estateViewModels.Add(evm);
            }
            return estateViewModels;
        }

       
    }
}
