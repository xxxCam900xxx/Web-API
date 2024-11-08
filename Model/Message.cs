using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotation;

namespace M223PunchclockDotnet.Model
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Message { get; set; }
    }
}