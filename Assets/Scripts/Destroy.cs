using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public GameObject objectToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(objectToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
