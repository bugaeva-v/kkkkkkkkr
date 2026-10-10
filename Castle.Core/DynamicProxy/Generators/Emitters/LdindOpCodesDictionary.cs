using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x02000057 RID: 87
	public sealed class LdindOpCodesDictionary : Dictionary<Type, OpCode>
	{
		// Token: 0x060002BA RID: 698 RVA: 0x0000ABB4 File Offset: 0x00008DB4
		private LdindOpCodesDictionary()
		{
			base.Add(typeof(bool), OpCodes.Ldind_I1);
			base.Add(typeof(char), OpCodes.Ldind_I2);
			base.Add(typeof(sbyte), OpCodes.Ldind_I1);
			base.Add(typeof(short), OpCodes.Ldind_I2);
			base.Add(typeof(int), OpCodes.Ldind_I4);
			base.Add(typeof(long), OpCodes.Ldind_I8);
			base.Add(typeof(float), OpCodes.Ldind_R4);
			base.Add(typeof(double), OpCodes.Ldind_R8);
			base.Add(typeof(byte), OpCodes.Ldind_U1);
			base.Add(typeof(ushort), OpCodes.Ldind_U2);
			base.Add(typeof(uint), OpCodes.Ldind_U4);
			base.Add(typeof(ulong), OpCodes.Ldind_I8);
		}

		// Token: 0x17000072 RID: 114
		public new OpCode this[Type type]
		{
			get
			{
				OpCode result;
				if (base.TryGetValue(type, out result))
				{
					return result;
				}
				return LdindOpCodesDictionary.EmptyOpCode;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000ACE3 File Offset: 0x00008EE3
		public static OpCode EmptyOpCode
		{
			get
			{
				return LdindOpCodesDictionary.emptyOpCode;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000ACEA File Offset: 0x00008EEA
		public static LdindOpCodesDictionary Instance
		{
			get
			{
				return LdindOpCodesDictionary.dict;
			}
		}

		// Token: 0x040000B7 RID: 183
		private static readonly LdindOpCodesDictionary dict = new LdindOpCodesDictionary();

		// Token: 0x040000B8 RID: 184
		private static readonly OpCode emptyOpCode = default(OpCode);
	}
}
