using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedBoost : MonoBehaviour
{
    public float SpeedMultiplier;
    public float Duration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<CodeyMove>().SetSpeedMultiplier(SpeedMultiplier, Duration);
        Destroy(gameObject);

    }
}
