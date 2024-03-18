namespace MusicPlayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MusicPlayer
            MusicPlayerDelegate musicPlayer = new MusicPlayerDelegate();

            // Subscribe to events
            musicPlayer.SongAdded += DisplayMessage;
            musicPlayer.SongDeleted += DisplayMessage;

            // Add songs to the playlist
            musicPlayer.AddSong("Song 1");
            musicPlayer.AddSong("Song 2");
            musicPlayer.AddSong("Song 3");

            // Display and play the playlist
            musicPlayer.DisplayPlaylist();
            musicPlayer.PlayPlaylist();

            // Delete a song from the playlist
            musicPlayer.DeleteSong("Song 2");

            // Display and shuffle the playlist
            musicPlayer.DisplayPlaylist();
            musicPlayer.ShufflePlaylist();

            // Display and sort the playlist
            musicPlayer.DisplayPlaylist();
            musicPlayer.SortPlaylist();
        }

        // Event handler method to display messages
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }


}





   
