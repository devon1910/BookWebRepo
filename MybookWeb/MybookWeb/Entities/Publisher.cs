using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MybookWeb.Entities
{
    public class Publisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PublishedBy { get; set; }
        private DateTime? dateCreated = null;
        public DateTime DatePublished   
        {
            get
            {
                return dateCreated.HasValue
                   ? dateCreated.Value
                   : DateTime.Now;
            }

            set { dateCreated = value; }

        }
    }
}
