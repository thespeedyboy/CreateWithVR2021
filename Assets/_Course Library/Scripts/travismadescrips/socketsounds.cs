using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socketsounds : MonoBehaviour
{
  private AudioSource audiosource;
  [Header("Audio clips")]
  public AudioClip entersound;
  public AudioClip exitsound;
  void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
  public void PlayEnterSound()
    {
        audiosource.PlayOneShot(entersound);
    }
  public void PlayExitSound()
    {
        audiosource.PlayOneShot(exitsound);
    }
}
