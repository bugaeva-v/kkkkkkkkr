using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x02000056 RID: 86
	public sealed class LdcOpCodesDictionary : Dictionary<Type, OpCode>
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x0000AA60 File Offset: 0x00008C60
		private LdcOpCodesDictionary()
		{
			base.Add(typeof(bool), OpCodes.Ldc_I4);
			base.Add(typeof(char), OpCodes.Ldc_I4);
			base.Add(typeof(sbyte), OpCodes.Ldc_I4);
			base.Add(typeof(short), OpCodes.Ldc_I4);
			base.Add(typeof(int), OpCodes.Ldc_I4);
			base.Add(typeof(long), OpCodes.Ldc_I8);
			base.Add(typeof(float), OpCodes.Ldc_R4);
			base.Add(typeof(double), OpCodes.Ldc_R8);
			base.Add(typeof(byte), OpCodes.Ldc_I4_0);
			base.Add(typeof(ushort), OpCodes.Ldc_I4_0);
			base.Add(typeof(uint), OpCodes.Ldc_I4_0);
			base.Add(typeof(ulong), OpCodes.Ldc_I4_0);
		}

		// Token: 0x1700006F RID: 111
		public new OpCode this[Type type]
		{
			get
			{
				OpCode result;
				if (base.TryGetValue(type, out result))
				{
					return result;
				}
				return LdcOpCodesDictionary.EmptyOpCode;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000AB8F File Offset: 0x00008D8F
		public static OpCode EmptyOpCode
		{
			get
			{
				return LdcOpCodesDictionary.emptyOpCode;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000AB96 File Offset: 0x00008D96
		public static LdcOpCodesDictionary Instance
		{
			get
			{
				return LdcOpCodesDictionary.dict;
			}
		}

		// Token: 0x040000B5 RID: 181
		private static readonly LdcOpCodesDictionary dict = new LdcOpCodesDictionary();

		// Token: 0x040000B6 RID: 182
		private static readonly OpCode emptyOpCode = default(OpCode);
	}
}
