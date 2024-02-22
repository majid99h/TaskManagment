namespace TaskMaster.Core.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } =string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string PasswordSalt { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
