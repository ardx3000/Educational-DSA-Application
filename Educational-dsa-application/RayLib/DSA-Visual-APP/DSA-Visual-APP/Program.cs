using Raylib_cs;

namespace DSA_Visual_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init 
            const int screenWidth = 800;
            const int screenHeight = 450;

            Raylib.InitWindow(screenWidth, screenHeight, "DSA Educational app ");
            Raylib.SetTargetFPS(60);


            //Main Loop
            while (!Raylib.WindowShouldClose())
            {
                //Update

                //Draw

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                Raylib.DrawText("Example Window", 350 , 225, 20, Color.Black);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
