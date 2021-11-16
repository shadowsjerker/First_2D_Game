using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public Transform player;
	public Vector3 offset;

	public float smoothFactor;

	private void FixedUpdate()
    {
		Follow();
    }
	
	void Follow()
    {
		Vector3 targetPosition = player.position + offset;
		Vector3 smoothPosition = Vector3.Lerp(player.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
		transform.position = smoothPosition;
    }

}
