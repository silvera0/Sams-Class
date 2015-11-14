using UnityEngine;
using System.Collections;

public class Chase : MonoBehaviour {

	public GameObject targetObject;
	public float moveSpeed;

	private Transform chaser;
	private Transform target;


	// Use this for initialization
	void Start () {
	 	
		chaser = transform;
		target =  targetObject.transform;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 direction = (target.position - chaser.position).normalized;
		Vector3 movement = direction * moveSpeed * Time.deltaTime;
		Vector3 newPosition = chaser.position + movement;

		transform.position = newPosition;

	}
}
