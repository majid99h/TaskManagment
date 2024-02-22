namespace TaskMaster.Core.Entities
{
    public class Task
    {
        
        public int TaskID { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? DueDate { get; set; }  
        public string Priority { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int ProjectID { get; set; }
        public int AssignedUserID { get; set; }
        
    }
}
