namespace TaskMaster.Core.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int TaskID { get; set; }
        public int UserID { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; } = DateTime.Now;
    }
}
