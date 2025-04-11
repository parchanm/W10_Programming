using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class NavigateAT : ActionTask {
		//prof.keely's navigate script
		public BBParameter<SteeringData> sd;

		protected override string OnInit() {
			return null;
		}

		protected override void OnUpdate() {
			sd.value.velocity += sd.value.acceleration;
			float groundSpeed = Mathf.Sqrt(sd.value.velocity.x * sd.value.velocity.x + sd.value.velocity.z * sd.value.velocity.z);
			if (sd.value.maxGroundSpeed < groundSpeed)
			{
				float cappedX = sd.value.velocity.x / groundSpeed * sd.value.maxGroundSpeed;
				float cappedZ = sd.value.velocity.z / groundSpeed * sd.value.maxGroundSpeed;

				//vertical test
				//velocity = new Vector3(cappedX, velocity.value.y, cappedZ);
                sd.value.velocity = new Vector3(cappedX, 0, cappedZ);
            }
			agent.transform.position += sd.value.velocity * Time.deltaTime;

            sd.value.acceleration = Vector3.zero;
		}
	}
}