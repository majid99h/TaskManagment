using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Core.Entities;

namespace TaskMaster.Infrastructure.IRepository
{
    public interface IAttachmentRepository
    {
        Task<int> UploadAttachment(Attachment attachment);
        Task<IEnumerable<Attachment>> GetAttachment(int taskId);
    }
}
