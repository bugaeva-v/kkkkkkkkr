using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public class ValueProperty
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002638 File Offset: 0x00000838
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002640 File Offset: 0x00000840
		public string valueType
		{
			get
			{
				return this.m_ValueType;
			}
			set
			{
				this.m_ValueType = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000264C File Offset: 0x0000084C
		public string propertyValue
		{
			get
			{
				if (this.m_PropertyType == ValueProperty.PropertyType.Dynamic && this.m_Target != null)
				{
					object value = this.m_Target.GetValue();
					if (value != null)
					{
						return value.ToString().Trim();
					}
					return null;
				}
				else
				{
					if (this.m_Value != null)
					{
						return this.m_Value.Trim();
					}
					return null;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000269C File Offset: 0x0000089C
		public TrackableField target
		{
			get
			{
				return this.m_Target;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000026A4 File Offset: 0x000008A4
		public bool IsValid()
		{
			switch (this.m_PropertyType)
			{
			case ValueProperty.PropertyType.Static:
				return !string.IsNullOrEmpty(this.m_Value) || Type.GetType(this.m_ValueType) != typeof(string);
			case ValueProperty.PropertyType.Dynamic:
				return this.m_Target != null && this.m_Target.GetValue() != null;
			}
			return false;
		}

		// Token: 0x04000016 RID: 22
		[SerializeField]
		private bool m_EditingCustomValue;

		// Token: 0x04000017 RID: 23
		[SerializeField]
		private int m_PopupIndex;

		// Token: 0x04000018 RID: 24
		[SerializeField]
		private string m_CustomValue;

		// Token: 0x04000019 RID: 25
		[SerializeField]
		private bool m_FixedType;

		// Token: 0x0400001A RID: 26
		[SerializeField]
		private string m_EnumType;

		// Token: 0x0400001B RID: 27
		[SerializeField]
		private bool m_EnumTypeIsCustomizable = true;

		// Token: 0x0400001C RID: 28
		[SerializeField]
		private bool m_CanDisable;

		// Token: 0x0400001D RID: 29
		[SerializeField]
		private ValueProperty.PropertyType m_PropertyType = ValueProperty.PropertyType.Static;

		// Token: 0x0400001E RID: 30
		[SerializeField]
		private string m_ValueType;

		// Token: 0x0400001F RID: 31
		[SerializeField]
		private string m_Value = "";

		// Token: 0x04000020 RID: 32
		[SerializeField]
		private TrackableField m_Target;

		// Token: 0x02000017 RID: 23
		public enum PropertyType
		{
			// Token: 0x0400005E RID: 94
			Disabled,
			// Token: 0x0400005F RID: 95
			Static,
			// Token: 0x04000060 RID: 96
			Dynamic
		}
	}
}
