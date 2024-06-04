using Raylib_cs;

namespace DSA_Visual_APP.Shapes
{
    class Square : Shape
    {
        private Rectangle _rectangle;
        private int _number {  get; set; }

        public Square(float x, float y, float size, int number)
        {
            _rectangle = new Rectangle(x, y, size, size);
            _number = number;
        }

        public override void SetPosition(float x, float y)
        {
            _rectangle.X = x;
            _rectangle.Y = y;
            
        }
        public override void Draw()
        {
            Raylib.DrawRectangleRec(_rectangle, Color.DarkBlue);
            //Todo 
        }
    }
}
