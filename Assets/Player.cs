using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform spawnPointsParent;
    public bool reSpawn = false;

    private Transform[] spawnPoints;
    private bool lastToggle = false;

    void Start()
    {
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
}
