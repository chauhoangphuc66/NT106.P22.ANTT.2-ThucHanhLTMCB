using System.Drawing;

namespace WhiteboardShared
{
    public class DrawingPoint
    {
        public Point Location { get; set; }
        public Color Color { get; set; }
        public int PenWidth { get; set; }
        public bool IsEraser { get; set; }

        public DrawingPoint(Point location, Color color, int penWidth, bool isEraser = false)
        {
            Location = location;
            Color = color;
            PenWidth = penWidth;
            IsEraser = isEraser;
        }
    }
} 