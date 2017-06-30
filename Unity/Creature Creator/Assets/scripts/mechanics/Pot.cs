using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreatureCreator {

	public class Steps {
	
		public Steps(){
		
		}
	}

	public class Pot : Entity {

		public enum POT_STATE
		{
			EMPTY,
			NOT_EMPTY,
			FULL
		}

		public List<Ingredient> ingredients;

		public int temperature = 0;
		public bool isBoiling = false;
		public POT_STATE fillState;

		public Pot(){

			this.ingredients = new List<Ingredient> ();
			this.fillState = POT_STATE.EMPTY;
		}

		public void Stir(){
		
		}

		public void HeatUp(){
		
		}

		public void CoolDown(){
		
		}
		
	}

}