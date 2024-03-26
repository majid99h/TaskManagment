using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Infrastructure.Repository
{
    public class AttachmentRepository(IDbConfiguration dbConfig) : IAttachmentRepository
    {
        private readonly IDbConfiguration _dbConfig = dbConfig;
        public async Task<IEnumerable<Attachment>> GetAttachment(int taskId)
        {
            string query = @"select * from Attachment where TaskID=@taskid";
            using var connection = _dbConfig.CreateConnection();

            return await connection.QueryAsync<Attachment>(query);
        }

        public async Task<int> UploadAttachment(Attachment attachment)
        {
            try
            {
                using var connection = _dbConfig.CreateConnection();

                var query = @"INSERT INTO [dbo].[Attachments]
                           (TaskID,
                            UserID,
                            [FileName],
                            FilePath,
                            UploadDate)
	                     OUTPUT INSERTED.AttachmentID
                             VALUES (
                                   @TaskID, 
                                   @UserID, 
                                   @FileName, 
                                   @FilePath, 
                                   @UploadDate)";

                int insertedId = await connection.QuerySingleAsync<int>(query, attachment);

                return insertedId;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
