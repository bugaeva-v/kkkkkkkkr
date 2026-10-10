using System;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000133 RID: 307
	public class PropertyChangedEventArgsEx : PropertyChangedEventArgs
	{
		// Token: 0x06000825 RID: 2085 RVA: 0x000160E8 File Offset: 0x000142E8
		public PropertyChangedEventArgsEx(string propertyName, object oldValue, object newValue) : base(propertyName)
		{
			this.oldValue = oldValue;
			this.newValue = newValue;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000160FF File Offset: 0x000142FF
		public object OldValue
		{
			get
			{
				return this.oldValue;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00016107 File Offset: 0x00014307
		public object NewValue
		{
			get
			{
				return this.newValue;
			}
		}

		// Token: 0x040001E0 RID: 480
		private readonly object oldValue;

		// Token: 0x040001E1 RID: 481
		private readonly object newValue;
	}
}
