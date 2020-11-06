using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MathLibrary;
using Raylib_cs;

namespace MathForGames
{
    class Game
    {
        private static bool _gameOver = false;
        private static Scene[] _scenes;
        private static int _currentSceneIndex;
        public static int CurrentSceneIndex
        {
            get
            {
                return _currentSceneIndex;
            }
        }

    }

    public static ConsoleColor DefaultColor { get; set; } = ConsoleColor.White;
    /// <summary>
    /// Used to set the value of game over.
    /// </summary>
    /// <param name="value">If this value is true, the game will end</param>
    public static void SetGameOver(bool value)
    {
        _gameOver = value;
    }


    /// <summary>
    /// Adds the given scene to the array of scenes.
    /// </summary>
    /// <param name="scene">The scene that will be added to the array</param>
    /// <returns>The index the scene was placed at. Returns -1 if
    /// the scene is null</returns>


    public static Scene GetScene(int index)
    {
        if (index < 0 || index >= _scenes.Length)
            return new Scene();

        return _scenes[index];
    }
    
    /// // <summary>
    /// Returns the scene that is at the index of the 
    /// current scene index
    /// </summary>
    /// <returns></returns>

    public static int GetCurrentScene()
    {
        return _scenes[_currentSceneIndex];
    }

    /// <summary>
    /// Adds the given scene to the array of scenes.
    /// </summary>
    /// <param name="scene">The scene that will be added to the array</param>
    /// <returns>The index the scene was placed at. Returns -1 if
    /// the scene is null</returns>
    
    public static int AddScene(Scene scene)
    {
        //If the scene is null then return before running any other logic
        if (scene == null)
            return -1;
        //Create a new temporary array that one size larger than the original
        Scene[] tempArray = new Scene[_scenes.Length + 1];

        //Copy values from old array into new array
        for (int i = 0; i < _scenes.Length; i++)
        {
            tempArray[i] = _scenes[i];
        }
        //Store the current index
        int index = _scenes.Length;

        //Sets the scene at the new index to be the scene passed in
        tempArray[index] = scene;

        //Set the old array to the tmeporary array
        _scenes = tempArray;

        return index;
    }

    /// <summary>
    /// Finds the instance of the scene given that inside of the array
    /// and removes it
    /// </summary>
    /// <param name="scene">The scene that will be removed</param>
    /// <returns>If the scene was successfully removed</returns>
}

}

