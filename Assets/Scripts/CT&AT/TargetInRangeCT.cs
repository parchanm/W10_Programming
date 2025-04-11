using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class TargetInRangeCT : ConditionTask {

		public BBParameter<Transform> currentTarget;
		public float rangeDistance;

		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			if (currentTarget.value == null)
			{
				return false;
			}
			//checks if target's in range and passes if it's in range
			float distanceToTarget = Vector3.Distance(currentTarget.value.position, agent.transform.position);
			//Debug.Log(distanceToTarget);
			return distanceToTarget < rangeDistance;
		}
	}
}