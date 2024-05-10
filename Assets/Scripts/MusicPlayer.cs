using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    public static MusicPlayer instance;

    private AudioSource musicSource;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        musicSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (musicSource.isPlaying) return;
        musicSource.Play();
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void RemoveThis()
    {
        Destroy(gameObject);
    }
}
