using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x020002E7 RID: 743
	public abstract class UxmlTraits
	{
		// Token: 0x060018B0 RID: 6320 RVA: 0x00065529 File Offset: 0x00063729
		protected UxmlTraits()
		{
			this.canHaveAnyAttribute = true;
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x0006553B File Offset: 0x0006373B
		// (set) Token: 0x060018B2 RID: 6322 RVA: 0x00065543 File Offset: 0x00063743
		public bool canHaveAnyAttribute { get; protected set; }

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x0006554C File Offset: 0x0006374C
		public virtual IEnumerable<UxmlAttributeDescription> uxmlAttributesDescription
		{
			get
			{
				foreach (UxmlAttributeDescription attributeDescription in this.GetAllAttributeDescriptionForType(base.GetType()))
				{
					yield return attributeDescription;
					attributeDescription = null;
				}
				IEnumerator<UxmlAttributeDescription> enumerator = null;
				yield break;
				yield break;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x0006556C File Offset: 0x0006376C
		public virtual IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				yield break;
			}
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00002166 File Offset: 0x00000366
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0006558B File Offset: 0x0006378B
		private IEnumerable<UxmlAttributeDescription> GetAllAttributeDescriptionForType(Type t)
		{
			Type baseType = t.BaseType;
			bool flag = baseType != null;
			if (flag)
			{
				foreach (UxmlAttributeDescription ident in this.GetAllAttributeDescriptionForType(baseType))
				{
					yield return ident;
					ident = null;
				}
				IEnumerator<UxmlAttributeDescription> enumerator = null;
			}
			foreach (FieldInfo fieldInfo in from f in t.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
			where typeof(UxmlAttributeDescription).IsAssignableFrom(f.FieldType)
			select f)
			{
				yield return (UxmlAttributeDescription)fieldInfo.GetValue(this);
				fieldInfo = null;
			}
			IEnumerator<FieldInfo> enumerator2 = null;
			yield break;
			yield break;
		}
	}
}
