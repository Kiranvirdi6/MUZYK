using System;

namespace Muzyk_API.DTOS
{
    public class MessageToReturnDto
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderKnownAs { get; set; }
        public string SenderPhotoUrl { get; set; }
        public int RecepientId { get; set; }
        public string RecepientKnownAs { get; set; }
        public string RecepientPhotoUrl { get; set; }
        public string Content { get; set; }
        public bool isRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; }
    }
}