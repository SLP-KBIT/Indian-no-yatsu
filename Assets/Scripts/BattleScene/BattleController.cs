using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {
	public GameObject smallEnemy;
	public GameObject bigEnemy;
	public GameObject bossEnemy;

	// Use this for initialization
	void Start () {
		Instantiate (smallEnemy);
		Instantiate (bigEnemy);
		Instantiate (bossEnemy);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
