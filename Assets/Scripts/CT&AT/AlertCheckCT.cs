using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class AlertCheckCT : ConditionTask {

		//alert bool for patrol
		public BBParameter<bool> alertOn;

		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			//condition check when alert is true
			return alertOn.value;
		}
	}
}