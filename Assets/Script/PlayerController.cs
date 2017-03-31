using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public GameObject firePrefab;
    public GameObject icePrefab;

    private GameObject fire;
    private GameObject ice;

    public Image[] ink;
    private int inkLife = 3;

    private float leftPosition = -1.0f;
    private float rightPosition = 1.5f;
    private float[] attackOffset = { -0.05f, 0.4f};
    private int screenWidth = Screen.width / 2;
    
    
    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {


        //入力のデバッグ用
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
            Vector2 newVec = new Vector2(mytouch.position.x, Screen.height - mytouch.position.y);

            if(mytouch.position.x <= screenWidth)
            {
                this.transform.position = new Vector2(leftPosition, this.transform.position.y);
            }
            else if(mytouch.position.x > screenWidth)
            {
                this.transform.position = new Vector2(rightPosition, this.transform.position.y);
            }
        }
        

        if (Input.GetKeyDown(KeyCode.Z))
        {
            FireGenerator();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            IceGenerator();
        }
	}

    public　void FireGenerator()
    {
        fire = Instantiate(firePrefab) as GameObject;
        fire.transform.position = new Vector2(this.transform.position.x + attackOffset[0], this.transform.position.y + attackOffset[1]);
    }

    public void IceGenerator()
    {
        ice = Instantiate(icePrefab) as GameObject;
        ice.transform.position = new Vector2(this.transform.position.x + attackOffset[0], this.transform.position.y + attackOffset[1]);
    }

    void OnTriggerEnter2D(Collider2D item)
    {
        if (item.tag == "Baketu" || item.tag == "Desk")
        {
            ink[inkLife].enabled = false;
            if(inkLife > 0) inkLife--;
        }

        if (item.tag == "Hart")
        {
            ink[inkLife].enabled = true;
            if (inkLife < ink.Length - 1) inkLife++;
            item.transform.position = new Vector2( this.transform.position.x, -1.5f);
        }
    }
}
