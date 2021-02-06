using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEgg : MonoBehaviour
{
    public void Touch(){
        SceneManager.LoadScene("TouchEgg");
    }    
}
