using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDialog : MonoBehaviour
{
    int stage;
    Sprite ItemSprite;
    Dictionary<string, string> ItemName = new Dictionary<string, string>
    {
        {"item1", "100えんだま" },
        {"item2", "10えんだま" },
        {"item3", "5えんだま" },
        {"item4", "1えんだま" },
        {"item5", "ゆびわ" },
        {"item6", "かぎ" },
        {"item7", "びーだま" },
        {"item8", "クレジットカード" },
       
    };


    public void SetDialog(string itemname){
        itemname = itemname.Replace("(Clone)","");			
        ItemSprite = Resources.Load<Sprite>("item/" + itemname);
        transform.Find("item").GetComponent<Image>().sprite = ItemSprite;
        transform.Find("itemname").GetComponent<Text> ().text = ItemName[itemname].ToString();

    }

    // Update is called once per frame
    public void ClickButton()
    {
        this.gameObject.SetActive (false);

    }
}
