using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    Sprite CafeSprite1;
    Sprite CafeSprite2;
    public GameObject Dialog;
    public Text Level;

    int stage = 1;

    Dictionary<int, string> Target = new Dictionary<int, string>
    {
        { 1, "musi1-2" },
        { 2, "musi1-3" },
        { 3, "musi1-4" },
        { 4, "musi2-2" },
        { 5, "musi2-3" },
        { 6, "musi2-4" },
        { 7, "musi2-5" },
        { 8, "musi2-6" },
       
    };

    void Start()
    {
        GameData.CurrentStage = 1;
		Level.text = GameData.CurrentStage.ToString();

    }

    public void LevelUpMusi(){
        stage = GameData.CurrentStage;
        Debug.Log("Levelup_ahora" + stage);
        GameData.CurrentStage++;
        Level.text = GameData.CurrentStage.ToString();
        Dialog.SetActive (true);

        FindObjectOfType<StopAnimation>().StopAnime();
		StartCoroutine("TimerCoroutine");	

    } 

    IEnumerator TimerCoroutine(){
        yield return new WaitForSeconds(2.0f);

        string Levelup_target = Target[stage];
        Debug.Log("leveluptarget="+Levelup_target);
        CafeSprite1 = Resources.Load<Sprite>("musi/" + Levelup_target + "-1");
        CafeSprite2 = Resources.Load<Sprite>("musi/" + Levelup_target + "-2");
        if (Levelup_target.Contains("musi1")){
            GameObject musi1_1 = GameObject.Find("musi1/musi1-1-1");
            musi1_1.gameObject.GetComponent<Image>().sprite = CafeSprite1;
            GameObject musi1_2 = GameObject.Find("musi1/musi1-1-2");
            musi1_2.gameObject.GetComponent<Image>().sprite = CafeSprite2;

        }
        if (Levelup_target.Contains("musi2")){
            GameObject musi2_1 = GameObject.Find("musi2/musi2-1-1");
            musi2_1.gameObject.GetComponent<Image>().sprite = CafeSprite1;
            GameObject musi2_2 = GameObject.Find("musi2/musi2-1-2");
            musi2_2.gameObject.GetComponent<Image>().sprite = CafeSprite2;

        }
       

        FindObjectOfType<StopAnimation>().ChangeAnime();

    }


}
