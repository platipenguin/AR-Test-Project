using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBehavior : MonoBehaviour {

    public Material baseMaterial;
    public Material closeMaterial;
    public CloseBehavior other;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material = baseMaterial;
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, other.transform.position) < 5)
        {
            GetComponent<Renderer>().material = closeMaterial;
        }
        else
        {
            GetComponent<Renderer>().material = baseMaterial;
        }
	}
}
