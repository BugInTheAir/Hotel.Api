using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models.DTO
{
    public class RoomDto
    {
        public string? Id { get; set; }
        public string? RoomNumber { get; set; }
        public IEnumerable<string> Images { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
    }
}
