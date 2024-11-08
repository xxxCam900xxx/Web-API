using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using M223PunchclockDotnet.Model;

namespace M223PunchclockDotnet.Model
{
    public class Chat
    {
        public int ChatId { get; set; }   
        public string DisplayName { get; set; } = string.Empty;
        public string DisplayDesc { get; set; } = string.Empty;
        public ICollection<Message> messages { get; set; } = new List<Message>();
    }
}