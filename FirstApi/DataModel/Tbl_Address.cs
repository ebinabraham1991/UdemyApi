﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.DataModel
{
    public class Tbl_Address
    {
        public Guid Id { get; set; }

        public string PostalAddress { get; set; }

        public string PhysicalAddress { get; set; }

        public Guid StudentId { get; set; }


    }
}