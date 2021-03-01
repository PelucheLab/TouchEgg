using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musi2 : MonoBehaviour
{

    Animator animator;
    public GameObject canvas;
    Dictionary <string, string> pair;
    [SerializeField] GameObject prefab = null;
    RectTransform  myRectTrans;
    RectTransform  parentRectTrans;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void hiding(string happa, float x, float y){
        if(happa == pair[this.gameObject.name]){
            Debug.Log("pos.x="+x);
            Debug.Log("pos.y="+y);
            animator.SetBool("musi_itween", true);
            GameObject hun = Instantiate(prefab, transform) as GameObject;
            hun.transform.SetParent (canvas.transform,false); 
            myRectTrans = hun.GetComponent<RectTransform>();
            parentRectTrans = (RectTransform) myRectTrans.parent;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTrans, transform.position, null, out Vector2 localPoint);
            hun.transform.localPosition = localPoint;

            Vector2 pos = new Vector2(x, y);
            Vector2 diff = (pos - GetComponent<RectTransform>().anchoredPosition);
            GetComponent<RectTransform>().rotation = Quaternion.FromToRotation (Vector3.up, diff); 
            iTween.MoveTo(this.gameObject,  iTween.Hash("x", x, "y", y, "time", 20.0f, "isLocal",true, "oncomplete", "ChangeAnimation"));
        }
    
    }

    void OnTriggerEnter2D(Collider2D other) {
            pair = new Dictionary<string, string> ();
            pair.Add (this.gameObject.name, other.gameObject.name);
    }
    public void ChangeAnimation()
    {
        animator.SetBool("musi_itween", false);
        Debug.Log("アニメーションが終了しました。");

    }
    public void StopMusi(){
        animator.SetTrigger("stop_musi");
    }

    
}
