using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usagi : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip sound1;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void touch_right(){
        audioSource.PlayOneShot(sound1);
        Rigidbody2D rig = transform.GetChild(0).gameObject.GetComponent<Rigidbody2D>();
        rig.AddForce(Vector2.left * 300);



    }
    public void touch_left(){
        audioSource.PlayOneShot(sound1);
        Rigidbody2D rig = transform.GetChild(0).gameObject.GetComponent<Rigidbody2D>();
        rig.AddForce(Vector2.right * 300);


    }

}
