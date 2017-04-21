using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panzer4position : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public GameObject markerpz4;
    public GameObject modelpz4;
    // Update is called once per frame
    void Update () {

        var pos = markerpz4.transform.position;
       
        modelpz4.transform.position = new Vector3(pos.x, 0.01f, pos.z);
    }
}
