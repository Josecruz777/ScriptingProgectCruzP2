using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class g : MonoBehaviour
{
    public Image Graphic;
    public Sprite Standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    // Start is called before the first frame update
    void Start()
    {
        Graphic.Sprite = Standard;
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down)
        {
            Graphic.Sprite = downgfx;
        }
        else if (held)
            Graphic.Sprite = heldgfx;
    }
      else if (up)
        {
        graphic.sprite = upgfx;
        }
else
{ 
    graphic.sprite = Standard;
}

boolDisplay1.text = " " + down;
boolDisplay2.text = " " + held;
boolDisplay3.text = " " + held;
}
}