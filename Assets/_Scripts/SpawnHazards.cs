using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHazards : MonoBehaviour {

	public Vector2 spawnValues;
	public GameObject[] hazards;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;


	void Start () {
		StartCoroutine (SpawnWaves());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnWaves() {

		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				GameObject hazard = hazards[Random.Range(0, hazards.Length)];
				Vector3 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);
				Quaternion spawnRotation = Quaternion.identity;

				Instantiate (hazard, spawnPosition, spawnRotation);

				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);

		}
	}
}
