﻿using UnityEngine;
using System.Collections;

public class Move_like_jager : MonoBehaviour 
{

	NavMeshAgent agent;

	void Start() 
	{
		agent = GetComponent<NavMeshAgent>();
	}

	void Update() {
		if (Input.GetMouseButtonDown(0)) 
		{
			RaycastHit hit;

			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) 
			{
				agent.destination = hit.point;
			}
		}
	}
}
