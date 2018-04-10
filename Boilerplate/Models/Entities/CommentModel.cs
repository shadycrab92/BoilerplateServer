using System;

namespace Boilerplate.Models.Entities
{
    public class CommentModel
    {
        public Int32 Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public String Text { get; set; }
        public String UserName { get; set; }
    }
}
