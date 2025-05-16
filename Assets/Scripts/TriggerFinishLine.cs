using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                SceneManager.LoadScene(2);
            }
            else
            {
                print("Cheater");
                SceneManager.LoadScene(1);
            }
        }
    }
}
