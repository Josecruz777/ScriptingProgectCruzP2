using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehavioerComponentScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Render>().Material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Getcomponent <() .material.color = Color.green;
        }
            if (Input.GetKeyDown(KeyCode.B))
            {
                GetComponent<Renderer>().material.color = Color.blue;
            }

        }
    }
