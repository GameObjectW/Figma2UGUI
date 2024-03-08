using System;
using UnityEditor.TreeViewExamples;
using UnityEngine;
using Random = UnityEngine.Random;


namespace FigmaImporter.Editor.EditorTree.TreeData
{

	[Serializable]
	public class NodeTreeElement : TreeElement
	{
		public string figmaId;
		public ActionType actionType;
		public Sprite sprite;
		public bool enabled;

		public NodeTreeElement (string name, string figmaId, ActionType actionType, Sprite sprite, int depth, int id, bool enabled) : base (name, depth, id)
		{
			this.actionType = actionType;
			this.sprite = sprite;
			this.figmaId = figmaId;
			this.enabled = enabled;
		}
	}

	public enum ActionType
	{
		None,
		Render,
		Generate,
		Transform,
// #if VECTOR_GRAHICS_IMPORTED
// 		SvgRender
// #endif
	}
}
