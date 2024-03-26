using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Application.Contract;
using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Application.Services
{
    public class AttachmentService(IAttachmentRepository attachmentRepository) : IAttachmentService
    {
        private readonly IAttachmentRepository _attachmentRepository = attachmentRepository;

        public Task<IEnumerable<Attachment>> GetAttachment(int taskId)
        {
            return _attachmentRepository.GetAttachment(taskId);
        }

        public Task<int> UploadAttachment(Attachment attachment)
        {
            return _attachmentRepository.UploadAttachment(attachment);
        }
    }
}
