﻿using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	public Light flashLight;
	public AudioSource audioSource;

	public AudioClip soundFlashlightOn;
	public AudioClip soundFlashlightOff;


	private bool isActive;

	// Use this for initialization
	void Start () 
	{
		isActive = true;	
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.F))
		{
			if (isActive == false) //Toggle flashlight on
			{
				flashLight.enabled = true;
				isActive = true;

				audioSource.PlayOneShot (soundFlashlightOn);

			}
				else if (isActive == true) //Toggle flashlight off
					{
						flashLight.enabled = false;
						isActive = false;
				audioSource.PlayOneShot (soundFlashlightOff);
					}
		}
	
	}
}
