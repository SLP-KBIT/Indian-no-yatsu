using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1 : MapBase {
	private const float smallY = -1.5f;
	private const float bigY   = -0.5f;
	private const float bossY  = 0.5f;

	private readonly Vector2[] smallEnemies = {
		new Vector2 (-3f, smallY),
		new Vector2 (0f, smallY),
		new Vector2 (10f, smallY)
	};

	private readonly Vector2[] bigEnemies = {
		new Vector2 (15f, bigY),
		new Vector2 (20f, bigY)
	};

	private readonly Vector2[] bossEnemies = {
		new Vector2 (30f, bossY)
	};

	public override Vector2[] getSmallEnemies ()
	{
		return smallEnemies;
	}

	public override Vector2[] getBigEnemies ()
	{
		return bigEnemies;
	}

	public override Vector2[] getBossEnemies ()
	{
		return bossEnemies;
	}
}
