using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    public bool destroyOnPlay;
    public int health;

    public SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            Destroy(gameObject);
        } else if(health > 100){
            rend.color = Color.green;
        } else {
            rend.color = Color.white;
        }
    }
}
