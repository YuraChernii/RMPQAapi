using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMPQAapi.Domain.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Number { get; set; } = string.Empty;

        public int OwnerId { get; set; }

        public string? Image { get; set; }
    }
}
