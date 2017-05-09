using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPosition : MonoBehaviour {
    public float EndOfMapX= 0.7056f;
    public float EndOfMapZ = 0.7056f;
    // Use this for initialization
    void Start () {
		
	}

    public GameObject MyMarker;
    public GameObject MyModel;
    void Update () {

        var pos = MyMarker.transform.position;
       
        float xpos = pos.x / EndOfMapX;
        float zpos = pos.z / EndOfMapZ;
        var Marker = MyMarker.transform.rotation;
        var Model = MyModel.transform.rotation;
        MyModel.transform.position = new Vector3(xpos, 0.01f, zpos);
        MyModel.transform.rotation = new Quaternion(Model.x, Marker.y, Model.z, Model.w);
    }
}
