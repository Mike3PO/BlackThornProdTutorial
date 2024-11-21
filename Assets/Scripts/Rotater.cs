using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotater : MonoBehaviour
{
    private float speed;
    public float minSpeed;
    public float maxSpeed;

	private void Start()
	{
		speed = Random.Range(minSpeed, maxSpeed);
	}

	private void Update()
	{
		transform.Rotate(Vector3.forward * speed * Time.deltaTime);
	}
}
