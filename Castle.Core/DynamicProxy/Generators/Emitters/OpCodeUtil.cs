using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x0200005C RID: 92
	internal abstract class OpCodeUtil
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x0000B1A0 File Offset: 0x000093A0
		public static void EmitLoadIndirectOpCodeForType(ILGenerator gen, Type type)
		{
			if (type.GetTypeInfo().IsEnum)
			{
				OpCodeUtil.EmitLoadIndirectOpCodeForType(gen, OpCodeUtil.GetUnderlyingTypeOfEnum(type));
				return;
			}
			if (type.GetTypeInfo().IsByRef)
			{
				throw new NotSupportedException("Cannot load ByRef values");
			}
			if (type.GetTypeInfo().IsPrimitive && type != typeof(IntPtr) && type != typeof(UIntPtr))
			{
				OpCode opCode = LdindOpCodesDictionary.Instance[type];
				if (opCode == LdindOpCodesDictionary.EmptyOpCode)
				{
					throw new ArgumentException("Type " + type + " could not be converted to a OpCode");
				}
				gen.Emit(opCode);
				return;
			}
			else
			{
				if (type.GetTypeInfo().IsValueType)
				{
					gen.Emit(OpCodes.Ldobj, type);
					return;
				}
				if (type.GetTypeInfo().IsGenericParameter)
				{
					gen.Emit(OpCodes.Ldobj, type);
					return;
				}
				gen.Emit(OpCodes.Ldind_Ref);
				return;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000B288 File Offset: 0x00009488
		public static void EmitLoadOpCodeForConstantValue(ILGenerator gen, object value)
		{
			if (value is string)
			{
				gen.Emit(OpCodes.Ldstr, value.ToString());
				return;
			}
			if (value is int)
			{
				OpCode opcode = LdcOpCodesDictionary.Instance[value.GetType()];
				gen.Emit(opcode, (int)value);
				return;
			}
			if (value is bool)
			{
				OpCode opcode2 = LdcOpCodesDictionary.Instance[value.GetType()];
				gen.Emit(opcode2, Convert.ToInt32(value));
				return;
			}
			throw new NotSupportedException();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000B304 File Offset: 0x00009504
		public static void EmitLoadOpCodeForDefaultValueOfType(ILGenerator gen, Type type)
		{
			if (type.GetTypeInfo().IsPrimitive)
			{
				OpCode opcode = LdcOpCodesDictionary.Instance[type];
				switch (opcode.StackBehaviourPush)
				{
				case StackBehaviour.Pushi:
					gen.Emit(opcode, 0);
					if (OpCodeUtil.Is64BitTypeLoadedAsInt32(type))
					{
						gen.Emit(OpCodes.Conv_I8);
						return;
					}
					break;
				case StackBehaviour.Pushi8:
					gen.Emit(opcode, 0L);
					return;
				case StackBehaviour.Pushr4:
					gen.Emit(opcode, 0f);
					return;
				case StackBehaviour.Pushr8:
					gen.Emit(opcode, 0.0);
					return;
				default:
					throw new NotSupportedException();
				}
			}
			else
			{
				gen.Emit(OpCodes.Ldnull);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public static void EmitStoreIndirectOpCodeForType(ILGenerator gen, Type type)
		{
			if (type.GetTypeInfo().IsEnum)
			{
				OpCodeUtil.EmitStoreIndirectOpCodeForType(gen, OpCodeUtil.GetUnderlyingTypeOfEnum(type));
				return;
			}
			if (type.GetTypeInfo().IsByRef)
			{
				throw new NotSupportedException("Cannot store ByRef values");
			}
			if (type.GetTypeInfo().IsPrimitive && type != typeof(IntPtr) && type != typeof(UIntPtr))
			{
				OpCode opCode = StindOpCodesDictionary.Instance[type];
				if (object.Equals(opCode, StindOpCodesDictionary.EmptyOpCode))
				{
					throw new ArgumentException("Type " + type + " could not be converted to a OpCode");
				}
				gen.Emit(opCode);
				return;
			}
			else
			{
				if (type.GetTypeInfo().IsValueType)
				{
					gen.Emit(OpCodes.Stobj, type);
					return;
				}
				if (type.GetTypeInfo().IsGenericParameter)
				{
					gen.Emit(OpCodes.Stobj, type);
					return;
				}
				gen.Emit(OpCodes.Stind_Ref);
				return;
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000B494 File Offset: 0x00009694
		private static Type GetUnderlyingTypeOfEnum(Type enumType)
		{
			switch (((IConvertible)Activator.CreateInstance(enumType)).GetTypeCode())
			{
			case TypeCode.SByte:
				return typeof(sbyte);
			case TypeCode.Byte:
				return typeof(byte);
			case TypeCode.Int16:
				return typeof(short);
			case TypeCode.UInt16:
				return typeof(ushort);
			case TypeCode.Int32:
				return typeof(int);
			case TypeCode.UInt32:
				return typeof(uint);
			case TypeCode.Int64:
				return typeof(long);
			case TypeCode.UInt64:
				return typeof(ulong);
			default:
				throw new NotSupportedException();
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000B539 File Offset: 0x00009739
		private static bool Is64BitTypeLoadedAsInt32(Type type)
		{
			return type == typeof(long) || type == typeof(ulong);
		}
	}
}
