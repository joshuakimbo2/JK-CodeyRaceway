using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;

    public int numberOfBoxes;

    public float modifyXPosition;
    public float modifyZPosition;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;

        for (int i = 0; i < numberOfBoxes; i++)
        {
            pos.x = transform.position.x + modifyXPosition * i;
            pos.y = transform.position.y;
            pos.z = transform.position.z + modifyZPosition * i;
            



            GameObject itemBoxClone = Instantiate(itemBox, pos, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
