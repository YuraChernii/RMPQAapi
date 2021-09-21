using RMPQAapi.Data.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMPQAapi.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Number { get; set; } = string.Empty;

        public int OwnerId { get; set; }

        public string? Image { get; set; }
    }
}
