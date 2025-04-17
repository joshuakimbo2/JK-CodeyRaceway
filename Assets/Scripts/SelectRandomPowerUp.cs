using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerUp : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
