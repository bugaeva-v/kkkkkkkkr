using System;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000134 RID: 308
	public class PropertyChangingEventArgsEx : PropertyChangingEventArgs
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x0001610F File Offset: 0x0001430F
		public PropertyChangingEventArgsEx(string propertyName, object oldValue, object newValue) : base(propertyName)
		{
			this.oldValue = oldValue;
			this.newValue = newValue;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00016126 File Offset: 0x00014326
		public object OldValue
		{
			get
			{
				return this.oldValue;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0001612E File Offset: 0x0001432E
		public object NewValue
		{
			get
			{
				return this.newValue;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00016136 File Offset: 0x00014336
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x0001613E File Offset: 0x0001433E
		public bool Cancel
		{
			get
			{
				return this.cancel;
			}
			set
			{
				this.cancel = value;
			}
		}

		// Token: 0x040001E2 RID: 482
		private readonly object oldValue;

		// Token: 0x040001E3 RID: 483
		private readonly object newValue;

		// Token: 0x040001E4 RID: 484
		private bool cancel;
	}
}
