using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.UIElements;


namespace NodeCanvas.Tasks.Conditions {

	public class EnoughMineralCT : ConditionTask {

		public BBParameter<int> currentMineral;
		public int enoughMineral;

		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			//check if worker has enough minerals
			return currentMineral.value >= enoughMineral;
		}
	}
}