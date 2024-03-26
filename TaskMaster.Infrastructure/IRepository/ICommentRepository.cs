using TaskMaster.Core.Entities;

namespace TaskMaster.Infrastructure.IRepository
{
    public interface ICommentRepository
    {
        Task<int> AddCommentAsync(Comment comment);
        Task<IEnumerable<Comment>> GetCommentsAsync(int taskId);
    }
}
