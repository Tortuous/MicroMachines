using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Car : MonoBehaviour {
    public int currentWaypoint;
    public int currentLap;
    public int nbWaypoint; // nb = number of
    public Transform lastWaypoint;
    public GameObject uiLap;

    private static int WAYPOINT_VALUE = 100;
    private static int LAP_VALUE = 10000;
    private int cpt_waypoint = 0;

    // Use this for initialization
    public void Initialize() {
        currentWaypoint = 0;
        currentLap = 0;
        cpt_waypoint = 0;
    }

    public void Update() {
        uiLap.GetComponent<Text>().text = currentLap.ToString();
    }

    public void OnTriggerEnter(Collider other) {
        string otherTag = other.gameObject.tag;
        currentWaypoint = System.Convert.ToInt32(otherTag);
        if (currentWaypoint == 1 && cpt_waypoint == nbWaypoint) {
            currentLap++;
            cpt_waypoint = 0;
        }
        if (cpt_waypoint == currentWaypoint - 1) {
            lastWaypoint = other.transform;
            cpt_waypoint++;
        }
    }

    public float GetDistance() {
        return (transform.position - lastWaypoint.position).magnitude + currentWaypoint * WAYPOINT_VALUE + currentLap * LAP_VALUE;
    }

    public int GetCarPosition(Car[] allCars) {
        float distance = GetDistance();
        int position = 1;
        foreach (Car car in allCars) {
            if (car.GetDistance() > distance)
                position++;
        }
        return position;
    }
}