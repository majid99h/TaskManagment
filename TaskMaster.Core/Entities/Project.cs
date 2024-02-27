namespace TaskMaster.Core.Entities
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsCompleted { get; set; }
        public int CreatedBy { get; set; }
        public int ModifedBy { get; set; }
        public int MarkCompleted { get; set; }

    }
}
