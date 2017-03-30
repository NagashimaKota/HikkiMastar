using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Title()
    {
        SceneManager.LoadScene("Title");
    }

    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void SelectScene()
    {
        SceneManager.LoadScene("SelectScene");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
