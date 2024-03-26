using TaskMaster.Application.Contract;
using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Application.Services
{
    public class CommentService(ICommentRepository commentRepository) : ICommentService
    {
        private readonly ICommentRepository _commentRepository = commentRepository;

        public Task<int> AddCommentAsync(Comment comment)
        {
            return _commentRepository.AddCommentAsync(comment);
        }

        public Task<IEnumerable<Comment>> GetCommentsAsync(int taskId)
        {
           return _commentRepository.GetCommentsAsync(taskId);
        }
    }
}
