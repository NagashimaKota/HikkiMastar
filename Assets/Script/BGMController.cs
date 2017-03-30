using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour {

    public AudioClip[] bgm;
    private AudioSource audio;

    // Use this for initialization
	void Start () {
        
        int num = Random.Range(0, bgm.Length);

        this.audio = GetComponent<AudioSource>();
        this.audio.clip = bgm[num];
        this.audio.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
