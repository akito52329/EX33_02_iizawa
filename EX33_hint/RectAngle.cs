using System;
using System.Collections.Generic;
using System.Text;

namespace EX33_hint
{
    class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width + height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }
        
        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width);
        }

        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            var syntheticWidth = 0f;
            var syntheticHeight = 0f;

            syntheticWidth = Math.Max(Math.Max(rectAngle1.width, rectAngle1.height), Math.Max(rectAngle2.width, rectAngle2.height));
            syntheticHeight = Math.Min(rectAngle1.width, rectAngle1.height) + Math.Min(rectAngle2.width, rectAngle2.height);

            return new RectAngle(syntheticHeight,syntheticWidth);
        }
    }
}
