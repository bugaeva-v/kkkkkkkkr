using System;
using System.Reflection;

namespace UnityEngine.Analytics
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public class TrackableField : TrackablePropertyBase
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002548 File Offset: 0x00000748
		public TrackableField(params Type[] validTypes)
		{
			if (validTypes == null || validTypes.Length == 0)
			{
				return;
			}
			this.m_ValidTypeNames = new string[validTypes.Length];
			for (int i = 0; i < validTypes.Length; i++)
			{
				this.m_ValidTypeNames[i] = validTypes[i].ToString();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002590 File Offset: 0x00000790
		public object GetValue()
		{
			if (this.m_Target == null || string.IsNullOrEmpty(this.m_Path))
			{
				return null;
			}
			object obj = this.m_Target;
			foreach (string name in this.m_Path.Split(new char[]
			{
				'.'
			}))
			{
				try
				{
					PropertyInfo property = obj.GetType().GetProperty(name);
					obj = property.GetValue(obj, null);
				}
				catch
				{
					FieldInfo field = obj.GetType().GetField(name);
					obj = field.GetValue(obj);
				}
			}
			return obj;
		}

		// Token: 0x04000011 RID: 17
		[SerializeField]
		private string[] m_ValidTypeNames;

		// Token: 0x04000012 RID: 18
		[SerializeField]
		private string m_Type;

		// Token: 0x04000013 RID: 19
		[SerializeField]
		private string m_EnumType;
	}
}
