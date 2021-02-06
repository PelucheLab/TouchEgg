using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Egg : MonoBehaviour
{
    [SerializeField] Sprite HiyokoEgg = null;
    [SerializeField] Sprite Hiyoko = null;
    
    AudioSource audioSource;
    public AudioClip sound1;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5.0f){
            Destroy(this.gameObject);
        }
    }

    public void Touch()
    {
        StartCoroutine(Matteru());
		audioSource.PlayOneShot(sound1);
    }

	IEnumerator Matteru() 
    {
        this.GetComponent<Image>().sprite = HiyokoEgg;
		yield return new WaitForSeconds(0.2f);
        this.GetComponent<Image>().sprite = Hiyoko;
    }

}
