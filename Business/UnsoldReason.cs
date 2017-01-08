using System;

namespace SelectListExample.Business
{
    public class UnsoldReason
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
