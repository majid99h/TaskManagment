using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Core.Entities;

namespace TaskMaster.Application.Contract
{
    public interface ICommentService
    {
        Task<int> AddCommentAsync(Comment comment);
        Task<IEnumerable<Comment>> GetCommentsAsync(int taskId);
    }
}
