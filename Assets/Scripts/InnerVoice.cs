using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

	public AudioClip whereAmI, clearArea;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();

		audioSource.clip = whereAmI;
		audioSource.Play ();
	}

	public void OnFindClearArea() {
		audioSource.clip = clearArea;
		audioSource.Play ();

		Invoke ("CallHeli", clearArea.length + 1f);
	}

	private void CallHeli () {
		SendMessageUpwards ("InitialHeliCall");
	}
}
