using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HunBarCtr : MonoBehaviour
{
    Slider slider;
    int TotalHun = 0;

    void Start () {
        // スライダーを取得する
        slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    public void CountUp()
    {
        Debug.Log("stage = "+ GameData.CurrentStage);
        TotalHun += 1;
        if(TotalHun >= 10){
            TotalHun = 0;
            //LevelUp
            FindObjectOfType<LevelUp>().LevelUpMusi();

        }
        slider.value = TotalHun;
    }

}
