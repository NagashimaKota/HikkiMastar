using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public GameObject tilePrefab;

    private GameObject tile;

    // Use this for initialization
	void Start () {

        for (float i = -4; i <= 12; i += 2)
        {
            for (float j = -3; j <= 3; j += 1.5f)
            {
                tile = Instantiate(tilePrefab) as GameObject;
                tile.transform.position = new Vector2( j, i);
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Tile")
        {
            collider.transform.position = new Vector2( collider.transform.position.x, 12);
        }
    }
}
