using System.Drawing;

namespace WhiteboardShared
{
    public class WhiteboardImage
    {
        public required string ClientId { get; set; }
        public required string Url { get; set; }
        public required Point Location { get; set; }
        public required Size Size { get; set; }
    }
} 