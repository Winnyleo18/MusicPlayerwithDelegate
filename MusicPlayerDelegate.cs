using System;
using System.Collections.Generic;
using System.Linq;

// Define a delegate for playlist events
public delegate void PlaylistEventHandler(string message);

public class MusicPlayerDelegate
{
    private List<string> playlist = new List<string>();

    // Define events based on the delegate
    public event PlaylistEventHandler SongAdded;
    public event PlaylistEventHandler SongDeleted;

    // Add a song to the playlist
    public void AddSong(string song)
    {
        playlist.Add(song);
        OnSongAdded(song);
    }

    // Delete a song from the playlist
    public void DeleteSong(string song)
    {
        if (playlist.Remove(song))
        {
            OnSongDeleted(song);
        }
    }

    // Play all songs in the playlist
    public void PlayPlaylist()
    {
        Console.WriteLine("\nPlaying Playlist:");
        foreach (string song in playlist)
        {
            Console.WriteLine($"Now playing: {song}");
        }
    }

    // Shuffle the songs in the playlist
    public void ShufflePlaylist()
    {
        Random random = new Random();
        playlist = playlist.OrderBy(x => random.Next()).ToList();
        Console.WriteLine("Playlist shuffled.");
    }

    // Sort the songs in the playlist
    public void SortPlaylist()
    {
        playlist.Sort();
        Console.WriteLine("Playlist sorted.");
    }

    // Display all songs in the playlist
    public void DisplayPlaylist()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("Playlist is empty.");
        }
        else
        {
            Console.WriteLine("\nCurrent Playlist:");
            for (int i = 0; i < playlist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playlist[i]}");
            }
        }
    }

    // Raise the SongAdded event
    protected virtual void OnSongAdded(string song)
    {
        SongAdded?.Invoke($"Song '{song}' added to the playlist.");
    }

    // Raise the SongDeleted event
    protected virtual void OnSongDeleted(string song)
    {
        SongDeleted?.Invoke($"Song '{song}' deleted from the playlist.");
    }
}

