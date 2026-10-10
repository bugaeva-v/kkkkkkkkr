using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200013B RID: 315
	public class EditableList<T> : List<T>, IEditableObject, IRevertibleChangeTracking, IChangeTracking
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x00016CB8 File Offset: 0x00014EB8
		public EditableList()
		{
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00016CC0 File Offset: 0x00014EC0
		public EditableList(IEnumerable<T> collection) : base(collection)
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00016CC9 File Offset: 0x00014EC9
		public void BeginEdit()
		{
			if (!this.isEditing)
			{
				this.snapshot = new List<T>(this);
				this.isEditing = true;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00016CE8 File Offset: 0x00014EE8
		public bool IsChanged
		{
			get
			{
				if (this.snapshot == null || this.snapshot.Count != base.Count)
				{
					return false;
				}
				List<T>.Enumerator enumerator = base.GetEnumerator();
				List<T>.Enumerator enumerator2 = this.snapshot.GetEnumerator();
				while (enumerator.MoveNext() && enumerator2.MoveNext())
				{
					if (enumerator.Current != enumerator2.Current)
					{
						return false;
					}
					IChangeTracking changeTracking = enumerator.Current as IChangeTracking;
					if (changeTracking != null && changeTracking.IsChanged)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00016D75 File Offset: 0x00014F75
		public void EndEdit()
		{
			this.isEditing = false;
			this.snapshot = null;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00016D85 File Offset: 0x00014F85
		public void CancelEdit()
		{
			if (this.isEditing)
			{
				base.Clear();
				base.AddRange(this.snapshot);
				this.snapshot = null;
				this.isEditing = false;
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00016DAF File Offset: 0x00014FAF
		public void AcceptChanges()
		{
			this.BeginEdit();
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00016DB7 File Offset: 0x00014FB7
		public void RejectChanges()
		{
			this.CancelEdit();
		}

		// Token: 0x040001FA RID: 506
		private bool isEditing;

		// Token: 0x040001FB RID: 507
		private List<T> snapshot;
	}
}
