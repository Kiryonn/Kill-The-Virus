using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Car : MonoBehaviour
{
	public NavMeshAgent carNavMesh;
	public Transform[] points;
    void Start()
    {
        carNavMesh = GetComponent<NavMeshAgent>();
    }

	int index = 0;
	IEnumerator GoTo(Transform point) {
		carNavMesh.SetDestination(point.position);
		yield return new WaitForSeconds(0.2f);
		yield return new WaitUntil(() => carNavMesh.remainingDistance < carNavMesh.stoppingDistance);
		index++;
		StartCoroutine(GoTo(points[index]));
	}
}
