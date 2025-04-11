using NodeCanvas.Framework;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class NewTargetAT : ActionTask {
        public BBParameter<Transform> currentTarget;
		public BBParameter<Transform> newTarget;

        protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			//change current target to new target
			currentTarget.value = newTarget.value;
            //currentCounter.value++;
            EndAction(true);
		}
	}
}