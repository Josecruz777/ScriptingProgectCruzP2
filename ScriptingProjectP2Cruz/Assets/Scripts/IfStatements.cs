using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    private float coffeeTemperature;
    private float hotLimitTemperature;
    private float coldLimitTemperature;

    // Start is called before the first frame update
    void Start()
    {
        coffeeTemperature = 85.0f;
        hotLimitTemperature = 70.0f;
        coldLimitTemperature = 40.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // if the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this
            print("coffee is too hot.");
        }
        // if isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //... do this
            print("Coffee is too cold.");
        }
        /// if it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}
