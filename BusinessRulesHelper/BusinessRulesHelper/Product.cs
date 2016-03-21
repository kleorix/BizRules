using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesHelper.BusinessRules.Interfaces;

namespace BusinessRulesHelper {
    public class Product {
        public int ProductId { get; set; }
        public string Type { get; set; }
        public string ProductName { get; set; }
        public Catalogue ProductCatalogue { get; set; }
        public double Price { get; set; }

    }
}
