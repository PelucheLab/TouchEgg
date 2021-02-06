using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Graphic))]
public class CookieGenerator : MonoBehaviour
{
    [SerializeField] GameObject prefab = null;
    public GameObject canvas;
    RectTransform  myRectTrans;
    RectTransform  parentRectTrans;
    AudioSource audioSource;
    public AudioClip sound1;
    int count = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(sound1);
            Vector3 position = Input.mousePosition;
            var graphic = GetComponent<Graphic>();

            GameObject Cookie = Instantiate(prefab, transform) as GameObject;
            Cookie.transform.SetParent (canvas.transform,false); 
            myRectTrans = Cookie.GetComponent<RectTransform>();
            parentRectTrans = (RectTransform) myRectTrans.parent;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTrans, position, null, out Vector2 localPoint);
            Cookie.transform.localPosition = localPoint;
            Debug.Log("Cookie.transform.position=" + Cookie.transform.position);
            count++;

        }

    }


    public int returncount(){
        return count;
    }
    public void countdown(){
        count--;
    }

}
