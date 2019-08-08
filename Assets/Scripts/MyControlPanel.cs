using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RenderHeads.Media.AVProVideo;
using UnityEngine.UI;

public class MyControlPanel : MonoBehaviour
{
    public MediaPlayer _mediaPlayer;
    public MediaPlayer _mediaPlayerB;
    public ApplyToMesh _mediaDisplay;

    public Toggle _AutoStartToggle;
    public MediaPlayer.FileLocation _location = MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder;
    public string _folder = "AVProVideoSamples";
    
    public string[] _videoFiles = { "02_Giga_River.mp4", "2_Giga_Phuket_beach.mp4" };
    private int _VideoIndex = 0;

    //Initialize
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayingPlayer.Control.IsFinished())
        {
            Debug.Log("Pause: " + PlayingPlayer);
        }
    }

    // Play behavior
    public void OnPlayButton()
    {
        if (_loadingPlayer == null)
        {

        }

        PlayingPlayer.Control.Play();
    }

    // Pause behavior
    public void OnPauseButton()
    {
        Debug.Log("Pause: " + PlayingPlayer);
        Debug.Log("_loadingPlayer: " + _loadingPlayer);
        PlayingPlayer.Control.Pause();
     }

    private MediaPlayer _loadingPlayer;

    public MediaPlayer PlayingPlayer
    {
        get
        {
            if (LoadingPlayer == _mediaPlayer)
            {
                return _mediaPlayerB;
            }          
            return _mediaPlayer;
        }
    }

    public MediaPlayer LoadingPlayer
    {
        get
        {
            return _loadingPlayer;
        }
    }

    private void SwapPlayers()
    {
        // Swap the videos
        if (LoadingPlayer == _mediaPlayer)
        {
            _mediaPlayer.Control.CloseVideo();
            _loadingPlayer = _mediaPlayerB;
        }
        else
        {
            _mediaPlayerB.Control.CloseVideo();
            _loadingPlayer = _mediaPlayer;
        }

        // Change the displaying video
        _mediaDisplay.Player = _loadingPlayer;
        _loadingPlayer.Control.Play();
    }

    // Next Tour behavior
        public void OnNextTourButton()
    {
        // Swap the videos
        if (LoadingPlayer == _mediaPlayer)
        {
            _loadingPlayer = _mediaPlayerB;
            SwapPlayers();
        }
        else
        {
            _loadingPlayer = _mediaPlayer;
            SwapPlayers();
        }
    }

    // Restart behavior
    public void OnRestartButton()
    {
        _mediaPlayer.Control.Seek(0);
        _mediaPlayer.Control.Play();
    }

    public void OnOpenVideoFile()
    {
        Debug.Log("Path: " + System.IO.Path.Combine(_folder, _videoFiles[_VideoIndex]));
        LoadingPlayer.m_VideoPath = System.IO.Path.Combine(_folder, _videoFiles[_VideoIndex]);
        _VideoIndex = (_VideoIndex + 1) % (_videoFiles.Length);
        if (string.IsNullOrEmpty(LoadingPlayer.m_VideoPath))
        {
            LoadingPlayer.CloseVideo();
            _VideoIndex = 0;
        }
        else
        {
            LoadingPlayer.OpenVideoFromFile(_location, LoadingPlayer.m_VideoPath, _AutoStartToggle.isOn);
            //				SetButtonEnabled( "PlayButton", !_mediaPlayer.m_AutoStart );
            //				SetButtonEnabled( "PauseButton", _mediaPlayer.m_AutoStart );
        }
    }
}
