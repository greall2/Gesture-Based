using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour {

	public GameObject[] cars;
	public Transform[] spawn;
    float delayTime = 5f;

	// Use this for initialization
	 void Start () {

        InvokeRepeating("Spawn", delayTime, 3f);	
	}
	
	void Spawn()
    {
        int spawnIndex = Random.Range(0, spawn.Length);
        int carsIndex = Random.Range(0, cars.Length);

        Instantiate(cars[carsIndex], spawn[spawnIndex].position, spawn[spawnIndex].rotation);
    }
}
