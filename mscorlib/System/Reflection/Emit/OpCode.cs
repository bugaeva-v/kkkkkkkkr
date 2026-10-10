using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Описывает инструкцию IL.</summary>
	// Token: 0x0200093A RID: 2362
	[ComVisible(true)]
	public readonly struct OpCode : IEquatable<OpCode>
	{
		// Token: 0x060051EB RID: 20971 RVA: 0x00100500 File Offset: 0x000FE700
		internal OpCode(int p, int q)
		{
			this.op1 = (byte)(p & 255);
			this.op2 = (byte)(p >> 8 & 255);
			this.push = (byte)(p >> 16 & 255);
			this.pop = (byte)(p >> 24 & 255);
			this.size = (byte)(q & 255);
			this.type = (byte)(q >> 8 & 255);
			this.args = (byte)(q >> 16 & 255);
			this.flow = (byte)(q >> 24 & 255);
		}

		/// <summary>Возвращает созданный для данного <see langword="Opcode" /> хэш-код.</summary>
		/// <returns>Хэш-код данного экземпляра.</returns>
		// Token: 0x060051EC RID: 20972 RVA: 0x0010058D File Offset: 0x000FE78D
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		/// <summary>Проверяет, идентичен ли указанный объект объекту <see langword="Opcode" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с данным объектом.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="Opcode" /> и равен этому объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060051ED RID: 20973 RVA: 0x0010059C File Offset: 0x000FE79C
		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is OpCode))
			{
				return false;
			}
			OpCode opCode = (OpCode)obj;
			return opCode.op1 == this.op1 && opCode.op2 == this.op2;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.OpCode" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.OpCode" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060051EE RID: 20974 RVA: 0x001005DB File Offset: 0x000FE7DB
		public bool Equals(OpCode obj)
		{
			return obj.op1 == this.op1 && obj.op2 == this.op2;
		}

		/// <summary>Возвращает данный <see langword="Opcode" /> в виде объекта <see cref="T:System.String" />.</summary>
		/// <returns>Строка, содержащая имя объекта <see langword="Opcode" />.</returns>
		// Token: 0x060051EF RID: 20975 RVA: 0x001005FB File Offset: 0x000FE7FB
		public override string ToString()
		{
			return this.Name;
		}

		/// <summary>Имя инструкции IL.</summary>
		/// <returns>Только для чтения. Имя инструкции IL.</returns>
		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x00100603 File Offset: 0x000FE803
		public string Name
		{
			get
			{
				if (this.op1 == 255)
				{
					return OpCodeNames.names[(int)this.op2];
				}
				return OpCodeNames.names[256 + (int)this.op2];
			}
		}

		/// <summary>Размер инструкции IL.</summary>
		/// <returns>Только для чтения. Размер инструкции IL.</returns>
		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x060051F1 RID: 20977 RVA: 0x00100631 File Offset: 0x000FE831
		public int Size
		{
			get
			{
				return (int)this.size;
			}
		}

		/// <summary>Тип инструкции IL.</summary>
		/// <returns>Только для чтения. Тип инструкции IL.</returns>
		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x00100639 File Offset: 0x000FE839
		public OpCodeType OpCodeType
		{
			get
			{
				return (OpCodeType)this.type;
			}
		}

		/// <summary>Тип операнда инструкции IL.</summary>
		/// <returns>Только для чтения. Тип операнда IL.</returns>
		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x060051F3 RID: 20979 RVA: 0x00100641 File Offset: 0x000FE841
		public OperandType OperandType
		{
			get
			{
				return (OperandType)this.args;
			}
		}

		/// <summary>Производительность управления потоком для инструкции IL.</summary>
		/// <returns>Только для чтения. Тип управления потоком.</returns>
		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x060051F4 RID: 20980 RVA: 0x00100649 File Offset: 0x000FE849
		public FlowControl FlowControl
		{
			get
			{
				return (FlowControl)this.flow;
			}
		}

		/// <summary>Описывает, каким образом инструкция IL извлекает данные из стека.</summary>
		/// <returns>Только для чтения. Способ, с помощью которого инструкция IL извлекает данные из стека.</returns>
		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x060051F5 RID: 20981 RVA: 0x00100651 File Offset: 0x000FE851
		public StackBehaviour StackBehaviourPop
		{
			get
			{
				return (StackBehaviour)this.pop;
			}
		}

		/// <summary>Описывает, каким образом инструкция IL помещает операнд в стек.</summary>
		/// <returns>Только для чтения. Способ, с помощью которого инструкция IL помещает операнд в стек.</returns>
		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x00100659 File Offset: 0x000FE859
		public StackBehaviour StackBehaviourPush
		{
			get
			{
				return (StackBehaviour)this.push;
			}
		}

		/// <summary>Возвращает числовое значение инструкции на промежуточном языке (IL).</summary>
		/// <returns>Только для чтения. Числовое значение инструкции IL.</returns>
		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x060051F7 RID: 20983 RVA: 0x00100661 File Offset: 0x000FE861
		public short Value
		{
			get
			{
				if (this.size == 1)
				{
					return (short)this.op2;
				}
				return (short)((int)this.op1 << 8 | (int)this.op2);
			}
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.OpCode" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.OpCode" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.OpCode" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060051F8 RID: 20984 RVA: 0x00100683 File Offset: 0x000FE883
		public static bool operator ==(OpCode a, OpCode b)
		{
			return a.op1 == b.op1 && a.op2 == b.op2;
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.OpCode" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.OpCode" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.OpCode" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060051F9 RID: 20985 RVA: 0x001006A3 File Offset: 0x000FE8A3
		public static bool operator !=(OpCode a, OpCode b)
		{
			return a.op1 != b.op1 || a.op2 != b.op2;
		}

		// Token: 0x040031FF RID: 12799
		internal readonly byte op1;

		// Token: 0x04003200 RID: 12800
		internal readonly byte op2;

		// Token: 0x04003201 RID: 12801
		private readonly byte push;

		// Token: 0x04003202 RID: 12802
		private readonly byte pop;

		// Token: 0x04003203 RID: 12803
		private readonly byte size;

		// Token: 0x04003204 RID: 12804
		private readonly byte type;

		// Token: 0x04003205 RID: 12805
		private readonly byte args;

		// Token: 0x04003206 RID: 12806
		private readonly byte flow;
	}
}
