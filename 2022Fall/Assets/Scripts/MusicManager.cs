using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip bgMusic, introbgMusic;

    public AudioClip[] audioClips;
    private int _maxClips;
    private int _currentClips;
    
    // Start is called before the first frame update
    void Start()
    {
        //_currentClips = 0;
        //_maxClips = audioClips.Length;


        source.clip = introbgMusic;
        source.Play();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            PlayMusicLooping(bgMusic);
        }
            /*
            if (!source.isPlaying)
            {
                _currentClips++;

                if(_currentClips == _maxClips)
                {
                    _currentClips = 0;
                }

                source.clip = audioClips[_currentClips];
                source.Play();
            }*/
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
