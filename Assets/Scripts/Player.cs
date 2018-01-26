using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform spawnPointsParent;
    public AudioClip clearArea;
    public Helicopter helicopter;
    
    private Transform[] spawnPoints;
    private AudioSource audioSource;
    private bool lastToggle = false;
    private bool reSpawn = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spawnPoints = spawnPointsParent.GetComponentsInChildren<Transform>();
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
        //audioSource.clip = clearArea;
        //audioSource.Play();
        Debug.Log("Found clear area!");
        helicopter.Call();
        //Deploy flares
        //SpawnZombies
    }
}
