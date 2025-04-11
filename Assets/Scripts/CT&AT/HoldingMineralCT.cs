using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class HoldingMineralCT : ConditionTask {
		public BBParameter<bool> holdingMineral;

		public bool trueOrFalse;
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			//checks if the worker's holding the mineral or not
			return holdingMineral.value == trueOrFalse; ;
		}
	}
}