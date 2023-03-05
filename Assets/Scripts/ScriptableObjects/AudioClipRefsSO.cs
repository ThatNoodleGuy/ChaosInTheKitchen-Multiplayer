using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute()]
public class AudioClipRefsSO : ScriptableObject
{
    public AudioClip[] chop;
    public AudioClip[] deliveryFail;
    public AudioClip[] deliverySuccess;
    public AudioClip[] footstep;
    public AudioClip[] objectDrop;
    public AudioClip[] objectPickup;
    public AudioClip stovesizzle;
    public AudioClip[] trash;
    public AudioClip[] warning;
}