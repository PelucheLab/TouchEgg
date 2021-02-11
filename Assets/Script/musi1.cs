using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musi1 : MonoBehaviour
{

    Animator animator;
    Dictionary <string, string> pair;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    public void hiding(string happa, float x, float y){
        Debug.Log("happa="+happa);
        Debug.Log("pair="+pair[this.gameObject.name]);
        Debug.Log("自分は="+this.gameObject.name);
       
       
       
        if(happa == pair[this.gameObject.name]){
            Debug.Log("pos.x="+x);
            Debug.Log("pos.y="+y);
            Vector2 pos = new Vector2(x, y);
            Vector2 diff = (pos - GetComponent<RectTransform>().anchoredPosition);
            GetComponent<RectTransform>().rotation = Quaternion.FromToRotation (Vector3.up, diff); 
            iTween.MoveTo(this.gameObject,  iTween.Hash("x", x, "y", y, "time", 20.0f, "isLocal",true));
        }
    
    }

    void OnTriggerEnter2D(Collider2D other) {
            Debug.Log("重なり"+other.gameObject.name);
            Debug.Log("自分"+this.gameObject.name);
            pair = new Dictionary<string, string> ();
            pair.Add (this.gameObject.name, other.gameObject.name);
    }
    
}
