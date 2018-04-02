using System;

namespace Boilerplate.Models.Entities
{
    public class PublicationModel
    {
        public Int32 Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public String Title { get; set; }
        public String PreviewText { get; set; }
        public String PreviewImage { get; set; }
        public String PreviewImageText { get; set; }
        public Boolean IsLocked { get; set; }

        public String Blocks { get; set; }
    }
}
