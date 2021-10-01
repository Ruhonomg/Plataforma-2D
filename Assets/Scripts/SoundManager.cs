using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip bombFX;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    public void PlayBombFX()
    {
        audioSource.PlayOneShot(bombFX, 1f);
    }
}
