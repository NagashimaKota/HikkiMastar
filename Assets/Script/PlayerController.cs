using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject firePrefab;
    public GameObject icePrefab;

    private GameObject fire;
    private GameObject ice;

    private float leftPosition = -1.0f;
    private float rightPosition = 1.5f;
    private float[] attackOffset = { -0.05f, 0.4f};
    private int screenWidth = Screen.width / 2;
    

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow) )
        {
            this.transform.position = new Vector2( leftPosition, this.transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position = new Vector2(rightPosition, this.transform.position.y);
        }

        if(Input.touchCount > 0)
        {
            Touch mytouch = Input.touches[0];

            if(mytouch.position.x <= screenWidth)
            {
                this.transform.position = new Vector2(leftPosition, this.transform.position.y);
            }
            else
            {
                this.transform.position = new Vector2(rightPosition, this.transform.position.y);
            }
        }


        if (Input.GetKeyDown(KeyCode.Z))
        {
            fire = Instantiate(firePrefab) as GameObject;
            fire.transform.position = new Vector2( this.transform.position.x + attackOffset[0], this.transform.position.y + attackOffset[1]);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            ice = Instantiate(icePrefab) as GameObject;
            ice.transform.position = new Vector2(this.transform.position.x + attackOffset[0], this.transform.position.y + attackOffset[1]);
        }
	}
}
