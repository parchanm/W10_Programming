using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using System.Collections.Generic;

namespace NodeCanvas.Tasks.Actions {

	public class ChangeTargetAT : ActionTask {
		public List<Transform> patrolPoints;
		public BBParameter<Transform> currentTarget;
		public BBParameter<float> age;
        public MeshRenderer meshRenderer;
        public Color resetColor;

        public int minage;
		public int maxage;

		private int currentPatrolPointIndex = 0;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			currentPatrolPointIndex++;
			if(patrolPoints.Count <= currentPatrolPointIndex)
			{
				currentPatrolPointIndex = 0;
                //randomize age
                meshRenderer.material.color = resetColor;
                age.value = Random.Range(minage, maxage);
				Debug.Log("age randomized");
			}
			currentTarget.value = patrolPoints[currentPatrolPointIndex];
			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}