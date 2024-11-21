using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    public GameObject objectToSpawn;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
