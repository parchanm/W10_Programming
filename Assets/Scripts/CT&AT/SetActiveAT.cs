using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class SetActiveAT : ActionTask {
		//AT script to activate/deactivate gameobject
		public GameObject gameObject;
		public bool activated;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			gameObject.SetActive(activated);
			EndAction(true);
		}
	}
}