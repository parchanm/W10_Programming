using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class IncreaseMineralAT : ActionTask {
        public BBParameter<int> currentMineral;
		public BBParameter<bool> holdingMineral;
		public BBParameter<GameObject> mineralBit;

		public bool trueOrFalse;
        public int increaseMineral;

        protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			//increase the mineral
            currentMineral.value += increaseMineral;
            //set if the worker's holding the mineral
            holdingMineral.value = trueOrFalse;
			mineralBit.value.SetActive(trueOrFalse);
            EndAction(true);
		}
	}
}