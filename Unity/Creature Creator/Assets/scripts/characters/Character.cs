using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * this is what the players character is
 * */

public class Character : MonoBehaviour {

	//@todo: list what actions character can actually do
	public enum ACTIONS
	{
		DIG,
		CHOP,
		INTERACT,
		THROW,
		ATTACK

	}

	public ACTIONS action;
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
