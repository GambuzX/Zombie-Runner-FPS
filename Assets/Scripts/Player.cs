using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform spawnPointsParent;
    
    private Transform[] spawnPoints;
    private bool lastRespawnToggle = false;
    private bool reSpawn = false;
	private bool foundClearArea = false;
	private InnerVoice innerVoice;

    void Start()
    {
        spawnPoints = spawnPointsParent.GetComponentsInChildren<Transform>();
		innerVoice = GetComponentInChildren<InnerVoice> ();
    }

    private void Update()
    {
        if (lastRespawnToggle != reSpawn)
        {
            ReSpawn();
            reSpawn = false;
        } else
        {
            lastRespawnToggle = reSpawn;
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
			foundClearArea = true;
			Invoke ("DropFlare", 3f);
	        //Deploy flares
	        //SpawnZombies
		}
    }

	void DropFlare() {
		//Do stuff
	}
}
