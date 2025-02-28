using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineTrigger : MonoBehaviour
{
    public CheckPointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggerCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                print("You Win!");
            }

            else
            {
                print("Cheater");
            }
        }
    }
}
