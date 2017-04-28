using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelPz4 : MonoBehaviour
{
    public Button AttackButton;
    public Button MoveButton;
    public Button NextTurn;



    public GameObject Unit;
    public GameObject AreaofMov;
    public GameObject AreaofAttack;
    // Use this for initialization
    void Start()
    {
        Button att = AttackButton.GetComponent<Button>();
        att.onClick.AddListener(TaskOnClickatt);


        Button mov = MoveButton.GetComponent<Button>();
        mov.onClick.AddListener(TaskOnClickmov);


        Button turn = NextTurn.GetComponent<Button>();
        turn.onClick.AddListener(NextTurnClick);
    }
    void TaskOnClickatt()
    {
        float xpos = Unit.transform.position.x;
        float ypos = Unit.transform.position.y;
        float zpos = Unit.transform.position.z;


        var myArea = Instantiate(AreaofAttack, new Vector3(xpos, ypos, zpos), Quaternion.identity);
        myArea.transform.parent = Unit.transform;
        myArea.gameObject.tag = "newobject";

    }
    void TaskOnClickmov()
    {

        float xpos = Unit.transform.position.x;
        float ypos = Unit.transform.position.y;
        float zpos = Unit.transform.position.z;


        GameObject myArea = Instantiate(AreaofMov, new Vector3(xpos, ypos, zpos), Quaternion.identity);
        myArea.transform.parent = Unit.transform;
        myArea.tag = "newobject";
        

    }
    public GameObject[] allTags;
    void NextTurnClick()
    {

        allTags = GameObject.FindGameObjectsWithTag("newobject");

        for (var i = 0; i < allTags.Length; i++)
        {
            Destroy(allTags[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
