using System;
using System.Reflection;

namespace NSubstitute.Core
{
	// Token: 0x020000A9 RID: 169
	internal class ParameterInfoWrapper : IParameterInfo
	{
		// Token: 0x0600028B RID: 651 RVA: 0x00006C70 File Offset: 0x00004E70
		public ParameterInfoWrapper(ParameterInfo parameterInfo)
		{
			this._parameterInfo = parameterInfo;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00006C7F File Offset: 0x00004E7F
		public Type ParameterType
		{
			get
			{
				return this._parameterInfo.ParameterType;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00006C8C File Offset: 0x00004E8C
		public bool IsParams
		{
			get
			{
				return this._parameterInfo.IsParams();
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00006C99 File Offset: 0x00004E99
		public bool IsOptional
		{
			get
			{
				return this._parameterInfo.IsOptional;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00006CA6 File Offset: 0x00004EA6
		public bool IsOut
		{
			get
			{
				return this._parameterInfo.IsOut;
			}
		}

		// Token: 0x040000AB RID: 171
		private readonly ParameterInfo _parameterInfo;
	}
}
