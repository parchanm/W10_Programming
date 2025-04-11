using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ChangeColorAT : ActionTask {

		public MeshRenderer meshRenderer;
		public Color colorToChangeTo;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			//access meshrenderer to change the material's color
			meshRenderer.material.color = colorToChangeTo;
			EndAction(true);
		}
	}
}