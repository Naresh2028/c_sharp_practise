using C_Sharp_Concepts.Solid;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Concepts.Shared.Model
{
    public class Property
    {
        public int Id { get; set; }
        [ConcurrencyCheck]
        public required string PropertyName { get; set; }
        public required string Location { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string FileName { get; set; } = string.Empty;
        // Active / Inactive
        public bool Status { get; set; } = true;

        // Soft deletion
        public bool IsDeleted { get; set; } = false;
        public required DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        // Navigation Property
        public User User { get; set; } = null!;
        public Guid UserId { get; set; }

    }
}
