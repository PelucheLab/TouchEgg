using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AriD : MonoBehaviour
{

    Animator animator;
    float chargeTime = 15.0f;
    float timeCount;
    float pos_x = 0.0f;
    float pos_y = 1000.0f;
    int flg = 0;
    Vector3 position;
    Vector3 diff;

    void Start(){
        animator = GetComponent<Animator>();
    }

    void Update () {
        Move();
    }

    void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("reach", false);
            animator.SetBool("destroy", false);
            position = Input.mousePosition;
            diff = (position - this.transform.position);
            this.transform.rotation = Quaternion.FromToRotation (Vector3.up, diff);    
            position.x = position.x -70;
            position.y = position.y -70;
            iTween.MoveTo(this.gameObject,  iTween.Hash("x", position.x, "y", position.y, "time", 20.0f,"delay",0.5f));
            flg = 1;
        }
        if(flg == 1){
            this.transform.rotation = Quaternion.FromToRotation (Vector3.up, diff);    
        }
        int count = GameObject.FindObjectOfType<CookieGenerator>().returncount();
        if(count == 0){
            animator.SetBool("reach", false);
            animator.SetBool("destroy", false);
            timeCount += Time.deltaTime;
            Vector3 pos = new Vector3(pos_x, pos_y);
            Vector3 diff2 = (pos - this.transform.position);
            this.transform.rotation = Quaternion.FromToRotation (Vector3.up, diff2);   

            // 自動で前進する。
            iTween.MoveTo(this.gameObject,  iTween.Hash("x", pos_x, "y", pos_y, "time", 200.0f));
            if (timeCount > chargeTime){
                // 進路をランダムに変更する。
                pos_y = UnityEngine.Random.Range(0.0f, Screen.height);
                pos_x = UnityEngine.Random.Range(0.0f, Screen.width);
                Debug.Log("pos_x =" +pos_x);
                Debug.Log("pos_y =" +pos_y);

                timeCount = 0;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag != "Ari" ){
            iTween.Stop(this.gameObject, "move");
            animator.SetBool("reach", true);

        }
    }

}
