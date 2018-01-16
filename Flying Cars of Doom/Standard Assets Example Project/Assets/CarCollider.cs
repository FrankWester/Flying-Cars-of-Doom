using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollider : MonoBehaviour {

    [SerializeField]
    GameObject deer;
    bool colliderTriggered = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(colliderTriggered == true)
        {
            deer.transform.Translate(0, 0, 0.1f);
        }
        if(deer.transform.position.z > -150 && colliderTriggered == true)
        {
            colliderTriggered = false;
            deer.transform.position = new Vector3(-6, 0, -170);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        colliderTriggered = true;
    }
}
