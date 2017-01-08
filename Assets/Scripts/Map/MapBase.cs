using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MapBase : MonoBehaviour {
	abstract public Vector2[] getSmallEnemies ();
	abstract public Vector2[] getBigEnemies ();
	abstract public Vector2[] getBossEnemies ();
	abstract public float getGoalX ();
}
