using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackSelect : MonoBehaviour {
    public Button trackButton1;
    public Button trackButton2;
    public GameObject track1;
    public GameObject track2;

	// Use this for initialization
	void Start ()
    {
        Button btn1 = trackButton1.GetComponent<Button>();
        Button btn2 = trackButton2.GetComponent<Button>();
        btn1.onClick.AddListener(trackSelect1);
        btn2.onClick.AddListener(trackSelect2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void trackSelect1()
    {
        track1.SetActive(true);
        track2.SetActive(false);
    }

    void trackSelect2()
    {
        track1.SetActive(false);
        track2.SetActive(true);
    }
}
