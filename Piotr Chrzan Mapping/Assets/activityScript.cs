using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activityScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject shermanIcon;
    public GameObject PanelSherman;
	// Update is called once per frame
	void Update () {


		if(shermanIcon.activeSelf)
        {
            PanelSherman.SetActive(false);
        }



	}
}
