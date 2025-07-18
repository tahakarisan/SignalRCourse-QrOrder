﻿using Microsoft.AspNetCore.SignalR;
using SignalRDataAccessLayer.Concrete;

namespace SignalRAPI.Hubs
{
    public class SignalRHub:Hub
    {
        SignalRContext context = new SignalRContext();

        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}
