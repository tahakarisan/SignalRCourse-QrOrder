﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDtoLayer.ContactDto
{
    public class ResultContactDto
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string FooterTitle { get; set; }
        public string FooterDescription { get; set; }
    }
}
