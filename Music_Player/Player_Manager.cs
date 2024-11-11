using System;
using System.Collections.Generic;
using System.IO;
using Music_Player.Models;

namespace Music_Player
{
    class Player_Manager : IMusicPlayer
    {
        private List<string> _musicFiles;
        private int _nowPlayingIndex = 0;
        private string _filter = "";

        public Player_Manager()
        {
            Init();
        }

        public void Init()
        {
            _musicFiles = new List<string>();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string finalPath = Path.Combine(path, "DotNet");

            try
            {
                string[] files = Directory.GetFiles(finalPath);

                if (_filter != "")
                {

                    foreach (string item in files)
                    {
                        if (item.Contains(_filter))
                        {
                            _musicFiles.Add(item);
                        }
                    }
                }
                else
                {
                    _musicFiles.AddRange(files);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void Next()
        {
            _nowPlayingIndex = _nowPlayingIndex < _musicFiles.Count - 1 ? ++_nowPlayingIndex : 0;

            Console.WriteLine($"\nStarted playing {_musicFiles[_nowPlayingIndex]}");
        }

        public void Previous()
        {
            _nowPlayingIndex = _nowPlayingIndex > 0 ? --_nowPlayingIndex : _musicFiles.Count - 1;

            Console.WriteLine($"\nStarted playing {_musicFiles[_nowPlayingIndex]}");
        }

        public void Start()
        {
            Console.WriteLine($"\nStarted playing {_musicFiles[_nowPlayingIndex]}");
        }

        public void Stop()
        {
            Console.WriteLine($"\nStopped playing {_musicFiles[_nowPlayingIndex]}");
        }

        public void ApplyFilter()
        {
            Console.WriteLine("Enter the filter string : ");
            _filter = Console.ReadLine();
            Init();
        }

        public void ClearFilter()
        {
            _filter = "";
            Init();
        }
    }
}
