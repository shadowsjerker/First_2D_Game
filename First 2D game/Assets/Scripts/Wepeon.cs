using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wepeon : MonoBehaviour {

	public Transform firePoint;
	public GameObject bullet;
	public Animator animator;

	public float fireRate = 1f;
	float lastTimeShoot = 0f;

	// Update is called once per frame
	void Update () {
		
		if(Input.GetButton("Fire1"))
        {
			if ((lastTimeShoot + fireRate) <= Time.time || lastTimeShoot == 0)
			{
				Shoot();
				animator.SetBool("Fire", true);
			}
		}
        else
        {
			animator.SetBool("Fire", false);
        }
	}

	void OnStopShooting()
    {

    }

	void Shoot()
	{
			Instantiate(bullet, firePoint.position, firePoint.rotation);
			lastTimeShoot = Time.time;
	}

	
		
			

        
}
