using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class TimerCT : ConditionTask {
		public BBParameter<float> timer;

		protected override string OnInit(){
			return null;
		}

		protected override void OnEnable() {
			//decrease the timer
			timer.value -= Time.deltaTime;
			//Debug.Log("current timer" + timer);
		}

		protected override bool OnCheck() {
			//checks if timer reached 0
			return timer.value <= 0;
		}
	}
}