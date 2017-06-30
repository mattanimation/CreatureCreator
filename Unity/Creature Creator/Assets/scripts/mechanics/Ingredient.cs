using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreatureCreator {

	public class Ingredient : Entity {
	
		public enum SUBSTANCE
		{
			NONE,
			MINERAL,
			VEGETABLE,
			PLANT,
			ANIMAL,
			OTHER
		}

		public SUBSTANCE substance;
		public string label = "";
		public int amount = 0;

		public Ingredient(){
			this.substance = SUBSTANCE.NONE;
			this.amount = 0;
			this.label = "dunno";
		}

	}

}
