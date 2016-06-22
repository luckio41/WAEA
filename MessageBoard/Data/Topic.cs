using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageBoard.Data
{
    public class Topic
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public DateTime created { get; set; }
        public ICollection<Reply> replies { get; set; }
    }
}