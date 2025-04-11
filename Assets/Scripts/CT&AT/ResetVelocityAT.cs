using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ResetVelocityAT : ActionTask {

		// small note: had to make this script because I couldn't use the built in feature to reset Vector3 which is bound with data class
		public BBParameter<SteeringData> sd;
		public Vector3 resetVector;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			//reset the dataclass' velocity to 0, 0, 0
			sd.value.velocity = resetVector;
			EndAction(true);
		}
	}
}