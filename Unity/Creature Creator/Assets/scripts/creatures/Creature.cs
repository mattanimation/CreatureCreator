using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreatureCreator {

	public class Creature : Entity {

		public enum MOOD
		{
			NEUTRAL,
			HAPPY,
			SAD,
			EXCITED,
			SCARED
		};

		public float health = 100;
		public int intelligence = 10;
		public float energy = 0; //this determines hunger,
		public MOOD mood = MOOD.NEUTRAL;
		public string nickName = "";
		public string parent = "";

		public Creature(){
		
		}

	}
}