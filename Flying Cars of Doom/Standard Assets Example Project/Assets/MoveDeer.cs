using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDeer : MonoBehaviour {

    public GameObject deer;
    public GameObject target;
    bool movement = false;
    public GameObject deerStart;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(movement == true)
        {
            deer.transform.position = Vector3.MoveTowards(deer.transform.position, target.transform.position, 10 * Time.deltaTime);
        }if (deer.transform.position.x > 30 || movement == false)
        {
            movement = false;
            deer.transform.position = Vector3.MoveTowards(deer.transform.position, deerStart.transform.position, 10 * Time.deltaTime);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
        movement = true;

    }
}
