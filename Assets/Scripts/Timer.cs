using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private float elapsedTime;
    public float timer;
    public string timerFormatted;

    void Update() {
        elapsedTime += Time.deltaTime;
        System.TimeSpan t = System.TimeSpan.FromSeconds(elapsedTime);
        timerFormatted = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Minutes, t.Seconds, t.Milliseconds);
        gameObject.GetComponent<Text>().text = "Elapsed Time: " +  timerFormatted;
    }
}