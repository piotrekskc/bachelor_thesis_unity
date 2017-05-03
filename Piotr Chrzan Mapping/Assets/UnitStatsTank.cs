using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitStatsTank : MonoBehaviour {

    public double HP = 100;
    public float AttackRange = 5;
    public float MovementRange = 3;
    public double AttackStrength = 10;
    public double Defence = 5;
    public double DefenceFactor = 0;
    public double FrontArmour = 5;
    public double SideArmour = 3;
    public double BackArmour = 1;

    public bool isChoosen = false;
    public bool isDead = false;
    public bool nonActive = false;

    public GameObject Unit;
    public GameObject AreaofMov;
    public GameObject AreaofAttack;
    
    

    public Transform UnitTrans;
    public Button NextTurnButton;


    public void DrawAreaofMove()
    {
        float xpos = Unit.transform.position.x;
        float ypos = Unit.transform.position.y;
        float zpos = Unit.transform.position.z;


        var myArea = Instantiate(AreaofMov, new Vector3(xpos, ypos, zpos), Quaternion.Euler(90,0,0));
        // myArea.transform.parent = gameObject.transform;
        myArea.gameObject.tag = "areas";
        myArea.transform.localScale = new Vector3(myArea.transform.localScale.x * MovementRange, myArea.transform.localScale.y * MovementRange, myArea.transform.localScale.z * MovementRange);
    }
    public void DrawAreaofAttack()
    {
        float xpos = Unit.transform.position.x;
        float ypos = Unit.transform.position.y;
        float zpos = Unit.transform.position.z;
       
            var myArea = Instantiate(AreaofAttack, new Vector3(xpos, ypos, zpos), Quaternion.Euler(90, 0, 0)) as GameObject;
      
        // myArea.transform.parent = gameObject.transform;
        
        myArea.gameObject.tag = "areas";
        myArea.transform.localScale = new Vector3(myArea.transform.localScale.x * AttackRange, myArea.transform.localScale.y * AttackRange, myArea.transform.localScale.z * AttackRange);
    }
   
    void DestroyMyArea()
    {
        GameObject[] areas = GameObject.FindGameObjectsWithTag("areas");
        for (var i = 0; i < areas.Length; i++)
        {
            Destroy(areas[i]);
        }
    }
    // Use this for initialization
    void Start () {
        Button dstr = NextTurnButton.GetComponent<Button>();
        NextTurnButton.onClick.AddListener(DestroyMyArea);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
