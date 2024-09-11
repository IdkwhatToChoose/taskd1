using TaskyApp.Model;
using TaskyApp.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace TaskyApp.Helps
{
    public interface ITaskMapper
    {
        public TaskPropViewModel TaskToTaskVM(TaskProp estate);
        public List<TaskPropViewModel> ListClientToListEstateVm(List<TaskProp> estates);
    }
}
