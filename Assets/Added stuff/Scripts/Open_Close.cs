using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Open_Close : MonoBehaviour
{

    bool open;

    private void Start()
    {
        open = false;
    }

    public void click() 
    {
        if (open)
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
        else
        {
            transform.Rotate(new Vector3(0, -90, 0));
        }
        open = !open;


    }

}
