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
        { 1, "musi1-2" },
        { 2, "musi1-3" },
        { 3, "musi1-4" },
        { 4, "musi2-2" },
        { 5, "musi2-3" },
        { 6, "musi2-4" },
        { 7, "musi2-5" },
        { 8, "musi2-6" },
       
    };

    Dictionary<int, string> TargetName = new Dictionary<int, string>
    {
        { 1, "レモンてんとうムシ" },
        { 2, "オレンジてんとうムシ" },
        { 3, "モモてんとうムシ" },
        { 4, "キジリだんごムシ" },
        { 5, "アカジリだんごムシ" },
        { 6, "アオジリだんごムシ" },
        { 7, "ミドリジリだんごムシ" },
        { 8, "レインボーだんごムシ" },
       
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
