using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering; 

public class Hun : MonoBehaviour
{
    GameObject clickedGameObject;
    Animator animator;
    float lifetime = 3.0f;
    AudioSource audioSource;
    public AudioClip sound1;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

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
                    animator.SetBool("Get", true);
                    audioSource.PlayOneShot(sound1);
                    FindObjectOfType<HunCounter>().CountUp();
                    Debug.Log("clickedFun"+clickedGameObject);
                    Destroy (this.gameObject, lifetime);

                }
            } 
        }
    }
}
