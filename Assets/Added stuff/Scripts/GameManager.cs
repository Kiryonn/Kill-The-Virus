using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	[SerializeField] List<Server[]> sections;
	[SerializeField] GameObject minigame_cable;

	AudioClip alert;
	AudioClip hackedMood;
	AudioSource ambiance;
	AudioSource SFX;

	float lastTime = 0;

	void Start()
	{

	}

	void Update(){
		lastTime += Time.deltaTime;
		if (lastTime > 60000){
			lastTime = 0;
			CreateAlert();
		}
	}

	public void CreateAlert() {
		SFX.PlayOneShot(alert);
		ambiance.clip = hackedMood;
		int index = Random.Range(0, sections.Count-1);
		foreach (var server in sections[index])
		{
			server.isUnderAttack = true;
		}
	}


}
