namespace TaskMaster.Core.Entities
{
    public class Attachment
    {
       
        public int AttachmentID { get; set; }
        public int TaskID { get; set; }
        public int UserID { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public DateTime UploadDate { get; set; } = DateTime.Now;
    }
}
