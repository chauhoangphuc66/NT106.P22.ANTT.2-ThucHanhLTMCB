using System.Collections.Generic;
using System.Drawing;

namespace WhiteboardShared
{
    public class DrawingAction
    {
        public List<DrawingPoint> Points { get; set; }
        public required string ClientId { get; set; }
        public required Point StartPoint { get; set; }
        public required Point EndPoint { get; set; }

        public DrawingAction()
        {
            Points = new List<DrawingPoint>();
        }
    }
} 