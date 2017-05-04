using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitStatsTank : MonoBehaviour {

    public float HP = 1;
   
    public Image HealthBar;
    public float AttackRange;
    public float MovementRange = 3;
    public float AttackStrength = 10;
    public float AttackFactor = 1;
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

    public GameObject YourUnitModel;
    public GameObject EnemyUnitTank;
    public GameObject EnemyUnitInfantry;

    public Button AttackEnemyTankButton;
    public Button AttackEnemyInfantryButton;

    public Transform UnitTrans;
    public Button NextTurnButton;
    float DistToTank;
    float DistToInfantry;
    public void AttackDistanceCalculation()
    {
        DistToTank = Vector3.Distance(YourUnitModel.transform.position, EnemyUnitTank.transform.position);
        DistToInfantry = Vector3.Distance(YourUnitModel.transform.position, EnemyUnitInfantry.transform.position);
        float AttRangeRecalculated = AttackRange / 20;
        if (DistToTank< AttRangeRecalculated)
        {
            AttackEnemyTankButton.gameObject.SetActive(true);
        }
        if(DistToInfantry< AttRangeRecalculated)
        {
            AttackEnemyInfantryButton.gameObject.SetActive(true);
        }

        Debug.Log(DistToTank);
        Debug.Log(DistToInfantry);
        
    }

    public UnitStatsTank EnemyTank;
    public UnitStatsTank EnemyInfantry;



    public void AttackTankinRange()
    {
        float RedZone = AttackRange / 30;
        float YellowZone = 2 * AttackRange / 30;
        float GreenZone = AttackRange/10;

        if (DistToTank < RedZone)
        {
            AttackFactor = 5;
        }
        if (DistToTank < YellowZone && DistToInfantry > RedZone)
        {
            AttackFactor = 3;
        }
        if (DistToTank < GreenZone && DistToInfantry > YellowZone)
        {
            AttackFactor = 1;
        }
    }
    public void AttackInfantryinRange()
    {
        float RedZone = AttackRange / 60;
        float YellowZone = (2 * AttackRange) / 60;
        float GreenZone = AttackRange / 20;
        Debug.Log(DistToInfantry);
        Debug.Log("RedZone");
        Debug.Log(RedZone);
        Debug.Log("YellowZone");
        Debug.Log(YellowZone);
        Debug.Log("GreenZone");
        Debug.Log(GreenZone);
        if (DistToInfantry < RedZone)
        {
            AttackFactor = 5;
            EnemyInfantry.HP = EnemyInfantry.HP - AttackFactor * AttackStrength;
        }
        if (DistToInfantry < YellowZone && DistToInfantry > RedZone )
        {
            AttackFactor = 3;

        }
        if (DistToInfantry < GreenZone && DistToInfantry > YellowZone)
        {
            AttackFactor = 1;
        }
    }
    public void DealDamage(float AttackFactor, float AttackStrength, float DefenceFactor, float Defence)
    {
        
    }
    public void DrawAreaofMove()
    {
        float xpos = Unit.transform.position.x;
        float ypos = Unit.transform.position.y;
        float zpos = Unit.transform.position.z;


        var myArea = Instantiate(AreaofMov, new Vector3(xpos, 0.1f, zpos), Quaternion.Euler(90,0,0));
        // myArea.transform.parent = gameObject.transform;
        myArea.gameObject.tag = "areas";
        myArea.transform.localScale = new Vector3(myArea.transform.localScale.x * MovementRange, myArea.transform.localScale.y * MovementRange, myArea.transform.localScale.z * MovementRange);
        
    }
    public void DrawAreaofAttack()
    {
        float xpos = Unit.transform.position.x;
        float ypos = Unit.transform.position.y;
        float zpos = Unit.transform.position.z;
       
            var myArea = Instantiate(AreaofAttack, new Vector3(xpos, 0.1f, zpos), Quaternion.Euler(90, 0, 0)) as GameObject;
      
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
        Button attackTank = AttackEnemyTankButton.GetComponent<Button>();
        AttackEnemyTankButton.onClick.AddListener(AttackTankinRange);
        Button attackInfantry = AttackEnemyTankButton.GetComponent<Button>();
        AttackEnemyInfantryButton.onClick.AddListener(AttackInfantryinRange);

    }
	
	// Update is called once per frame
	void Update () {
        HealthBar.fillAmount = HP;
	}
}
