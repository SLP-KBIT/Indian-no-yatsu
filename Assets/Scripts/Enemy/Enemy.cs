using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	private int hp;
	private Slider slider;

    public Enemy(int hp)
    {
        this.hp = hp;
    }

    public int getHp()
    {
        return hp;
    }

    public void reciveDamage(int damage)
    {
        hp -= damage;
    }

    public void vanish()
    {
        Destroy(gameObject);
    }

    public bool deadOrLive()
    {
        if (hp > 0)
        {
            return true;
        }
        return false;
    }

	void Start () {
		// スライダーを取得する
		slider = transform.FindChild("HpCanvas").FindChild("HpBar").GetComponent<Slider>();
		slider.maxValue = getHp();
	}

	void Update() {
		slider.value = getHp ();
		if (hp <= 0) {
			vanish ();
		}
	}


	void OnCollisionEnter2D(Collision2D collision) 
	{
		Debug.Log (collision.gameObject.tag);
		if (collision.gameObject.tag == "Player") 
		{
			reciveDamage (20);
		}
	}
}
