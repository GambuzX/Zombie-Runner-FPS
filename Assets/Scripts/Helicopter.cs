using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    public AudioClip callSound, heliSound;

    private AudioSource audioSource;
    private bool called = false;
    private Rigidbody rigidbody;

	void Start () {
        audioSource = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody>();
	}
	

	void Update () {
        if (called && !audioSource.isPlaying)  //Helicopter moving sound
        {
            audioSource.clip = heliSound;
            audioSource.loop = true;
            audioSource.spatialBlend = 1.0f;
            audioSource.Play();
        }
    }

    public void Call()
    {
        if (Input.GetButtonDown("CallHeli") && !called)
        {
            audioSource.clip = callSound;
            audioSource.Play();
            called = true;
            rigidbody.velocity = new Vector3(0f, 0f, 50f);
        }
    }
}
