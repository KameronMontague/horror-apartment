using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour 
{

	public bool open = false;

	public AudioSource doorSound;
	public AudioClip doorOpening;

	public float doorOpenAngle = 90f;
	public float doorClosedAngle = 0f;

	public float smooth = 2f;

	public void changeDoorState()
	{
		open = !open;

		if (open = true) 
		{
			doorSound.PlayOneShot (doorOpening);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (open) {
			//open the door
			Quaternion targetRotationOpen = Quaternion.Euler (0, doorOpenAngle, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);
		} else 
		{
			Quaternion targetRotationClosed = Quaternion.Euler(0, doorClosedAngle, 0 );
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotationClosed, smooth * Time.deltaTime);
		}

	}
}
