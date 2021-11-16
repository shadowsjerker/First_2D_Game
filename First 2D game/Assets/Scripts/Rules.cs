using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour {

	public Text deathTitle;

	public Text healthBar;

	public Text appleCountUi;

	public int health = 100;


	float appleCount = 0f;
	// Use this for initialization
	void Start () {
		healthBar.text = health.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		if(health <= 0)
        {
			deathTitle.text = "YOU DIED !!";
			gameObject.GetComponent<playerMovement>().enabled = false;
        }

		if(Input.GetKeyDown(KeyCode.Escape))
        {
			SceneManager.LoadScene("scene");
		}
	}
	
	void OnTriggerEnter2D (Collider2D hitInto)
    {
		GroundSpear gs = hitInto.GetComponent<GroundSpear>();
		FallBorder fb = hitInto.GetComponent<FallBorder>();
		Apple apple = hitInto.GetComponent<Apple>();

		if (gs != null)
        {
			health -= gs.damage / 2;
			healthBar.text = health.ToString();
			Debug.Log("Health reduced to: " + health);
        }

		if(fb != null)
        {
			health = 0;
			healthBar.text = health.ToString();
		}

		if(apple != null)
        {
			appleCount++;
			appleCountUi.text = appleCount.ToString();
        }
    }
}
