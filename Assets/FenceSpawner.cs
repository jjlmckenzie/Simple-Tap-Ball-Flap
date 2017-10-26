using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceSpawner : MonoBehaviour {

	public float maxYpos;
	public float minYpos;
	public float spawnTime;
	public GameObject fence;

	// Use this for initialization
	void Start () {
		//StartSpawningFences ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StopSpawningFences () {
		CancelInvoke ("SpawnFence");
	}

	void SpawnFence() {
		Instantiate(fence, new Vector3(transform.position.x, Random.Range(-minYpos, maxYpos), 0), Quaternion.identity);
	}

	public void StartSpawningFences() {
		InvokeRepeating ("SpawnFence", 0.2f, spawnTime);
	}

}
