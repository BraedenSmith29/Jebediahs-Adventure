using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public GameObject Enemy;
	private float spawnTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		SpawnEnemy ();
	}

	void SpawnEnemy() {
		spawnTime += Time.deltaTime;
		if (spawnTime >= 20) {
			Instantiate (Enemy, new Vector2 (Random.Range(1129, 1204), Random.Range(734, 768)), Quaternion.identity);
			spawnTime = 0;
		}
	}
}
