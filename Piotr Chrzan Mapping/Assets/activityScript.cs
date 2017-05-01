using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activityScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject shermanIcon;
    public GameObject PanelSherman;
    public GameObject pz4icon;
    public GameObject panelpz4;
    public GameObject ussoldiericon;
    public GameObject panelussoldier;
    public GameObject gersoldiericon;
    public GameObject panelgersoldier;
    // Update is called once per frame
    void Update () {


		if(shermanIcon.activeSelf)
        {
            PanelSherman.SetActive(false);
        }
        if (pz4icon.activeSelf)
        {
            panelpz4.SetActive(false);
        }
        if (ussoldiericon.activeSelf)
        {
            panelussoldier.SetActive(false);
        }
        if (gersoldiericon.activeSelf)
        {
            panelgersoldier.SetActive(false);
        }
    }
}
