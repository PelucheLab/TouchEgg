using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void StopAnime()
    {
        FindObjectOfType<musi1>().StopMusi();
        FindObjectOfType<musi2>().StopMusi();
      

    }
    public void ChangeAnime()
    {
        FindObjectOfType<musi1>().ChangeAnimation();
        FindObjectOfType<musi2>().ChangeAnimation();
      
    }

}
