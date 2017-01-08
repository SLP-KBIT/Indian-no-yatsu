using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	private static Vector2 SPEED = new Vector2(0.1f, 0.15f);	// 速度

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Move ();
	}

	// 移動関数
	void Move ()
	{
		Vector2 position = transform.position;

		if ( Input.GetKey("left") ) {
			position.x -= SPEED.x;
		}
		if ( Input.GetKey("right") ) {
			position.x += SPEED.x;
		}
		if ( Input.GetKey("up") ){
			position.y += SPEED.y;
		}
		if ( Input.GetKey("down") ){
			// position.y -= SPEED.y;
		}

		transform.position = position;
	}
}
