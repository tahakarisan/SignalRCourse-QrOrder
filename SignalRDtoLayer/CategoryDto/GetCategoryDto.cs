﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.CategoryDto
{
    public class GetCategoryDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}