using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    public AudioClip callSound, heliSound;

    private AudioSource audioSource;
    private bool called = false;

	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	

	void Update () {
		if (Input.GetButtonDown("CallHeli") && !called)
        {
            audioSource.clip = callSound;
            audioSource.Play();
            called = true;
        }
        
        if (called && !audioSource.isPlaying)
        {
            audioSource.clip = heliSound;
            audioSource.loop = true;
            audioSource.spatialBlend = 1.0f;
            audioSource.Play();
        }
	}
}
