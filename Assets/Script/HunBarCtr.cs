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
        slider.value = TotalHun;
        if(TotalHun >= 5){
            TotalHun = 0;
            //LevelUp
            FindObjectOfType<LevelUp>().LevelUpMusi();

        }
            
    }
    public void Barzero(){
        slider.value = TotalHun;
    }

}
