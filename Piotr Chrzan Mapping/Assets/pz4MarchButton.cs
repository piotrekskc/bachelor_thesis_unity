using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pz4MarchButton : MonoBehaviour {

    public UnitStatsTank movement;
    public Button MarchButton;
    // Use this for initialization
    void Start () {
        Button dstr = MarchButton.GetComponent<Button>();
        MarchButton.onClick.AddListener(movement.DrawAreaofMove); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
