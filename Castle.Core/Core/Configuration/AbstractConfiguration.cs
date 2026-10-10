using System;
using System.Globalization;

namespace Castle.Core.Configuration
{
	// Token: 0x020000F1 RID: 241
	[Serializable]
	public abstract class AbstractConfiguration : IConfiguration
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x000129D0 File Offset: 0x00010BD0
		public virtual ConfigurationAttributeCollection Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x000129D8 File Offset: 0x00010BD8
		public virtual ConfigurationCollection Children
		{
			get
			{
				return this.children;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x000129E0 File Offset: 0x00010BE0
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x000129E8 File Offset: 0x00010BE8
		public string Name { get; protected set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x000129F1 File Offset: 0x00010BF1
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x000129F9 File Offset: 0x00010BF9
		public string Value { get; protected set; }

		// Token: 0x06000675 RID: 1653 RVA: 0x00012A04 File Offset: 0x00010C04
		public virtual object GetValue(Type type, object defaultValue)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			object result;
			try
			{
				result = Convert.ChangeType(this.Value, type, CultureInfo.CurrentCulture);
			}
			catch (InvalidCastException)
			{
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x0400018B RID: 395
		private readonly ConfigurationAttributeCollection attributes = new ConfigurationAttributeCollection();

		// Token: 0x0400018C RID: 396
		private readonly ConfigurationCollection children = new ConfigurationCollection();
	}
}
