using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingAreaDetector : MonoBehaviour {

    private bool clear = false;
    private bool soundPlayed = false;
    public float timeSinceLastTrigger = 0f;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }    

	void Update () {
        timeSinceLastTrigger += Time.deltaTime;

        if (timeSinceLastTrigger >= 1 && !soundPlayed)
        {
            clear = true;
            soundPlayed = true;
            audioSource.Play();
        }
	}

    void OnTriggerStay()
    {
        timeSinceLastTrigger = 0f;
        soundPlayed = false;
    }
}
