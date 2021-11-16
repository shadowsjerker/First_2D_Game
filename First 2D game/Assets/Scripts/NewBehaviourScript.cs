using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject gameOb;
	public GameObject mainView;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D))
        {
			//var a = transform.localPosition;
			//a = new Vector3(a.x + 1,a.y);
			//transform.localPosition = a;
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0.5f, 0), ForceMode2D.Impulse);
		}
		if (Input.GetKey(KeyCode.A))
		{
			//var a = transform.localPosition;
			//a = new Vector3(a.x + 1,a.y);
			//transform.localPosition = a;
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.5f, 0), ForceMode2D.Impulse);
		}

		
	}
}
