using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
    }

	void Update() 
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
	}
}
