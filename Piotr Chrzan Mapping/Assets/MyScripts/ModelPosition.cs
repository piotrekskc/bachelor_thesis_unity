using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public GameObject marker;
    public GameObject model;
    //public GameObject Rcorner;
    // Update is called once per frame
    void Update () {

        var pos = marker.transform.position;
       // var cornerPos = Rcorner.transform.position;
        
        var rot = marker.transform.rotation;
        var rotm = model.transform.rotation;
        model.transform.position = new Vector3(marker.transform.position.x, 0.01f, marker.transform.position.z);
        model.transform.rotation = new Quaternion(rotm.x, rot.y, rotm.z,rotm.w);
    }
}
