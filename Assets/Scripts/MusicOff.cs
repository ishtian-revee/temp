using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOff : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GameObject mMusic = GameObject.Find("MenuMusic");

        if (mMusic != null)
        {
            AudioSource mAudio = mMusic.GetComponent<AudioSource>();
            if (mAudio != null)
            {
                // Mute the Audio
                mAudio.mute = true;
            }
        }
	}
}
