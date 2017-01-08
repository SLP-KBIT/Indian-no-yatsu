using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	private static Vector2 SPEED = new Vector2(0.1f, 0.15f);	// 速度
	private Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		anim.SetBool("isSlide", false);
		Move ();
		Slide ();
	}

	// 移動関数
	void Move ()
	{
		Vector2 position = transform.position;

		if ( Input.GetKey("left") ) {
			position.x -= SPEED.x;
			transform.localRotation = Quaternion.Euler(0, 180, 0);
		}
		if ( Input.GetKey("right") ) {
			position.x += SPEED.x;
			transform.localRotation = Quaternion.Euler(0, 0, 0);
		}
		if ( Input.GetKey("up") ){
			position.y += SPEED.y;
		}
		if ( Input.GetKey("down") ){
			// position.y -= SPEED.y;
		}

		transform.position = position;
	}

	void Slide ()
	{
		if ( !Input.GetKey("space") ) { return; }

		anim.SetBool("isSlide", true);
		Vector2 position = transform.position;
		float rotationX = transform.localRotation.y == 0 ? 1 : -1;
		Vector2 endPosition = new Vector2 (position.x + 0.5f * rotationX, position.y);
		transform.position = endPosition;
	}
}
