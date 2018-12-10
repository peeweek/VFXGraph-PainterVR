﻿using UnityEngine;
using UnityEngine.XR;

public class PlayerTrackingAdjustment : MonoBehaviour 
{

	[SerializeField] float playerHeight = 1.7f;

	void Start () 
	{
		if (XRSettings.enabled == false) {
			Destroy (this);
		}

		//Roomscale VR will track a player's actual height while playing. As such, we need to position the camera on
		//the ground and the player will be the correct height in the game
		if (XRDevice.GetTrackingSpaceType () == TrackingSpaceType.RoomScale) {
			Debug.Log ("Roomscale Tracking");
			//transform.localPosition = Vector3.zero;
		} else {
			Debug.Log ("Stationary Tracking");
			transform.localPosition += Vector3.up * playerHeight;
		}
	}
}
