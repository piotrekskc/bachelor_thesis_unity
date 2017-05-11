using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(MeshFilter))]

public class RenderingTextureDeformation : MonoBehaviour {
    
    void Start()
    {
        
    }
    public Vector3[] vertices;
    int Iteration = 0;
    void Update()
    {
       if(Input.GetKeyDown("n"))
        {
            Iteration++;
            if(Iteration == 23)
            {
                Iteration = 0;
            }
        }
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        vertices = mesh.vertices;
        ChangeVerticePosition(Iteration);
        mesh.vertices = vertices;
    }
    void ChangeVerticePosition(int i)
    {
        if (vertices[i].y > 0)
        {
            if (Input.GetKeyDown("left"))
            {
                vertices[i] = new Vector3(vertices[i].x + 0.01f, vertices[i].y, vertices[i].z);
            }
            if (Input.GetKeyDown("right"))
            {
                vertices[i] = new Vector3(vertices[i].x - 0.01f, vertices[i].y, vertices[i].z);
            }
            if (Input.GetKeyDown("up"))
            {
                vertices[i] = new Vector3(vertices[i].x, vertices[i].y, vertices[i].z + 0.01f);
            }
            if (Input.GetKeyDown("down"))
            {
                vertices[i] = new Vector3(vertices[i].x, vertices[i].y, vertices[i].z - 0.01f);
            }
        }
        else
        {
            Iteration++;
        }
                   
    }
     
}