using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject objectToSpawn;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10)), Quaternion.identity);

        }
    }
}
