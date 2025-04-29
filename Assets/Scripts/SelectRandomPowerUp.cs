using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectRandomPowerUp : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public float spawndistance = 4f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chosenPowerup != null)
        {
            Instantiate(chosenPowerup, transform.position + (transform.forward * spawndistance), transform.rotation);
            chosenPowerup = null;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "PowerUp")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];

            Destroy(other.gameObject);
            Debug.Log("PowerUp = " + chosenPowerup.name);
        }
        
    }
}
