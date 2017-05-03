using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVolume : MonoBehaviour {
    public float curVolume;
    public Slider audioValue;
    public Toggle audioSwitch;

    private static GlobalVolume instance = null;
    public static GlobalVolume Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

        curVolume = gameObject.GetComponent<AudioSource>().volume;
    }

    public void VolumeSwitch()
    {
        if (audioSwitch.isOn)
        {
            gameObject.GetComponent<AudioSource>().volume = curVolume;
        }
        if (!audioSwitch.isOn)
        {
            gameObject.GetComponent<AudioSource>().volume = 0;
        }
    }

    public void VolumeInput()
    {
        gameObject.GetComponent<AudioSource>().volume = audioValue.value;
    }

}
