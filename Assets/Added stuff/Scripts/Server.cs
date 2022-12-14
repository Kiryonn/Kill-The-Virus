using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour
{
    public bool isUnderAttack;
    void Start()
    {
        isUnderAttack = false;
    }

    public void repare() 
    {
        if (isUnderAttack) { Debug.Log("reparé"); }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
