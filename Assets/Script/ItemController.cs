using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

    public GameObject tilePrefab;

    private float speed = -0.05f;
    private float startLine = 8.0f;
    private float deadLine = -6.0f;

    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0, speed, 0);
	}
}
