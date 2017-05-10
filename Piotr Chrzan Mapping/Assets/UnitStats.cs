using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitStats : MonoBehaviour {
    public bool IsChoosen = false;
    public bool IsDead = false;
    public bool NonActive = false;

    

    public float AttackFactor = 1;
    public float AttackRange;
    public float AttackStrength = 10;
    public float BraceFactor = 0;
    public float Defence = 5;
    public float DefenceFactor = 1;
    public float DistToTank;
    public float DistToInfantry;
    public float HP = 100;
    public float MovementRange = 3;
    public float RunningFactor;

    public Button AttackEnemyTankButton;
    public Button AttackEnemyInfantryButton;
    public Button BraceButton;
    public Button DigInButton;
    public Button NextTurnButton;
    public Button RunButton;

    public GameObject AreaofMov;
    public GameObject AreaofAttack;
    public GameObject EnemyUnitInfantry;
    public GameObject EnemyUnitTank;
    public GameObject YourUnitModel;

    public Image HealthBar;

    public Text HealthbarText;

    public UnitStats EnemyInfantry;
    public UnitStats EnemyTank;

    public void AttackDistanceCalculation()
    {
        DistToTank = Vector3.Distance(YourUnitModel.transform.position, EnemyUnitTank.transform.position);
        DistToInfantry = Vector3.Distance(YourUnitModel.transform.position, EnemyUnitInfantry.transform.position);
        float AttRangeRecalculated = AttackRange / 20;

        if (DistToTank < AttRangeRecalculated)
        {
            AttackEnemyTankButton.gameObject.SetActive(true);
        }

        if (DistToInfantry < AttRangeRecalculated)
        {
            AttackEnemyInfantryButton.gameObject.SetActive(true);
        }

        Debug.Log(DistToTank);
        Debug.Log(DistToInfantry);

    }

    public void AttackTankinRange()
    {
        float RedZone = AttackRange / 30;
        float YellowZone = 2 * AttackRange / 30;
        float GreenZone = AttackRange / 10;

        if (DistToTank < RedZone)
        {
            AttackFactor = 5;
            EnemyTank.HP = (EnemyTank.HP + EnemyTank.BraceFactor + (EnemyTank.Defence * EnemyTank.DefenceFactor)) - (AttackFactor * AttackStrength);
        }

        if (DistToTank < YellowZone && DistToInfantry > RedZone)
        {
            AttackFactor = 3;
            EnemyTank.HP = (EnemyTank.HP + EnemyTank.BraceFactor+ (EnemyTank.Defence* EnemyTank.DefenceFactor)) - (AttackFactor * AttackStrength);
        }

        if (DistToTank < GreenZone && DistToInfantry > YellowZone)
        {
            AttackFactor = 1;
            EnemyTank.HP = (EnemyTank.HP + EnemyTank.BraceFactor + (EnemyTank.Defence* EnemyTank.DefenceFactor)) - (AttackFactor * AttackStrength);
        }
    }

    public void AttackInfantryinRange()
    {
        float RedZone = AttackRange / 60;
        float YellowZone = (2 * AttackRange) / 60;
        float GreenZone = AttackRange / 20;

        // TODO Usunac Logi
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
            EnemyInfantry.HP = (EnemyInfantry.HP+EnemyInfantry.BraceFactor+(EnemyInfantry.Defence*EnemyInfantry.DefenceFactor)) - (AttackFactor * AttackStrength);
        }

        if (DistToInfantry < YellowZone && DistToInfantry > RedZone)
        {
            AttackFactor = 3;
            EnemyInfantry.HP = (EnemyInfantry.HP + EnemyInfantry.BraceFactor + (EnemyInfantry.Defence * EnemyInfantry.DefenceFactor)) - (AttackFactor * AttackStrength);

        }

        if (DistToInfantry < GreenZone && DistToInfantry > YellowZone)
        {
            AttackFactor = 1;
            EnemyInfantry.HP = (EnemyInfantry.HP + EnemyInfantry.BraceFactor + (EnemyInfantry.Defence * EnemyInfantry.DefenceFactor)) - (AttackFactor * AttackStrength);
        }
    }

    public void BraceChange()
    {
        BraceFactor += 10;
    }


    public void DigInAction()
    {
        DefenceFactor += 1;
    }

    public void DrawAreaofMove()
    {
        float XPos = YourUnitModel.transform.position.x;
        float YPos = YourUnitModel.transform.position.y;
        float ZPos = YourUnitModel.transform.position.z;
        var MyPos = Instantiate(AreaofMov, new Vector3(XPos, 0.1f, ZPos), Quaternion.Euler(90, 0, 0));
        
        MyPos.gameObject.tag = "areas";
        MyPos.transform.localScale = new Vector3(MyPos.transform.localScale.x * MovementRange, MyPos.transform.localScale.y * MovementRange, MyPos.transform.localScale.z * MovementRange);
    }

    public void DrawAreaofAttack()
    {
        float XPos = YourUnitModel.transform.position.x;
        float YPos = YourUnitModel.transform.position.y;
        float ZPos = YourUnitModel.transform.position.z;
        var MyPos = Instantiate(AreaofAttack, new Vector3(XPos, 0.1f, ZPos), Quaternion.Euler(90, 0, 0)) as GameObject;
        
        MyPos.gameObject.tag = "areas";
        MyPos.transform.localScale = new Vector3(MyPos.transform.localScale.x * AttackRange, MyPos.transform.localScale.y * AttackRange, MyPos.transform.localScale.z * AttackRange);
    }
    
    public void DrawAreaofRun()
    {
        float XPos = YourUnitModel.transform.position.x;
        float YPos = YourUnitModel.transform.position.y;
        float ZPos = YourUnitModel.transform.position.z;
        var MyPos = Instantiate(AreaofMov, new Vector3(XPos, 0.1f, ZPos), Quaternion.Euler(90, 0, 0)) as GameObject;

        MyPos.gameObject.tag = "areas";
        float FactoredRunRange = MovementRange * RunningFactor;
        MyPos.transform.localScale = new Vector3(MyPos.transform.localScale.x * FactoredRunRange, MyPos.transform.localScale.y * FactoredRunRange, MyPos.transform.localScale.z * FactoredRunRange);
    }

    void DestroyMyPos()
    {
        GameObject[] areas = GameObject.FindGameObjectsWithTag("areas");
        for (var i = 0; i < areas.Length; i++)
        {
            Destroy(areas[i]);
        }
    }

    

    // Use this for initialization
    void Start()
    {
        Button DestructionAreasButton = NextTurnButton.GetComponent<Button>();
        NextTurnButton.onClick.AddListener(DestroyMyPos);

        Button attackTank = AttackEnemyTankButton.GetComponent<Button>();
        AttackEnemyTankButton.onClick.AddListener(AttackTankinRange);

        Button attackInfantry = AttackEnemyInfantryButton.GetComponent<Button>();
        AttackEnemyInfantryButton.onClick.AddListener(AttackInfantryinRange);

        Button UnitRun = RunButton.GetComponent<Button>();
        RunButton.onClick.AddListener(DrawAreaofRun);

        Button UnitBrace = BraceButton.GetComponent<Button>();
        BraceButton.onClick.AddListener(BraceChange);

        Button UnitDigIn = DigInButton.GetComponent<Button>();
        DigInButton.onClick.AddListener(DigInAction);
    }

    // Update is called once per frame
    void Update()
    {
        float HealtBarValue = HP / 100;
        HealthBar.fillAmount = HealtBarValue;
        HealthbarText.text = "HP" + HP;
    }
}
