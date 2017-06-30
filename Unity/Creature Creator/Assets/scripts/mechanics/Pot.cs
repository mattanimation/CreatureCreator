using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreatureCreator {

	public class Steps {
	
		public Steps(){
		
		}
	}

	public class Pot : Entity {

		public List<Ingredient> ingredients;

		public Pot(){

			this.ingredients = new List<Ingredient> ();
		
		}
		
	}

}