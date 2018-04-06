﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGen : MonoBehaviour {

	public GameObject road;
	public Transform genPoint;
	private float width;
	public ObjectPooler objPool;

	// Use this for initialization
	void Start () {
		width = road.GetComponent<BoxCollider2D>().size.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < genPoint.position.y) {
			transform.position = new Vector3 (transform.position.x, transform.position.y + width, transform.position.z);
			//Instantiate (platform, transform.position, transform.rotation);

			GameObject newRoad = objPool.GetPooledObject();

			newRoad.transform.position = transform.position;
			newRoad.transform.rotation = transform.rotation;
			newRoad.SetActive (true);
		}
	}
}
