using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarchRangeButton : MonoBehaviour {

    public UnitStats movement;
    public Button MarchButton;
    // Use this for initialization
    void Start () {
        Button dstr = MarchButton.GetComponent<Button>();
        MarchButton.onClick.AddListener(movement.DrawAreaofMove); 
	}
	
	
	
}
