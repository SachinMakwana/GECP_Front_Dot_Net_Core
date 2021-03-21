using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Models
{
    public class MessageModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string PageId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
