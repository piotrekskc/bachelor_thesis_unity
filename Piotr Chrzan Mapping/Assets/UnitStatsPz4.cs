using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStatsPz4 : MonoBehaviour {
    public double HP=100;
    public double AttackRange=5;
    public float MovementRange=3;
    public double AttackStrength=10;
    public double Defence=5;
    public double DefenceFactor=0;
    public double FrontArmour=5;
    public double SideArmour=3;
    public double BackArmour=1;

    public bool isChoosen = false;
    public bool isDead = false;
    public bool nonActive = false;

    public GameObject Unit;
    public GameObject AreaofMov;
    public GameObject AreaofAttack;

    public Transform UnitTrans;
    
    public void DrawAreaofMove()
    {
        float xpos = Unit.transform.position.x;
        float ypos = Unit.transform.position.y;
        float zpos = Unit.transform.position.z;

      
        var myArea = Instantiate(AreaofMov, new Vector3(xpos, ypos, zpos), Quaternion.identity);
        myArea.transform.parent = gameObject.transform;

    }
   
   


    // Use this for initialization
    void Start () {
       
    }
   
    
    // Update is called once per frame
    void Update () {
        
    }
    
    }
