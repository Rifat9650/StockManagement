﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementSystemWebApp.DAL.Model
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ReorderLevel { get; set; }
        public int AvailableQuantity { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }

       
    }
}