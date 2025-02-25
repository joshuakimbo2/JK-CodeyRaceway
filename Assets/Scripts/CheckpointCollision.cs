using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCollision : MonoBehaviour
{
    public bool didCollide;
    public CheckPointCounter count;
    // Start is called before the first frame update
    void Start()
    {
        didCollide = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && didCollide == false)
        {
            didCollide = true;
            count.triggerCheckpoints++;
        }     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
