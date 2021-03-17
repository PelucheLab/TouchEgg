using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering; 

public class item : MonoBehaviour
{
    float width;
    float height;
    GameObject clickedGameObject;


    // Start is called before the first frame update
    void Start()
    {
        height = Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            clickedGameObject = null;
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
 
            if (hit2d) {
                clickedGameObject = hit2d.transform.gameObject;
                if(clickedGameObject == this.gameObject){
                    
                    if( height > 1100){
                        FindObjectOfType<Itemgenerator>().SetActiveDialog(0);   
                    }else{
                        FindObjectOfType<Itemgenerator>().SetActiveDialog(1);   
                    }

                    FindObjectOfType<ItemDialog>().SetDialog(this.gameObject.name);
                    Destroy (this.gameObject);

                }
            } 
        }
    }
}
