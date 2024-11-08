using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace M223PunchclockDotnet.Model
{
    public class Chat
    {
        public int ChatId { get; set; }   
        public string DisplayName { get; set; } = string.Empty;
        public string DisplayDesc { get; set; } = string.Empty;
    }
}