using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Speedometer : MonoBehaviour {

    [SerializeField] CarController _carController;
    [SerializeField] Text _speedometer;

    float _speed; //kph

	void Update ()
    {
        _speed = _carController.currentSpeed;
        _speedometer.text = Mathf.Round(_speed).ToString();
    }
}
