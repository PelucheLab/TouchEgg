using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpDialog : MonoBehaviour
{
    int stage;
    Sprite CafeSprite;
    Dictionary<int, string> Target = new Dictionary<int, string>
    {
        { 2, "musi1-2" },
        { 3, "musi1-3" },
        { 4, "musi1-4" },
        { 5, "musi2-2" },
        { 6, "musi2-3" },
        { 7, "musi2-4" },
        { 8, "musi2-5" },
        { 9, "musi2-6" },
       
    };

    Dictionary<int, string> TargetName = new Dictionary<int, string>
    {
        { 2, "レモンてんとうムシ" },
        { 3, "オレンジてんとうムシ" },
        { 4, "モモてんとうムシ" },
        { 5, "キジリだんごムシ" },
        { 6, "アカジリだんごムシ" },
        { 7, "アオジリだんごムシ" },
        { 8, "ミドリジリだんごムシ" },
        { 9, "レインボーだんごムシ" },
       
    };


    // Start is called before the first frame update
    void OnEnable()
    {
        stage = GameData.CurrentStage;
        string Levelup_target = Target[stage];
        CafeSprite = Resources.Load<Sprite>("musi/" + Levelup_target + "-1");
        transform.Find("musi").GetComponent<Image>().sprite = CafeSprite;
        transform.Find("musiname").GetComponent<Text> ().text = TargetName[stage].ToString();;

    }

    // Update is called once per frame
    public void ClickButton()
    {
        GameData.CurrentStage++;
        FindObjectOfType<HunBarCtr>().Barzero();
        this.gameObject.SetActive (false);

    }
}
