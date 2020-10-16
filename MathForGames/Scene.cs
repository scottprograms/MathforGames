using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Scene
    {
        private Actor[] _actors;

        public Scene()
        {
            _actors = new Actor[0];
        }

        public void AddActor(Actor actor)
        {
            //Creating a new array with a size one greater than the old array/
            Actor[] appendedArray = new Actor[_actors.Length + 1];
            //Copy value from the old array to the new array.
            for (int i = 0; i < _actors.Length; i++)
            {
                 appendedArray[i] = _actors[i];
            }
            //Set the last value in the new array to be the actor we want to add.
            appendedArray[_actors.Length] = actor;
            //Set old array to hold the values of the new array
            _actors = appendedArray;
        }

        public bool RemoveActor(int index)
        {
            if (index< 0 || index >= _actors.Length)
            {
                return false;
            }
            bool actorRemoved = false;
            // //Creating a new array with a size one less than the old array
            Actor[] tempArray = new Actor[_.actors.Length - 1];
            int j = 0;
            for (int i = 0; i < _actors.Length; i++)
            {
                if (i != index)
                {
                    tempArray[j] = _actors[i];
                    j++;
                }
                else
                {
                    actorRemoved = true;
                }
            }
            _actors = tempArray;
            return false;
        }
        public bool RemoveActor(Actor actor)
        {
            //Check to see if actor pass as null
            if (actor == null)
            {
                return false;
            }
            bool actorRemoved = false;

            Actor[] newArray = new Actor[_actors.Length - 1];
            int j = 0;
            for (int i = 0; i < _actors.Length; i++)
            {
                 if (actor == _actors[i])
                {
                    newArray[j] = _actors[i];
                    j++;
                }
                else
                {
                    actorRemoved = true;
                }
            }//Set the old array to the new array
            _actors = newArray;
            //Return whether or not the removal was succesful
            return actorRemoved;
              
        }
        public virtual void Start()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].Start();
            }
        }

        public void Update()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].Update();
            }
        }

        public void Draw()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].Draw();
            }
        }

        public void End()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].End();
            }
        }
    }
}
