using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boilerplate.Models.Entities
{
    public class PublicationModel
    {
        
        public DateTime Create { get; set; }
        public DateTime? Update { get; set; }
        public String Title { get; set; }
        public String PreviewText { get; set; }

        public String Blocks { get; set; }
    }
}
