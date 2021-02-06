using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTop : MonoBehaviour
{
    // Start is called before the first frame update

    public void Touch(){
        SceneManager.LoadScene("Top");
    }    
}
