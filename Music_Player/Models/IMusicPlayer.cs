namespace Music_Player.Models
{
    internal interface IMusicPlayer
    {
        void Start();
        void Stop();
        void Next();
        void Previous();
    }
}
