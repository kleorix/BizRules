using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesHelper {
    class Program {
        static void Main(string[] args) {
            // Target
            // Add models
            

            // Getting data from users
            var cat = new Catalogue {CatId = 1,CatName = "Cat1"};
            var product = new Product {ProductId = 1,Type = "Type1", ProductName = "Name1", Price = 3, ProductCatalogue = cat};
            // Validating data
            // Saving data
        }
    }
}
