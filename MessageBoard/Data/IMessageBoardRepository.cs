using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoard.Data
{
    interface IMessageBoardRepository
    {
        IQueryable<Topic> GetTopic();
        IQueryable<Reply> GetRepliesByTopic(int topicId);
        IQueryable<Topic> GetTopicIncludingReplies();
        bool Save();
        bool AddTopic(Topic topic);
        bool AddReplay(Reply reply);
    }
}
