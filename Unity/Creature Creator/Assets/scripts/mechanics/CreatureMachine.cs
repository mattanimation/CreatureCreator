using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatureCreator;

public class CreatureMachine : MonoBehaviour {

	public enum MACHINE_STATE
	{
		OFF,
		ON,
		PROCESSING,
		OVERLOADED
	}

	public MACHINE_STATE state;

	public Pot pot;
	public GameObject toggleSwitch;

	public int operatedHours = 0;
	public int energyLevel = 0;


	private int minimumEnergyLevel = 10;

	// Use this for initialization
	void Start () {
		this.state = MACHINE_STATE.OFF;
		this.energyLevel = 0;
		this.operatedHours = 0;
		this.pot = new Pot ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleMachine(){
		
	}

	public void TestRecipe(){
		if (this.energyLevel >= this.minimumEnergyLevel) {
			
		} else {
			//warn user cannnot run machine
		}
	}
}
