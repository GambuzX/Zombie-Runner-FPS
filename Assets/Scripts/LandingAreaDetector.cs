using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingAreaDetector : MonoBehaviour {

    private bool clear = false;
    public float timeSinceLastTrigger = 0f; //TODO public for testing. After done change to private

	void Update () {
        timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger >= 1 && Time.realtimeSinceStartup > 10f)
        {
            clear = true;
            SendMessageUpwards("OnFindClearArea");
        }
	}

    void OnTriggerStay()
    {
        timeSinceLastTrigger = 0f;
    }
}
