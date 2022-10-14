using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip introBgMusic, bgMusic;

    public AudioClip[] audioClips;
    private int _maxClips;
    private int _currentClips;

    public LayerMask masks;

    private void Start()
    {
        _maxClips = audioClips.Length;
        _currentClips = 0;


        source.clip = bgMusic;
        source.Play();
        
    }

    private void Update()
    {
        if (!source.isPlaying)
        {
            PlayMusicLooping(bgMusic);
        }

        if (!source.isPlaying)
        {
            _currentClips++;

            if(_currentClips == _maxClips)
            {
                _currentClips = 0;
            }

            source.clip = audioClips[_currentClips];
            source.Play();
        }
    }

    public void PlayMusic(AudioClip newClip)
    {
        source.clip = newClip;

        source.Play();
        source.loop = false;
    }

    public void PlayMusicLooping(AudioClip newClip)
    {
        source.clip = newClip;

        source.Play();
        source.loop = true;
    }
}
