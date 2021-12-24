using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuickHealthy.DAL.Entities
{
    public class Office
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public Doctor Doctor { get; set; }
    }
}
