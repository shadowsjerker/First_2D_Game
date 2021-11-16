using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public float speed = 40f;
	public Rigidbody2D rg;

	// Use this for initialization
	void Start () {

		rg.velocity = transform.right * speed;

	}

	void OnTriggerEnter2D (Collider2D hitInfo)
    {
		Destroy(gameObject);
    }
	
}
