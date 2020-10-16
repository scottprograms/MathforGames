using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MathForGames
{
    class Game
    {
        private static bool _gameOver = false;
        private Scene _scene;

        //Static function used to set game over without an instance of game.
        public static void SetGameOver(bool value)
        {
            _gameOver = value;
        }

        public static  ConsoleKey GetNextKey()
        {
            if (!Console.KeyAvailable)
            {
                return 0;
            }
            return Console.ReadKey(true).Key;
        }


        //Called when the game begins. Use this for initialization.
        public void Start()
        {
            Console.CursorVisible = false;
            _scene = new Scene();
            Actor actor = new Actor(0, 0 '@', ConsoleColor.White);
            actor._velocity.X = 1;
            Player player = new Player(0, 1, '$' ConsoleColor.Blue);
            _scene.AddActor(player);
            _scene.AddActor(actor);
        }


        //Called every frame.
        public void Update()
        {
            ConsoleKey keyPressed = Game.GetNextKey();
                
                switch (keyPressed)
                {
                    case ConsoleKey.A:
                        _x--;
                        break;
                    case ConsoleKey.D:
                        _x++;
                        break;
                    case ConsoleKey.W:
                        _x++;
                        break;
                }
        }

        //Used to display objects and other info on the screen.
        public void Draw()
        {
            Console.SetCursorPosition
        }


        //Called when the game ends.
        public void End()
        {

        }


        //Handles all of the main game logic including the main game loop.
        public void Run()
        {
            Start();

            while(!_gameOver)
            {
                Update();
                Draw();
            }

            End();
        }
    }
}
