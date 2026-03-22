using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    const float timelimit = 0.5f;
    float timeSinceLastDog = 0.0f;

   
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog

        timeSinceLastDog += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceLastDog>timelimit)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceLastDog = 0.0f;
        }
    }
}
