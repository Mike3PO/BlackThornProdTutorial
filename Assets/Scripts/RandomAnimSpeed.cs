using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimSpeed : MonoBehaviour
{
    private Animator anim;

	private void Start()
	{
		anim = GetComponent<Animator>();
		anim.speed = Random.Range(.75f, 1.25f);
	}
}
