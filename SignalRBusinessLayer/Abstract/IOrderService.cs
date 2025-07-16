﻿using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Abstract
{
    public interface IOrderService:IGenericService<Order>
    {
        int TotalOrderCount();
        int ActiveOrderCount();
        int PasssiveOrderCount();
        int InProgressOrderCount();
        decimal LastOrderPrice();
        decimal TodayTotalPrice();
    }
}
