using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering; 

public class happa : MonoBehaviour
{
    Animator animator;
    GameObject clickedGameObject;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            clickedGameObject = null;
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
 
            if (hit2d) {
                clickedGameObject = hit2d.transform.gameObject;
                if(clickedGameObject == this.gameObject){
                    Debug.Log("clicked"+clickedGameObject);
                    animator.SetBool("touch", true);
                    GetComponent<RectTransform>().SetAsLastSibling();

                }
            } 
        }
    }

    public void changepos(){
        animator.SetBool("touch", false);
        Vector2 pos = GetComponent<RectTransform>().anchoredPosition;
        Debug.Log("pos="+pos);
        int r = Random.Range (1, 3);
        if( r == 1 ){
            pos.x = pos.x + 200;
            pos.y = pos.y + -200;
        }else{
            pos.x = pos.x + -200;
            pos.y = pos.y + 200;
        }
        GetComponent<RectTransform>().anchoredPosition = new Vector2(pos.x, pos.y);
        FindObjectOfType<musi1>().hiding(this.gameObject.name, pos.x, pos.y);
        FindObjectOfType<musi2>().hiding(this.gameObject.name, pos.x, pos.y);

    }
}
