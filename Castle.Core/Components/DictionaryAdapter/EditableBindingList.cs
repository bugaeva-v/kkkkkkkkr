using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200013A RID: 314
	public class EditableBindingList<T> : BindingList<T>, IList<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IEditableObject, IRevertibleChangeTracking, IChangeTracking
	{
		// Token: 0x0600089A RID: 2202 RVA: 0x00016B6C File Offset: 0x00014D6C
		public EditableBindingList()
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00016B74 File Offset: 0x00014D74
		public EditableBindingList(IList<T> initial) : base(initial)
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00016B80 File Offset: 0x00014D80
		public bool IsChanged
		{
			get
			{
				if (this.snapshot == null || this.snapshot.Count != base.Count)
				{
					return false;
				}
				IEnumerator<T> enumerator = base.GetEnumerator();
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

		// Token: 0x0600089D RID: 2205 RVA: 0x00016C0A File Offset: 0x00014E0A
		public void BeginEdit()
		{
			if (!this.isEditing)
			{
				this.snapshot = new List<T>(this);
				this.isEditing = true;
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00016C27 File Offset: 0x00014E27
		public void EndEdit()
		{
			this.isEditing = false;
			this.snapshot = null;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00016C38 File Offset: 0x00014E38
		public void CancelEdit()
		{
			if (this.isEditing)
			{
				base.Clear();
				foreach (T item in this.snapshot)
				{
					base.Add(item);
				}
				this.snapshot = null;
				this.isEditing = false;
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00016CA8 File Offset: 0x00014EA8
		public void AcceptChanges()
		{
			this.BeginEdit();
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00016CB0 File Offset: 0x00014EB0
		public void RejectChanges()
		{
			this.CancelEdit();
		}

		// Token: 0x040001F8 RID: 504
		private bool isEditing;

		// Token: 0x040001F9 RID: 505
		private List<T> snapshot;
	}
}
