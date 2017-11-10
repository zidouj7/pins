using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterRotator : MonoBehaviour {

    public float outSpeed = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0f, 0f, outSpeed * Time.deltaTime);

    }
}
