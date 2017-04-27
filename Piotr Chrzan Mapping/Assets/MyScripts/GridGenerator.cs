using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {
    public int GridWidth;
    public int GridLength;

    public GameObject prefabCube;
    public void generateGrid()
    {
        Vector3 InitialPosition = new Vector3(0, 0, 0);

        for(int x = 0;x<GridWidth;x++)
        {
            for(int z =0;z<GridLength;z++)
            {
                Instantiate(prefabCube, new Vector3(x /10f, 0, z/10f), Quaternion.identity);


            }
        }
    }
	// Use this for initialization
	void Start () {


        generateGrid();
        
        	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
