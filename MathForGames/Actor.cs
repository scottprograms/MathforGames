using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace MathForGames
{
    class Actor
    {
        protected char _icon = 'a';
        protected Vector2 _position;
        protected Vector2 _velocity;
        protected ConsoleColor _color;



        public Actor()
        {
            _position = new Vector2();
            _velocity = new Vector2();
        }

        public Actor(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.Red)
        {
            _icon = icon;
            _position = new Vector2(x, y);
            _color = color;
        }

        
        public void Start()
        {

        }

        public virtual void Update()
        {
            _position += _velocity;
            _position.X = Math.Clamp(_position.X, 0, Console.WindowWidth - 1);
            _velocity.Y = Math.Clamp(_velocity.Y, 0, Console.WindowHeight - 1);
        }

        public void Draw()
        {

        }

        public void End()
        {

        }

    }
}
