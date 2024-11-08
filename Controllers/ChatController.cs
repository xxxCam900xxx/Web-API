using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using M223PunchclockDotnet.Service;
using M223PunchclockDotnet.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace M223PunchclockDotnet.Controllers
{
    [ApiController]
    [Route("chat")]
    public class ChatController : ControllerBase
    {
        private readonly ChatService _chatService;

        public ChatController(ChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet]
        [ProducesResponseType<Chat>(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var allChatEntries = await _chatService.AllChats();
            return Ok(allChatEntries);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType<Chat>(StatusCodes.Status201Created)]
        public async Task<ActionResult<Chat>> AddChat(Chat chat) {
            var newChat = await _chatService.AddChat(chat);
            return Ok(newChat);
        }
    }
}