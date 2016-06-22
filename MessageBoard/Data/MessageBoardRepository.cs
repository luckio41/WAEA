using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageBoard.Data
{
    public class MessageBoardRepository : IMessageBoardRepository
    {
        private readonly MessageBoardContext _ctx;

        public MessageBoardRepository(MessageBoardContext ctx)
        {
            _ctx = ctx;
        }

        public bool AddReplay(Reply reply)
        {
            try
            {
                _ctx.Replies.Add(reply);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddTopic(Topic topic)
        {
            try
            {
                _ctx.Topics.Add(topic);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<Reply> GetRepliesByTopic(int topicId)
        {
            var repliesByTopic = _ctx.Replies.Where(x => x.topicId.Equals(topicId));
            return repliesByTopic;
        }

        public IQueryable<Topic> GetTopic()
        {
            return _ctx.Topics;
        }

        public IQueryable<Topic> GetTopicIncludingReplies()
        {
            return _ctx.Topics.Include("Replies");
        }

        public bool Save()
        {
            try
            {
                return _ctx.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}