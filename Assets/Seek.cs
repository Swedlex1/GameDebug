using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // CHALLENGE: This could be more efficient
        GameObject moveTowardsThis = GameObject.FindWithTag("Player");
        Vector3 vector3 = Vector3.MoveTowards(transform.position, moveTowardsThis.transform.position, 0.005f);
        transform.position = vector3;
        // put in player's position
    }
}
