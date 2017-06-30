using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreatureCreator {



	public class Tool : Entity {

		public enum QUALITY{
			LOW,
			MEDIUM,
			HIGH
		}

		public enum TOOL_TYPE{
			HANDS,
			AXE,
			HAMMER,
			SHOVEL,
			PICK,
			TRAP,
			NET
		}

		public TOOL_TYPE kind;

		public int cost=0;
		public QUALITY quality;

		public Tool(){
			this.kind = TOOL_TYPE.HANDS;
			this.quality = QUALITY.LOW;
		}
	}
}