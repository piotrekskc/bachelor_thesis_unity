using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackRangeButton : MonoBehaviour {
    public UnitStats UnitAttack;
    public Button AttackButton;
   
    // Use this for initialization
    void Start()
    {
       Button dstr =  AttackButton.GetComponent<Button>();
        AttackButton.onClick.AddListener(UnitAttack.DrawAreaofAttack);
        AttackButton.onClick.AddListener(UnitAttack.AttackDistanceCalculation);
    }
	
	

}
