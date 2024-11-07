using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;


namespace api.Services
{
    public class ChatService
    {
         private DatabaseContext _databaseContext; 

        public ChatService(DatabaseContext databaseContext){
            _databaseContext = databaseContext;
        }
        public Task<List<Chat>> FindAll()
        {
            return _databaseContext.Chats.ToListAsync();
        }

    }
}