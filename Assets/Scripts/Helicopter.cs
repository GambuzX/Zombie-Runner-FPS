using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    public AudioClip heliSound;

    private bool called = false;
    private Rigidbody rigidbody;

	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}

    public void DispatchHelicopter()
    {
        if (!called)
        {
			SendMessageUpwards ("CallHelicopter");
            called = true;
            rigidbody.velocity = new Vector3(0f, 0f, 50f);
        }
    }
}
