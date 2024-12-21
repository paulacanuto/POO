﻿/// <summary>
/// This class is a logoff menu.
/// </summary>
using POOProjectMusicAndPodcast.Models;

namespace POOProjectMusicAndPodcast.Menus;

    internal class MenuLogOff : Menu
    {
        public override void Execute(Dictionary<string, Artist> artistRegistered)
        {
            Console.WriteLine("Bye bye... :)");
        }
    }