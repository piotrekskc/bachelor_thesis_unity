using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunRangeButton : MonoBehaviour {
    public UnitStats UnitRun;
    public Button RunButton;
    // Use this for initialization
    void Start () {
        Button RunDraw = RunButton.GetComponent<Button>();
        RunButton.onClick.AddListener(UnitRun.DrawAreaofRun);
    }
	
}
