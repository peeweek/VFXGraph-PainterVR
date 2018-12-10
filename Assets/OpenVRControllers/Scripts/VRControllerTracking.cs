﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class VRControllerTracking : MonoBehaviour {

	[SerializeField] XRNode whichNode = XRNode.LeftHand;

		// Use this for initialization
	void Start () {

		if (XRSettings.enabled == false) {
			Destroy (this);
		}

	}
	
	// Update is called once per frame
	void Update () {
		// For now, Only depend on parent node. So, it is ok if rotation of parent is not 0.
		transform.localPosition = InputTracking.GetLocalPosition (whichNode);
		transform.localRotation = InputTracking.GetLocalRotation (whichNode);
	}
}
