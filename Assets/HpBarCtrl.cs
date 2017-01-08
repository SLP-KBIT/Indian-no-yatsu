using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarCtrl : MonoBehaviour {
    Slider slider;
    float hp;

    // Use this for initialization
    void Start () {
        // スライダーを取得する
        slider = GetComponent<Slider>();
        hp = slider.maxValue;
    }

    // Update is called once per frame
    void Update () {
        // HP上昇
        hp -= 1;
        if (hp < 0)
        {
            // 最大を超えたらMAXに戻す
            hp = slider.maxValue;
        }

        // HPゲージに値を設定
        slider.value = hp;
    }
}
