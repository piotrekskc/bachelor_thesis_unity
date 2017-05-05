using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarchRangeButton : MonoBehaviour {

    public UnitStats MovementArea;
    public Button MarchButton;
    // Use this for initialization
    void Start () {
        Button SetMarch = MarchButton.GetComponent<Button>();
        MarchButton.onClick.AddListener(MovementArea.DrawAreaofMove); 
	}
	
	
	
}
