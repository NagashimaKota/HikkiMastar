using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour {

    public AudioClip[] audio;
    private AudioSource play;

    // Use this for initialization
	void Start () {
        play = GetComponent<AudioSource>();
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
        play.clip = audio[0];
        play.Play();
        SceneManager.LoadScene("GameScene");
    }

    public void SelectScene()
    {
        SceneManager.LoadScene("SelectScene");
    }

    public void EndGame()
    {
        play.clip = audio[1];
        play.Play();
        Application.Quit();
    }
}
