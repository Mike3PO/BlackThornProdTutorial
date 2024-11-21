using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{

    SpriteRenderer rend;

    public Sprite newSprite;

    public Color newColor;

    public Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = newSprite;
        rend.color = newColor;

        transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
