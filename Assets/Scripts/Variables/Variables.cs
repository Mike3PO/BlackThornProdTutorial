using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

    public string characterName;
    public int health;
    public float armor;
    public bool isBoss;

    // Start is called before the first frame update
    void Start()
    {
        print(characterName);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
