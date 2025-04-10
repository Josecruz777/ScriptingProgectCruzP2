using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;


    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider box1;


    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCo1 = otherGameObject.GetComponent<BoxCollider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        boxCo1.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfplayerDeaths + " times");
    }
}
