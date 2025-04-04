using NodeCanvas.Framework;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class NewTargetAT : ActionTask {
        public BBParameter<Transform> currentTarget;
		public BBParameter<Transform> newTarget;

		public BBParameter<int> currentMineral;
		public BBParameter<int> currentCounter;

		public GameObject PU0;
        public GameObject PU1;
        public GameObject PU2;
        public GameObject PU3;
        public GameObject PU4;

        //public int increaseMineral;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			currentTarget.value = newTarget.value;
			currentMineral.value = 0;
			if (currentCounter.value == 0 )
			{
				PU0.SetActive(true);
			}
            if (currentCounter.value == 1)
            {
                PU1.SetActive(true);
            }

            if (currentCounter.value == 2)
            {
                PU2.SetActive(true);
            }

            if (currentCounter.value == 3)
            {
                PU3.SetActive(true);
            }

            if (currentCounter.value == 4)
            {
                PU4.SetActive(true);
            }

            currentCounter.value++;
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