using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehavioerComponentScript : MonoBehaviour
{
    private object material;

    public int Getcomponent { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            NewMethod();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            
              
        }
            if (Input.GetKeyDown(KeyCode.B))
            {
                GetComponent<Renderer>().material.color = Color.blue;
            }

        }

    private void NewMethod()
    {
        GetComponent<Render>().Material  = Color.red;
    }
}
