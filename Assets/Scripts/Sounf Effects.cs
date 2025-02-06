using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SounfEffects : MonoBehaviour
{
    AudioSource audio;
    SpriteRenderer sr;
    public AudioClip[] audioClips;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (sr.bounds.Contains(mousepos))
        {
            //audio.Play();
            //audio.Stop();
            //audio.loop = true;

            //audio.PlayOneShot();

            int randomNumber = Random.Range(0, audioClips.Length);
            //PlayOneShot Can make multiple clips on top of one another
            //good for only 1 use, oneshot can be used for things like multiple voices if put into the array list
            if (!audio.isPlaying)
            {
                //audio.pitch =;
                audio.Play();
                audio.PlayOneShot(audioClips[randomNumber]);
            }
        }
    }
}
