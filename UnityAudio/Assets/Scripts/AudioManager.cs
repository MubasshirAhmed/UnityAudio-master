using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] audioClip;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnBtnClick(int audioNumber)
    {
        audioSource.clip = audioClip[audioNumber];
        audioSource.Play();
    }
}
