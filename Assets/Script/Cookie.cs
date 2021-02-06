using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cookie : MonoBehaviour
{
    public float deleteTime = 15f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deleteTime);
    }
    void OnDestroy() {
		Debug.Log("OnDestroy");
        GameObject.FindObjectOfType<CookieGenerator>().countdown();

	}

}
