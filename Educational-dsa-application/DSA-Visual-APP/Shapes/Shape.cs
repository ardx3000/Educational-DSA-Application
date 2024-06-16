using System;
using Raylib_cs;

namespace DSA_Visual_APP.Shapes
{
    abstract class Shape
    {
        public abstract void Draw();
        public abstract void SetPosition(float x, float y);
    }
}
