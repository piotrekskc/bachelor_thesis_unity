using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStats : MonoBehaviour {
    public double HP;
    public double AttackRange;
    public float MovementRange;
    public double AttackStrength;
    public double Defence;
    public double DefenceFactor;
    public double FrontArmour;
    public double SideArmour;
    public double BackArmour;

    public bool isChoosen = false;
    public bool isDead = false;
    public bool nonActive = false;

    public GameObject Unit;
    public Texture2D tex;
    private Sprite mySprite;
    public void DrawAreaofMove()
    {
      //  GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
       // cube.transform.position = new Vector3(Unit.transform.position.x-(MovementRange/20), 0.01F, Unit.transform.position.z - (MovementRange / 20));
        mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
    }

    private SpriteRenderer sr;

    void Awake()
    {
        sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        sr.color = new Color(0.9f, 0.9f, 0.9f, 1.0f);

        transform.position = new Vector3(1.5f, 1.5f, 0.0f);
    }

    // Use this for initialization
    void Start () {
        DrawAreaofMove();

    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 100), "Add sprite"))
        {
            sr.sprite = mySprite;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
    
    }
