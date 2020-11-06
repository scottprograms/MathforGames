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
        private float _collisionRadius;
        protected Matrix3 _localTransform;
        protected Mat

        public Vector2 Forward
        {
            get { return _facing; }
            set { _facing = value; }
        }

        public Actor()
        {
            _position = new Vector2();
            _velocity = new Vector2();
        }
        public bool CheckCollision(Actor other)
        {
            return false;
        }
        public void OnCollision(Actor other)
        {

        }
        public Vector2 Forward
        {
            get
            {
                return new Vector2(_localTransform.m11, _localTransform.m21);
            }
        }

        public Vector2 WorldPosition
        {
            get
            {
                return new Vector2(_globalTransform.m13, _globalTransform.m23);
            }

        }
        public Actor(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.Red)
        {
            _icon = icon;
            _position = new Vector2(x, y);
            _velocity = new Vector2();
            _color = color;
        }
        public Vector2 Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
        public Vector2 Velocity
        {
            get
            {
                return _velocity;
            }
            set
            {
                _velocity = value;
            }
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
            Console.ForegroundColor = _color;
            Console.SetCursorPosition((int)_position.X, (int)_position.Y);
            Console.Write(_icon);
            Console.ForegroundColor = Game.DefaultColor;
        }

        public void End()
        {

        }

    }
}
