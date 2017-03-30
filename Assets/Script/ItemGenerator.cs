using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

    public GameObject baketuPrefab;
    public GameObject deskPrefab;
    public GameObject hartPrefab;

    private GameObject baketu;
    private GameObject desk;
    private GameObject hart;

    private bool baketuLive = false;
    private bool deskLive = false;
    private bool hartLive = false;

    private float[] positionX = { -1.3f, 1.7f};
    private float[] positionY = { 10f, 12f, 14f, 16f, 18f};
    private int numX;
    private int numY;

    // Use this for initialization
    void Start () {

        ItemGenerat();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag != "Tile")
        {
            switch (collider.gameObject.tag) {
                case "Baketu":
                    baketuLive = false;
                    break;

                case "Desk":
                    deskLive = false;
                    break;

                case "Hart":
                    hartLive = false;
                    break;
            }

            Destroy(collider.gameObject);
            ItemGenerat();
        }

    }

    void ItemGenerat()
    {
        
        if (baketuLive == false)
        {
            numX = Random.Range(0, 2);
            numY = Random.Range(0, 5);

            baketu = Instantiate(baketuPrefab) as GameObject;
            baketu.transform.position = new Vector2( positionX[numX], positionY[numY]);
            baketuLive = true;
        }

        if (deskLive == false)
        {
            numX = Random.Range(0, 2);
            numY = Random.Range(0, 5);

            desk = Instantiate(deskPrefab) as GameObject;
            desk.transform.position = new Vector2( positionX[numX], positionY[numY]);
            deskLive = true;
        }

        if(hartLive == false)
        {
            numX = Random.Range(0, 2);
            numY = Random.Range(0, 5);

            hartLive = Instantiate(hartPrefab) as GameObject;
            hartPrefab.transform.position = new Vector2(positionX[numX], positionY[numY]);
            hartLive = true;
        }
    }
    
}
