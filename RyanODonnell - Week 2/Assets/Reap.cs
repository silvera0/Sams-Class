using UnityEngine;
using System.Collections;

public class Reap : MonoBehaviour {
	
	public GameObject targetObject;
	public float acceleration;
	public float maxVelocity;
	
	private Transform reaper;
	private Transform target;
	private Vector3 reaperVelocity;
	private float vel;
	
	
	// Use this for initialization
	void Start () {
		
		reaper = transform;
		target = targetObject.transform;
		vel = 0.0f;
		reaperVelocity = (target.position - reaper.position).normalized;
		
	}
	
	// Update is called once per frame
	void Update () {

		/*
		//print (reaperVelocity.magnitude + "YUP");
		if(reaperVelocity.magnitude < maxVelocity)
		{
			reaperVelocity = reaperVelocity + (reaperVelocity * acceleration * Time.deltaTime);

			print (reaperVelocity.magnitude);
		}
		if(reaperVelocity.magnitude > maxVelocity)
		{
			print ("CHange" + reaperVelocity);

			reaperVelocity = reaperVelocity - (reaperVelocity / acceleration * Time.deltaTime);

		}

		Vector3 direction = (target.position - reaper.position).normalized;
		//Vector3 movement =  reaperVelocity.normalized * reaperVelocity.magnitude * Time.deltaTime;
		Vector3 movement = (reaperVelocity.normalized + direction)* reaperVelocity.magnitude * Time.deltaTime;
		Vector3 newPosition = reaper.position + movement;
		
		transform.position = newPosition;

*/
	/*	Vector3 direction = (target.position - reaper.position);
		if(reaperVelocity.magnitude > maxVelocity)
		{
			reaperVelocity = reaperVelocity.normalized * maxVelocity;
		}
		else
		{
			print("Before" + reaperVelocity);
			reaperVelocity = reaperVelocity.normalized * (reaperVelocity.magnitude + (acceleration * Time.deltaTime));
			print ("After" + reaperVelocity);
		}

		//We need to move along reapers path
		Vector3 movement = (reaperVelocity + direction) * Time.deltaTime;
		Vector3 newPosition = reaper.position + movement;
		print("Movement" + movement);
		transform.position = newPosition;
*/

		Vector3 direction = (target.position - reaper.position).normalized;

		if(vel < maxVelocity)
		{
			vel+= (acceleration * Time.deltaTime);
		}
		else
		{
			vel = maxVelocity;
		}

		Vector3 movement = direction * vel * Time.deltaTime;
		Vector3 newPosition = reaper.position + movement;

		transform.position = newPosition;
	}
}

