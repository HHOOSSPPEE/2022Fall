using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManagerDemo : MonoBehaviour
{
    public AudioClip musicA, musicB;

    public AudioClip[] audioClips;
    private int _maxClips;
    private int _currentClips;

    public bool playB;
    public bool isPlayingB;

    public AudioSource source;
    private GameManager gm;

    [Range(0, 1)]
    public float musicVolume = 1f;
    public Slider volumeSlider;
    
    // Start is called before the first frame update
    void Start()
    {
        _currentClips = 0;
        source.clip = audioClips[_currentClips];
        _maxClips = audioClips.Length;

        source.clip = musicA;

        source.Play();
        gm = GameObject.FindGameObjectWithTag("Controller").GetComponent<GameManager>();
        isPlayingB = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        //source.volume = volumeSlider.value;
        //source.volume = gm.musicVolume;

        if(playB == true && isPlayingB == false)
        {
            isPlayingB = true;
            source.clip = musicB;
            source.Play();
        }

        if (!source.isPlaying)
        {
            _currentClips++;

            if (_currentClips == _maxClips)
            {
                _currentClips = 0;
            }

            source.clip = audioClips[_currentClips];
            source.Play();
        }


    }
}
