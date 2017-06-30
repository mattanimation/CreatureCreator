using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreatureCreator{

	public class Step {
	
		public enum STEP_TYPE {
			NONE,
			STIR,
			ADD,
			BOIL,
			TOSS
		}
		public STEP_TYPE type;

		public Step(){
			this.type = STEP_TYPE.NONE;
		}
	}

	public class Recipe : Entity {

		public List<Step> steps;
		public List<Ingredient> ingredients;

		public Recipe(){
			this.steps = new List<Step> ();
			this.ingredients = new List<Ingredient> ();

		}
	
	}

}