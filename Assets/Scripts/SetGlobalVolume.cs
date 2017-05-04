using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetGlobalVolume : MonoBehaviour {
    public static float curVolume = 1.0f;

    public void Update()
    {
        curVolume = gameObject.GetComponent<Slider>().value;
    }

    public void OnLevelWasLoaded(int level)
    {
        gameObject.GetComponent<Slider>().value = curVolume;
    }
}