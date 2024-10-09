using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //create a variable of type int and set it to the number 5
    int myint = 5;


    // Start is called before the first frame update
    void Start()
    {
        myint = MutiplyByTwo(myint);
        Debug.Log(myint);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int MutiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}