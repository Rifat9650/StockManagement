﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementSystemWebApp.DAL.Model
{
    [Serializable]
    public class SearchView
    {
        public string ItemName { get; set; }
        public string CompanyName { get; set; }
 
        public string AvailableQuantity { get; set; }
        public string ReorderLevel { get; set; }
    }
}