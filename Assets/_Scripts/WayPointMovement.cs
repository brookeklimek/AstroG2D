using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMovement : MonoBehaviour {
	
	[SerializeField]
	private List<Transform> wayPoints;


	public float speed = 10f;
	private Transform target;
	private int waypointIndex = 0;

	void Start () {
		target = wayPoints[0];
	}

	void Update () {
		Movement();
	}

	void GetNextWayPoint() {
		if (waypointIndex >= wayPoints.Count - 1)
		{
			waypointIndex = 0;
		}
		else
		{
			waypointIndex++;
		}
		target = wayPoints[waypointIndex];
	}


	void Movement() {
		Vector3 dir = target.position - transform.position;
		transform.Translate(dir.normalized * speed * Time.deltaTime , Space.World);
		if (Vector3.Distance(transform.position, target.position) <= 0.2f)
		{
			GetNextWayPoint();
		}
	}


}
