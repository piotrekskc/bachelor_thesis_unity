using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersTurn : MonoBehaviour {
    public Button NextTurnButton;

    bool GermanPlayerTurn=true;

    public GameObject AmericanSoldierCommand;
    public GameObject GermanSoldierCommand;
    public GameObject Panzer4Command;
    public GameObject ShermanCommand;
    

    public UnitStats AmericanSoldierStats;
    public UnitStats GermanSoldierStats;
    public UnitStats Panzer4Stats;
    public UnitStats ShermanStats;

    public void BraceFactorReset()
    {
        if (GermanPlayerTurn == false)
        {
            AmericanSoldierStats.BraceFactor = 0;
            ShermanStats.BraceFactor = 0;
        }
        if (GermanPlayerTurn == true)
        {
            GermanSoldierStats.BraceFactor = 0;
            Panzer4Stats.BraceFactor = 0;
        }
    }
    
    public void DigInChangeState()
    {
        if (GermanPlayerTurn == false)
        {
            AmericanSoldierStats.DefenceFactor = 1;
            ShermanStats.DefenceFactor = 1;
        }
        if (GermanPlayerTurn == true)
        {
            Panzer4Stats.DefenceFactor = 1;
            GermanSoldierStats.DefenceFactor = 1;
        }

    }
  

    public void EndTurn()
    {
        if (GermanPlayerTurn==true)
        {
            GermanPlayerTurn = false;
        }
        else
        {
            GermanPlayerTurn = true;
        }
    }
    


	// Use this for initialization
	void Start () {
        Button NextTurn = NextTurnButton.GetComponent<Button>();
        NextTurnButton.onClick.AddListener(EndTurn);
        NextTurnButton.onClick.AddListener(BraceFactorReset);
        
        NextTurnButton.onClick.AddListener(DigInChangeState);
        
    }
	
	// Update is called once per frame
	void Update () {
		if(GermanPlayerTurn==true)
        {
            AmericanSoldierCommand.SetActive(false);
            ShermanCommand.SetActive(false);
            Panzer4Command.SetActive(true);
            GermanSoldierCommand.SetActive(true);
            
        }
        if (GermanPlayerTurn == false)
        {
            AmericanSoldierCommand.SetActive(true);
            ShermanCommand.SetActive(true);
            Panzer4Command.SetActive(false);
            GermanSoldierCommand.SetActive(false);
            
        }
    }
}
