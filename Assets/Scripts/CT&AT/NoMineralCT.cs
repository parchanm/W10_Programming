using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class NoMineralCT : ConditionTask {

		public BBParameter<int> currentMineral;
		public BBParameter<bool> holdingMineralRn;

		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			//this is to check if there's no mineral
			return currentMineral.value < 30 && holdingMineralRn.value == false;
		}
	}
}