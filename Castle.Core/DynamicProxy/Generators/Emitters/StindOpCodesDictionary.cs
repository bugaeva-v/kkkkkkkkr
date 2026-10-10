using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x0200005F RID: 95
	public sealed class StindOpCodesDictionary : Dictionary<Type, OpCode>
	{
		// Token: 0x060002EA RID: 746 RVA: 0x0000B6CC File Offset: 0x000098CC
		private StindOpCodesDictionary()
		{
			base.Add(typeof(bool), OpCodes.Stind_I1);
			base.Add(typeof(char), OpCodes.Stind_I2);
			base.Add(typeof(sbyte), OpCodes.Stind_I1);
			base.Add(typeof(short), OpCodes.Stind_I2);
			base.Add(typeof(int), OpCodes.Stind_I4);
			base.Add(typeof(long), OpCodes.Stind_I8);
			base.Add(typeof(float), OpCodes.Stind_R4);
			base.Add(typeof(double), OpCodes.Stind_R8);
			base.Add(typeof(byte), OpCodes.Stind_I1);
			base.Add(typeof(ushort), OpCodes.Stind_I2);
			base.Add(typeof(uint), OpCodes.Stind_I4);
			base.Add(typeof(ulong), OpCodes.Stind_I8);
		}

		// Token: 0x1700007E RID: 126
		public new OpCode this[Type type]
		{
			get
			{
				OpCode result;
				if (base.TryGetValue(type, out result))
				{
					return result;
				}
				return StindOpCodesDictionary.EmptyOpCode;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000B7FB File Offset: 0x000099FB
		public static OpCode EmptyOpCode
		{
			get
			{
				return StindOpCodesDictionary.emptyOpCode;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000B802 File Offset: 0x00009A02
		public static StindOpCodesDictionary Instance
		{
			get
			{
				return StindOpCodesDictionary.dict;
			}
		}

		// Token: 0x040000C1 RID: 193
		private static readonly StindOpCodesDictionary dict = new StindOpCodesDictionary();

		// Token: 0x040000C2 RID: 194
		private static readonly OpCode emptyOpCode = default(OpCode);
	}
}
