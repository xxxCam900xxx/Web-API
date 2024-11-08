using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using M223PunchclockDotnet.Model;
using Microsoft.EntityFrameworkCore;

namespace M223PunchclockDotnet.Service
{
    public class ChatService
    {
        private DatabaseContext _databaseContext;

        public ChatService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Task<List<Chat>> AllChats() {
            return _databaseContext.Chats.ToListAsync();
        }

        public async Task<Chat> AddChat(Chat chat) {

            _databaseContext.Chats.Add(chat);
            await _databaseContext.SaveChangesAsync();
            return chat;
        }
    }
}