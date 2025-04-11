using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class DebugLogAT : ActionTask {
		//debug log script to notify player win/lose
		public string writeHere;

		protected override string OnInit() {
			Debug.Log(writeHere);
			return null;
		}

		protected override void OnExecute() {
			EndAction(true);
		}
	}
}