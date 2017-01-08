using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1 : MapBase {
	private const float smallY = -1.5f;
	private const float bigY   = -0.5f;
	private const float bossY  = 0.5f;
	private float goalX = 10f;

	private readonly Vector2[] smallEnemies = {
		new Vector2 (-3f, smallY),
		new Vector2 (0f, smallY),
		new Vector2 (3f, smallY),
		new Vector2 (6f, smallY),
		new Vector2 (9f, smallY),
		new Vector2 (12f, smallY),
		new Vector2 (15f, smallY),
		new Vector2 (18f, smallY),
		new Vector2 (21f, smallY),
		new Vector2 (24f, smallY),
		new Vector2 (27f, smallY),
		new Vector2 (30f, smallY),
		new Vector2 (33f, smallY),
		new Vector2 (36f, smallY),
		new Vector2 (39f, smallY),
		new Vector2 (42f, smallY),
		new Vector2 (45f, smallY),
		new Vector2 (48f, smallY),
		new Vector2 (51f, smallY),
		new Vector2 (54f, smallY),
		new Vector2 (57f, smallY),
		new Vector2 (60f, smallY)
	};

	private readonly Vector2[] bigEnemies = {
		new Vector2 (70f, bigY),
		new Vector2 (75f, bigY)
	};

	private readonly Vector2[] bossEnemies = {
		new Vector2 (90f, bossY)
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

	public override float getGoalX ()
	{
		return goalX;
	}
}
