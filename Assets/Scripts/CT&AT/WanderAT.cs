using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class WanderAT : ActionTask {
		//professor keely's wander script
		public float wanderSampleFrequency;
		public float wanderDirectionChangeFrequency;
		public BBParameter<SteeringData> sd;
		public float accelerationStrength;

		private Vector3 randomPoint = Vector3.zero;
		private Vector3 currentAccelerationDirection = Vector3.zero;

		private float timeSinceLastDirectionChange = 0f;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			timeSinceLastDirectionChange += Time.deltaTime;
			if (timeSinceLastDirectionChange > wanderDirectionChangeFrequency)
			{
				randomPoint = Random.insideUnitCircle.normalized;
				timeSinceLastDirectionChange = 0f;
				// new vector y = 0 ! ! !
				currentAccelerationDirection = new Vector3(randomPoint.x, 0, randomPoint.y);
			}
			Debug.DrawLine(agent.transform.position, currentAccelerationDirection + agent.transform.position);
			sd.value.acceleration += currentAccelerationDirection.normalized * Time.deltaTime * accelerationStrength;
			EndAction(true);
		}
	}
}