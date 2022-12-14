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
    
        transform.rotation = Quaternion.AngleAxis(90f,new Vector3(0,1,0));

    }

}
