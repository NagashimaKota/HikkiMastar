using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour {

    private float[] afterOffSet = { -0.17f, -0.29f };
    private float speed = 0.1f;

    public GameObject effectPrefab;
    public GameObject afterObjectPrefab;
    private GameObject effect;
    private GameObject afterObject;

    private Vector2 itemPosition;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0, speed, 0);

        if (this.transform.position.y >= 5.5)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D item)
    {
        if (item.tag == this.tag && item.tag == "Desk")
        {
            
            itemPosition = item.transform.position;
            Destroy(gameObject);

            item.transform.position = new Vector2(this.transform.position.x, -1.5f);
            
            effect = Instantiate(effectPrefab);
            effect.transform.position = itemPosition;

            //afterObject = Instantiate(afterObjectPrefab);
            //afterObject.transform.position = itemPosition;

            Destroy(effect, 0.5f);
            
        }

        if(item.tag == this.tag && item.tag == "Baketu")
        {
            itemPosition = item.transform.position;
            Destroy(gameObject);
            
            effect = Instantiate(effectPrefab);
            effect.transform.position = itemPosition;

            afterObject = Instantiate(afterObjectPrefab);
            afterObjectPrefab.transform.position = itemPosition;

            item.transform.position = new Vector2(this.transform.position.x, -1.5f);
            Destroy(effect, 0.5f);
        }


    }

}
