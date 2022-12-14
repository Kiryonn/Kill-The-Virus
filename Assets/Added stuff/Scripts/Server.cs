using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour
{
	public bool isUnderAttack;
	public Material normalMaterial;
	public MeshRenderer myMaterial;
	Cable grabbed = null;
	void Start()
	{
		isUnderAttack = false;
		//myMaterial.GetComponent<MeshRenderer>();
	}


	public void repare() {
		isUnderAttack = false;
		transform.Find("Cables").gameObject.SetActive(false);
		myMaterial.material = normalMaterial;
	}



	// Update is called once per frame
	void Update()
	{

	}
}
