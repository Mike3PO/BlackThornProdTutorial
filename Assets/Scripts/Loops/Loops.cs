using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public GameObject treePrefab;

    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i < 10; i++){
            Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
            Instantiate(treePrefab, randomPosition, Quaternion.identity);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
