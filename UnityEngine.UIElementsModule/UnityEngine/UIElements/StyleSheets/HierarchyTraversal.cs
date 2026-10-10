using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000355 RID: 853
	internal abstract class HierarchyTraversal
	{
		// Token: 0x06001B7C RID: 7036 RVA: 0x0007ED91 File Offset: 0x0007CF91
		public virtual void Traverse(VisualElement element)
		{
			this.TraverseRecursive(element, 0);
		}

		// Token: 0x06001B7D RID: 7037
		public abstract void TraverseRecursive(VisualElement element, int depth);

		// Token: 0x06001B7E RID: 7038 RVA: 0x0007EDA0 File Offset: 0x0007CFA0
		protected void Recurse(VisualElement element, int depth)
		{
			int i = 0;
			while (i < element.hierarchy.childCount)
			{
				VisualElement visualElement = element.hierarchy[i];
				this.TraverseRecursive(visualElement, depth + 1);
				bool flag = visualElement.hierarchy.parent != element;
				if (!flag)
				{
					i++;
				}
			}
		}
	}
}
