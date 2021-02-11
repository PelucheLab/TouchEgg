using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musi2 : MonoBehaviour
{

    Animator animator;
    Dictionary <string, string> pair;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void hiding(string happa, float x, float y){
        if(happa == pair[this.gameObject.name]){
            Vector2 pos = new Vector2(x, y);
            Vector2 diff = (pos - GetComponent<RectTransform>().anchoredPosition);
            GetComponent<RectTransform>().rotation = Quaternion.FromToRotation (Vector3.up, diff); 
            iTween.MoveTo(this.gameObject,  iTween.Hash("x", x, "y", y, "time", 40.0f, "isLocal",true));
        }
    
    }

    void OnTriggerEnter2D(Collider2D other) {
            pair = new Dictionary<string, string> ();
            pair.Add (this.gameObject.name, other.gameObject.name);
    }
    
}
