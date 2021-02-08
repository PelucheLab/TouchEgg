using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usagi : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        
        //if (Input.GetMouseButtonDown(0))
        //{
            
          //  Rigidbody2D rig = transform.GetChild(0).gameObject.GetComponent<Rigidbody2D>();
            //rig.AddForce(Vector2.right * 100);

        //}
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("当たった!");
    }

    public void touch_right(){
        Debug.Log("右をタッチ");
        Rigidbody2D rig = transform.GetChild(2).gameObject.GetComponent<Rigidbody2D>();
        rig.AddForce(Vector2.left * 200);


    }
    public void touch_left(){
        Debug.Log("左をタッチ");
        Rigidbody2D rig = transform.GetChild(2).gameObject.GetComponent<Rigidbody2D>();
        rig.AddForce(Vector2.right * 200);


    }

}
