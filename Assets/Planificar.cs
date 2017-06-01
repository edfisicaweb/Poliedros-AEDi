using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planificar : MonoBehaviour {

	Animator plan;
	public bool estadoFigura;

	void Start()
	{
		plan = GetComponent<Animator> ();
		estadoFigura = false;
	}

	void Update()
	{
		plan.SetBool ("planificar", estadoFigura);
	}

	// Update is called once per frame
	public void anima()
	{
		if (estadoFigura == false) {
			estadoFigura = true;
		} else
		{
			estadoFigura = false;	
		}
	}
}