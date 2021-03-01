using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering; 

public class happa : MonoBehaviour
{
    Animator animator;
    GameObject clickedGameObject;
    float width;
    float height;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        width = Screen.width;
        height = Screen.height;
        Debug.Log("width=" + width);
        Debug.Log("heigth=" + height);
      
    }

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            clickedGameObject = null;
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
 
            if (hit2d) {
                clickedGameObject = hit2d.transform.gameObject;
                if(clickedGameObject == this.gameObject){
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
            if(pos.x >= width/2){
                pos.x = pos.x - 300;
            }
            if(pos.y <= -height/2){
                pos.y = pos.y + 300;
            }
        }else{
            pos.x = pos.x - 200;
            pos.y = pos.y + 200;
            if(pos.x <= -width/2){
                pos.x = pos.x + 300;
            }
            if(pos.y >= height/2){
                pos.y = pos.y - 300;
            }
        }
        GetComponent<RectTransform>().anchoredPosition = new Vector2(pos.x, pos.y);
        FindObjectOfType<musi1>().hiding(this.gameObject.name, pos.x, pos.y);
        FindObjectOfType<musi2>().hiding(this.gameObject.name, pos.x, pos.y);

    }
}
