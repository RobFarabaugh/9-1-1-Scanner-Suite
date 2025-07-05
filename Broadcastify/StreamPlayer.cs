using System;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.MediaFoundation;

namespace ScannerSuite.Broadcastify;

public class StreamPlayer
{
    private WaveOutEvent _outputDevice;
    private MediaFoundationReader _mediaReader;
    private bool _isPlaying = false;

    public StreamPlayer()
    {
        MediaFoundationApi.Startup();
    }

    public async Task PlayStreamAsync(string streamUrl)
    {
        try
        {
            Console.WriteLine($"Connecting to stream: {streamUrl}");
            
            _mediaReader = new MediaFoundationReader(streamUrl);
            
            _outputDevice = new WaveOutEvent();
            _outputDevice.Init(_mediaReader);
            
            _outputDevice.Play();
            _isPlaying = true;
                
            Console.WriteLine("Stream started. Press any key to stop...");
            
            await Task.Run(() => Console.ReadKey());
                
            Stop();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing stream: {ex.Message}");
        }
    }

    public void Stop()
    {
        if (_isPlaying)
        {
            Console.WriteLine("Stopping stream...");
                
            _outputDevice?.Stop();
            _outputDevice?.Dispose();
            _mediaReader?.Dispose();
                
            _isPlaying = false;
            Console.WriteLine("Stream stopped.");
        }
    }

    public void Dispose()
    {
        Stop();
        MediaFoundationApi.Shutdown();
    }
}