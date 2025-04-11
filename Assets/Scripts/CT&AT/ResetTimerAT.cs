using System.Threading.Tasks.Sources;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ResetTimerAT : ActionTask {
		public BBParameter<float> timer;
		public float resetValue;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {

			//reset the timer if the time reaches 0
			if (timer.value <= 0)
			{
                timer.value = resetValue;
            }

			EndAction(true);
		}
	}
}