using UnityEngine;

public class ServerOnScreen : MonoBehaviour
{
	GameObject[] sections;

	private void Start()
	{
		sections = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
		{
			sections[i] = transform.GetChild(i).gameObject;
		}
	}

	public void Show(int index)
	{
		sections[index].SetActive(true);
	}

	public void Hide(int index)
	{
		sections[index].SetActive(false);
	}
}
