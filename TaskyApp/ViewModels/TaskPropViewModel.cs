namespace TaskyApp.ViewModels
{
    public class TaskPropViewModel
    {
        public string Task { get; set; } = null!;

        public string? TaskDescription { get; set; }

        public string Completed { get; set; } = null!;

        public int Id { get; set; }
    }
}
