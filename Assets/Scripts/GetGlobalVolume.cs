using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGlobalVolume : MonoBehaviour {
    
    private float globalVolume;
    public void Update()
    {
        gameObject.GetComponent<AudioSource>().volume = SetGlobalVolume.curVolume;
    }
}
