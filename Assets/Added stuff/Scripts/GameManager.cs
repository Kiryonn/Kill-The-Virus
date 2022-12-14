using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	[Header("Server Sections")]
	[SerializeField] Server[] section1;
	[SerializeField] Server[] section2;
	[SerializeField] Server[] section3;
	[SerializeField] Server[] section4;

	List<Server[]> sections;
	[SerializeField] GameObject minigame_cable;

	[Header("Audio")]
	public AudioClip alert;
	public AudioClip hackedMood;
	public AudioSource ambiance;
	public AudioSource SFX;

	public ServerOnScreen screen;
	public Material hackedMaterial;

	float lastTime = 0;

	void Start()
	{
		sections = new List<Server[]>{section1, section2, section3, section4};
	}

	void Update(){
		Debug.Log(lastTime);
		lastTime += Time.deltaTime;
		if (lastTime > 3){
			lastTime %= 1;
			CreateAlert();
		}
	}

	public void CreateAlert() {
		SFX.Play();
		ambiance.Stop();
		ambiance.clip = hackedMood;
		ambiance.Play();
		int index = Random.Range(0, sections.Count-1);
		screen.Show(index);
		foreach (var server in sections[index])
		{
			server.isUnderAttack = true;
			server.GetComponent<MeshRenderer>().material = hackedMaterial;
		}
	}

}
