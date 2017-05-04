using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetGlobalVolume : MonoBehaviour {
    public float curVolume;

    public void Update()
    {
        curVolume = gameObject.GetComponent<Slider>().value;
    }
    public void VolumeInput()
    {
        PlayerPrefs.SetFloat("GlobalVolume", curVolume);
    }
    public void Awake()
    {
        curVolume = PlayerPrefs.GetFloat("GlobalVolume");
    }
}