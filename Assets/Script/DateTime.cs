using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateTime : MonoBehaviour {

    private string week = System.DateTime.Today.ToString("ddd");
    private Text dateTime;
    
    
    // Use this for initialization
	void Start () {

        //曜日を決める
        switch (week)
        {
            case "Sun":
                week = "　日曜日";
                break;
            case "Mon":
                week = "　月曜日";
                break;
            case "Tue":
                week = "　火曜日";
                break;
            case "Wed":
                week = "　水曜日";
                break;
            case "Thu":
                week = "　木曜日";
                break;
            case "Fri":
                week = "　金曜日";
                break;
            case "Sat":
                week = "　土曜日";
                break;
        }

        this.dateTime = GetComponent<Text>();
        this.dateTime.text = System.DateTime.Now.Month.ToString() + "月" + System.DateTime.Now.Day.ToString() + "日" + week;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
