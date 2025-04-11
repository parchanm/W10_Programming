using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class ApproachAT : ActionTask {
		//prof keely's approaching script
		public BBParameter<SteeringData> sd;
		public BBParameter<Vector3> target;
		public float steeringAcceleration;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			//direction calculation
			Vector3 direction = target.value - agent.transform.position;
			direction = new Vector3(direction.x, 0, direction.z); //block y values to prevent a bug

			//calculate velocity with direction and acceleration
			sd.value.velocity += direction.normalized * steeringAcceleration * Time.deltaTime;
			EndAction(true);
		}
	}
}