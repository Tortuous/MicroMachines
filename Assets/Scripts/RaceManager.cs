using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RaceManager : MonoBehaviour {
    public Car[] allCars;
    public Car[] carOrder;
    public Text pos1UI;
    public Text pos2UI;

    void Start() {
        carOrder = new Car[allCars.Length];
        InvokeRepeating("ManualUpdate", 0.5f, 0.5f);

        allCars[0].name = "Car 1";
        allCars[1].name = "Car 2";
    }

    private void Update() {
        if(carOrder[0] == allCars[0]){
            pos1UI.text = "First";
            pos2UI.text = "Second";
        } else {
            pos1UI.text = "Second";
            pos2UI.text = "First";
        }
    }

    void ManualUpdate() {
        foreach (Car car in allCars) {
            carOrder[car.GetCarPosition(allCars) - 1] = car;
        }
    }
}