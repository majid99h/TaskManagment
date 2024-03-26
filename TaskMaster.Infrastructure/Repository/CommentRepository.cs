using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Infrastructure.Repository
{
    public class CommentRepository(IDbConfiguration dbConfig) : ICommentRepository
    {
        private readonly IDbConfiguration _dbConfig = dbConfig;
        public async Task<int> AddCommentAsync(Comment comment)
        {
            try
            {
                using var connection = _dbConfig.CreateConnection();

                var query = @"INSERT INTO Comments (TaskID, UserID,CommentText,CommentDate)
                            output inserted.CommentID
                            VALUES (@TaskID,@UserID, @CommentText@CommentDate)";

                int insertedId = await connection.QuerySingleAsync<int>(query, comment);

                return insertedId;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Comment>> GetCommentsAsync(int taskId)
        {
            string query = @"select * from Comments where TaskID=@taskid";
            using var connection = _dbConfig.CreateConnection();

            return await connection.QueryAsync<Comment>(query);
        }
    }
}
