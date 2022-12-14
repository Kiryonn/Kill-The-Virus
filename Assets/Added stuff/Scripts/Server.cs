using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour
{
	public bool isUnderAttack;
	public Material normalMaterial;
	public Material hackedMaterial;
	MeshRenderer myMaterial;
	Cable grabbed = null;
	void Start()
	{
		isUnderAttack = false;
		myMaterial.GetComponent<MeshRenderer>();
	}

	public void repare()
	{
		if (isUnderAttack) {
			transform.Find("Cables").gameObject.SetActive(true);
			myMaterial.material = hackedMaterial;
		}
	}

	public void repared() {
		isUnderAttack = false;
		transform.Find("Cables").gameObject.SetActive(false);
		myMaterial.material = normalMaterial;
	}



	// Update is called once per frame
	void Update()
	{

	}
}
