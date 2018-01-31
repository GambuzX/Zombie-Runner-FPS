using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform spawnPointsParent;
    public AudioClip whereAmI, clearArea;
    public Helicopter helicopter;
    
    private Transform[] spawnPoints;
    private AudioSource innerVoice;
    private bool lastToggle = false;
    private bool reSpawn = false;
	private bool foundClearArea = false;

    void Start()
    {
        spawnPoints = spawnPointsParent.GetComponentsInChildren<Transform>();

		AudioSource[] audioSources = GetComponents<AudioSource> ();
		foreach (AudioSource audioSource in audioSources) {
			if (audioSource.priority == 1) {
				innerVoice = audioSource;
			}
		}

		innerVoice.clip = whereAmI;
		innerVoice.Play ();
    }

    private void Update()
    {
        if (lastToggle != reSpawn)
        {
            ReSpawn();
            reSpawn = false;
        } else
        {
            lastToggle = reSpawn;
        }
    }

    public void ReSpawn()
    {
        Transform spawnPoint = spawnPoints[Random.Range(1, spawnPoints.Length)];
        this.transform.position = spawnPoint.position;
    }

    void OnFindClearArea()
    {
		if (!foundClearArea) { 
			innerVoice.clip = clearArea;
	        innerVoice.Play();
			foundClearArea = true;
	        Debug.Log("Found clear area!");
			helicopter.Invoke ("Call", clearArea.length + 1);
	        //Deploy flares
	        //SpawnZombies
		}
    }
}
