using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    public AudioClip callSound;

    private AudioSource audioSource;
    private bool called = false;

	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	

	void Update () {
		if (Input.GetButtonDown("CallHeli") && !called)
        {
            audioSource.Play();
            called = true;
        }
	}
}
