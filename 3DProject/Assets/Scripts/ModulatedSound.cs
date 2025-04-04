using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]

struct Range
{
    public float min, max;


    Range( float mi, float ma)
    {
        min = mi;
        max = ma;
    }
}


[System.Serializable]
struct Modulation
{
    public Range pitch;
    public Range volume;

    Modulation(Range p, Range v)
    {
        pitch = p;
        volume = v;
    }
}


[RequireComponent(typeof(AudioSource))]

public class ModulatedSound : MonoBehaviour
{
    private AudioSource audioSource => this.GetComponent<AudioSource>();

    [SerializeField]
   private Modulation modulation = new Modulation();

    [SerializeField]
    private AudioClip clip;
    [SerializeField]
    private bool playOnAsStart = false;


    void Start()
    {
        

    }

   public void Play()
    {
        audioSource.pitch = Random.Range(modulation.pitch.min, modulation.pitch.max);
        audioSource.volume = Random.Range(modulation.volume.min, modulation.volume.max);
        audioSource.Play();

    }
   
    public void PlayClip(AudioClip _clip)
    {
        audioSource.clip = _clip;
        Play();
    }


}
