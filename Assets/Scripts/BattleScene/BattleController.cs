using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {
	public GameObject smallEnemy;
	public GameObject bigEnemy;
	public GameObject bossEnemy;
	public MapBase map;
	public GameObject mainCamera;

	// Use this for initialization
	void Start () {
		foreach (Vector2 v in map.getSmallEnemies()) {
			Instantiate (smallEnemy, v, Quaternion.identity);
		}

		foreach (Vector2 v in map.getBigEnemies()) {
			Instantiate (bigEnemy, v, Quaternion.identity);
		}

		foreach (Vector2 v in map.getBossEnemies()) {
			Instantiate (bossEnemy, v, Quaternion.identity);
		}

		mainCamera.GetComponent<UnityStandardAssets._2D.CameraFollow> ().maxXAndY = new Vector2 (100f, 0f);
		Debug.Log (map.getGoalX ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
