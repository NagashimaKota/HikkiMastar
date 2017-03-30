using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private float leftPosition = -1.0f;
    private float rightPosition = 1.5f;
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
		
	}
}
