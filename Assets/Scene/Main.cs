using System.Collections;using System.Collections.Generic;using UnityEngine;public class Main : MonoBehaviour {    public Enemy enemy;	void Start () {	}		void Update () {        if (enemy != null)
        {
            Debug.Log("hoge");
            enemy.reciveDamage(20);            if (enemy.deadOrLive() == false)            {                enemy.vanish();            }
        }	}}