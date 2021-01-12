using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggGenerator : MonoBehaviour
{

    [SerializeField] GameObject prefab = null;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(Generate());
    }

	IEnumerator Generate() {
		yield return new WaitForSeconds(1.5f);
        GameObject Egg = Instantiate(prefab, transform) as GameObject;
        Egg.transform.position = new Vector3(-200.0f, 0.0f, 0);
        Egg.transform.SetParent (canvas.transform, false); 
        Rigidbody2D rb = Egg.GetComponent<Rigidbody2D> ();  // rigidbodyを取得
        Vector2 force = new Vector2 (10.0f,0.0f);    // 力を設定
        rb.AddForce(Vector2.left * -30.0f, ForceMode2D.Impulse);
		StartCoroutine(Generate());

    }
    // Update is called once per frame
    void Update()
    {

    
    }
}
