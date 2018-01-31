using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

	public AudioClip helicopterCall, callReply;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}


	private void InitialHeliCall() {
		audioSource.clip = helicopterCall;
		audioSource.Play ();
		Invoke ("HeliCallReply", 1f);
	}

	private void HeliCallReply() {
		audioSource.clip = callReply;
		audioSource.Play ();
		BroadcastMessage ("DispatchHelicopter");
	}
}
