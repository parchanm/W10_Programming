using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class AvoidAT : ActionTask {
        //prof keely's avoid script
        public BBParameter<SteeringData> sd;
		public BBParameter<Transform> target;
		public float avoidRange;
		public float steeringAcceleration;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			//check distance
			float distanceToTarget = Vector3.Distance(agent.transform.position, target.value.position);
			//ignore if it's out of range
			if (distanceToTarget > avoidRange)
			{
				EndAction(true);
				return;
			}
			//otherwise, move to the opposite direction
			Vector3 direction = target.value.position - agent.transform.position;
			direction = new Vector3(direction.x, 0f, direction.z);
			sd.value.acceleration -= direction.normalized * steeringAcceleration * Time.deltaTime;
			EndAction(true);
		}
	}
}