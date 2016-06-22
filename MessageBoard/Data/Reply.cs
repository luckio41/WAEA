using System;

namespace MessageBoard.Data
{
    public class Reply
    {
        public int id { get; set; }
        public string body { get; set; }
        public DateTime created { get; set; }
        public int topicId { get; set; }
    }
}