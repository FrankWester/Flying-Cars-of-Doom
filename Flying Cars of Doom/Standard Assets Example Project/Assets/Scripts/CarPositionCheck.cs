using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarPositionCheck : MonoBehaviour {

    [SerializeField] CarController _carController;
    [SerializeField] GameObject _offroadMessageObject;

    /// <summary>
    /// Checks if the car is on the road or not.
    /// </summary>
    /// <returns></returns>
    bool IsCarOnRoad()
    {

        Vector3 carHeightOffset = new Vector3(0, .5f, 0);
        RaycastHit hit;

        Physics.Raycast(transform.position + carHeightOffset, -Vector3.up, out hit);
        
        if(hit.transform.tag == "Road")
        {
            _offroadMessageObject.SetActive(false);

            return true;
        }
        else
        {
             return false;
        }     
    }

    
    void CarIsNotOnRoad()
    {
        //Send Message
        _offroadMessageObject.SetActive(true);
        //Debug.Log("Offroad!");
    }

	
	void Update ()
    {
        if(IsCarOnRoad())
        {
            return;
        }
        else
        {
            CarIsNotOnRoad();
        }
    }
}
