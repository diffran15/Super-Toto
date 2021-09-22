using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCoin : MonoBehaviour
{
	public AudioClip SoundToPlay;
	public float volume;
	AudioSource audios;

    // Start is called before the first frame update
    void Start()
    {
		audios = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag=="Coin")
		{
			audios.PlayOneShot(SoundToPlay, volume);
		}
	}
        
}
