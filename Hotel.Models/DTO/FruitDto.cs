using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsShop.Models.DTO
{
    public class FruitDto
    {
        public string? Id { get; set; }
        public string? FruitName { get; set; }
        public IEnumerable<string> Images { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
    }
}
