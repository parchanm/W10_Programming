using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MoveToTargetAT : ActionTask {
		public BBParameter<Transform> currentTarget;
		public float speed;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			//set the direction to the target position
			Vector3 directionToMove = currentTarget.value.position - agent.transform.position;
			//and move ! ! ! (using direction, speed, position)
			agent.transform.position += directionToMove.normalized * speed * Time.deltaTime;
			EndAction(true);
		}
	}
}