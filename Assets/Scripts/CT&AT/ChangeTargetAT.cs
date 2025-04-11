using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using System.Collections.Generic;

namespace NodeCanvas.Tasks.Actions {

	public class ChangeTargetAT : ActionTask {
		public List<Transform> patrolPoints;
		public BBParameter<Transform> currentTarget;
        public MeshRenderer meshRenderer;
        public Color resetColor;

		//can't remove these because it's giving me errors when I delete it...
		public BBParameter<float> currentMineral;
		public float increaseMineral;

		private int currentPatrolPointIndex = 0;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			//increase index to change the target location
            currentPatrolPointIndex++;
			if(patrolPoints.Count <= currentPatrolPointIndex)
			{
				//reset the index if it goes over the full count
				currentPatrolPointIndex = 0;
			}
			currentTarget.value = patrolPoints[currentPatrolPointIndex];
            
			EndAction(true);
		}
	}
}