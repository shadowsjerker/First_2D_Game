using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D hitInfo)
    {
		Rules r = hitInfo.GetComponent<Rules>();

		if(r != null)
        {
			Destroy(gameObject);
        }
    }
}
