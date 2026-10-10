using System;

namespace Castle.Core.Configuration
{
	// Token: 0x020000F5 RID: 245
	[Serializable]
	public class MutableConfiguration : AbstractConfiguration
	{
		// Token: 0x06000681 RID: 1665 RVA: 0x00012AF0 File Offset: 0x00010CF0
		public MutableConfiguration(string name) : this(name, null)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00012AFA File Offset: 0x00010CFA
		public MutableConfiguration(string name, string value)
		{
			base.Name = name;
			this.Value = value;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00012B10 File Offset: 0x00010D10
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00012B18 File Offset: 0x00010D18
		public new string Value
		{
			get
			{
				return base.Value;
			}
			set
			{
				base.Value = value;
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00012B21 File Offset: 0x00010D21
		public static MutableConfiguration Create(string name)
		{
			return new MutableConfiguration(name);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00012B29 File Offset: 0x00010D29
		public MutableConfiguration Attribute(string name, string value)
		{
			this.Attributes[name] = value;
			return this;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00012B3C File Offset: 0x00010D3C
		public MutableConfiguration CreateChild(string name)
		{
			MutableConfiguration mutableConfiguration = new MutableConfiguration(name);
			this.Children.Add(mutableConfiguration);
			return mutableConfiguration;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00012B60 File Offset: 0x00010D60
		public MutableConfiguration CreateChild(string name, string value)
		{
			MutableConfiguration mutableConfiguration = new MutableConfiguration(name, value);
			this.Children.Add(mutableConfiguration);
			return mutableConfiguration;
		}
	}
}
