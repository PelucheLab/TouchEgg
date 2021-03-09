using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemgenerator : MonoBehaviour
{
    Dictionary<string, string> KasanariList = new Dictionary<string, string>();
    Dictionary<int, string> OiteiiList = new Dictionary<int, string>();
    Dictionary<string, Vector2> OiteiiListpos = new Dictionary<string, Vector2>();
    [SerializeField] GameObject[] prefab = null;
    RectTransform  myRectTrans;
    RectTransform  parentRectTrans;
    public GameObject canvas;
    public GameObject canvas2;
    float countTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
        countTime += Time.deltaTime;
        if(countTime > 30){
            Debug.Log("timeroff");
            SelectHappa();
            countTime = 0;
        }
    }

    public void Addkasanari(string happa){
        KasanariList[happa] = happa;
        Debug.Log("重なりリストに追加" + happa);

    }
    // Update is called once per frame
	public void SelectHappa(){
        Debug.Log("SelectHappa");

        int i = 0;
		foreach(Transform child in canvas.transform) {
            int check = 0;
            foreach (var key in KasanariList.Keys) {
                Debug.Log("重なりリストの内容" + key);
			    if(child.name == key){
                    check = 1;
			    }
            }
            if(check == 0){
                Debug.Log("フンを置く葉っぱ" + child.name);
                OiteiiList[i] = child.name;
                OiteiiListpos[child.name] = child.position;
                i++;
            }
		}
        int Youso = OiteiiList.Count;
        if(Youso != 0){
            Debug.Log("フンを置く葉っぱの数" + Youso);
            int r = Random.Range(1,Youso+1);
            //アイテムを置く葉っぱの決定
            Debug.Log("r=" + r);
            GenerateItem(OiteiiList[r]);
        }

	}
    void GenerateItem(string TargetHappa){
        Debug.Log("GenerateItem" + TargetHappa);

        Vector2 pos = OiteiiListpos[TargetHappa];
        int r = Random.Range(0,prefab.Length);
        Debug.Log("r="+r);
        GameObject Item = Instantiate(prefab[r], transform) as GameObject;
        Item.transform.SetParent (canvas2.transform,false); 
        myRectTrans = Item.GetComponent<RectTransform>();
        parentRectTrans = (RectTransform) myRectTrans.parent;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTrans, pos, null, out Vector2 localPoint);
        Item.transform.localPosition = localPoint;
    }
}
