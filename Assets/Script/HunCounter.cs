using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HunCounter : MonoBehaviour
{
    int TotalHun = 0;
    int Mokuhyou = 10;
    public Text scoreText;
    public Text MokuhyouText;

    /*var Mokuhyouchi = new Dictionary<int, int>
        {
            { 1, 10 },
            { 2, 10 },
            { 3, 10 },
            { 4, 10 },
            { 5, 20 },
        };
*/
    // Start is called before the first frame update
    void Start()
    {
        //GameData.CurrentStage = 1;
    }

    void jissainokazuRewrite(){

        scoreText.text = TotalHun.ToString();

    }

    void MokuhyouRewrite(){

        MokuhyouText.text = Mokuhyou.ToString();

    }

    // Update is called once per frame
    public void CountUp()
    {
        Debug.Log("stage = "+ GameData.CurrentStage);
        TotalHun++;
        if(TotalHun >= 10){
            TotalHun = 0;
            //LevelUp
            FindObjectOfType<LevelUp>().LevelUpMusi();

        }
        jissainokazuRewrite();
    }

    public void CountDown()
    {
        TotalHun--;
        jissainokazuRewrite();

    }
    
}
