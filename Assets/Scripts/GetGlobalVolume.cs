using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGlobalVolume : MonoBehaviour {
    
    private float globalVolume;
    public void Update()
    {
        globalVolume = PlayerPrefs.GetFloat("GlobalVolume");
        gameObject.GetComponent<AudioSource>().volume = globalVolume;
    }
}
