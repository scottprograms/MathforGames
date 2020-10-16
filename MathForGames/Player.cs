﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Player : Actor
    {
        public Player(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.Red)
            : base(x, y, icon, color)
        {

        }

        public override void Update()
        {

            ConsoleKey keypressed = Game.GetNextKey();

            switch (keypressed)
            {
                case ConsoleKey.A:
                    _velocity.X = -1;
                    break;
                case ConsoleKey.D:
                    _velocity.X = 1;
                    break;
                case ConsoleKey.W:
                    _velocity.Y = -1;
                    break;
                case ConsoleKey.S:
                    _velocity.Y = 1;
                    break;
                default:
                    _velocity.X = 0;
                    _velocity.Y = 0;
                    break;
            }
            base.Update();


        }
    }
}
