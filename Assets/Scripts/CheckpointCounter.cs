using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointCounter : MonoBehaviour
{
    public int numberOfCheckpoints;
    public int triggerCheckpoints;
    // Start is called before the first frame update
    void Start()
    {
        numberOfCheckpoints = GameObject.FindGameObjectsWithTag("checkpoint").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
