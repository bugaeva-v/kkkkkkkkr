using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Предоставляет список аргументов переменной длины, то есть параметры функции, принимающей переменное число аргументов.</summary>
	// Token: 0x02000229 RID: 553
	[StructLayout(LayoutKind.Auto)]
	public struct ArgIterator
	{
		// Token: 0x060018CC RID: 6348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Setup(IntPtr argsp, IntPtr start);

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.ArgIterator" /> с использованием заданного списка аргументов.</summary>
		/// <param name="arglist">Список, состоящий из обязательных и необязательных аргументов.</param>
		// Token: 0x060018CD RID: 6349 RVA: 0x0005E048 File Offset: 0x0005C248
		public ArgIterator(RuntimeArgumentHandle arglist)
		{
			this.sig = IntPtr.Zero;
			this.args = IntPtr.Zero;
			this.next_arg = (this.num_args = 0);
			if (arglist.args == IntPtr.Zero)
			{
				throw new PlatformNotSupportedException();
			}
			this.Setup(arglist.args, IntPtr.Zero);
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.ArgIterator" />, используя заданный список аргументов и указатель на элемент в этом списке.</summary>
		/// <param name="arglist">Список, состоящий из обязательных и необязательных аргументов.</param>
		/// <param name="ptr">Указатель на аргумент в списке <paramref name="arglist" />, доступ к которому осуществляется первым, или первый обязательный аргумент в <paramref name="arglist" />, если <paramref name="ptr" /> имеет значение <see langword="null" />.</param>
		// Token: 0x060018CE RID: 6350 RVA: 0x0005E0A8 File Offset: 0x0005C2A8
		[CLSCompliant(false)]
		public unsafe ArgIterator(RuntimeArgumentHandle arglist, void* ptr)
		{
			this.sig = IntPtr.Zero;
			this.args = IntPtr.Zero;
			this.next_arg = (this.num_args = 0);
			if (arglist.args == IntPtr.Zero)
			{
				throw new PlatformNotSupportedException();
			}
			this.Setup(arglist.args, (IntPtr)ptr);
		}

		/// <summary>Завершает обработку списка аргументов переменной длины, представленного этим экземпляром.</summary>
		// Token: 0x060018CF RID: 6351 RVA: 0x0005E107 File Offset: 0x0005C307
		public void End()
		{
			this.next_arg = this.num_args;
		}

		/// <summary>Этот метод не поддерживается и всегда выбрасывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="o">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Это сравнение не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x060018D0 RID: 6352 RVA: 0x0005E115 File Offset: 0x0005C315
		public override bool Equals(object o)
		{
			throw new NotSupportedException("ArgIterator does not support Equals.");
		}

		/// <summary>Возвращает хэш-код для этого объекта.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060018D1 RID: 6353 RVA: 0x0005E121 File Offset: 0x0005C321
		public override int GetHashCode()
		{
			return this.sig.GetHashCode();
		}

		/// <summary>Возвращает следующий аргумент из списка аргументов переменной длины.</summary>
		/// <returns>Следующий аргумент как объект <see cref="T:System.TypedReference" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Предпринята попытка чтения за концом списка.</exception>
		// Token: 0x060018D2 RID: 6354 RVA: 0x0005E130 File Offset: 0x0005C330
		[CLSCompliant(false)]
		public unsafe TypedReference GetNextArg()
		{
			if (this.num_args == this.next_arg)
			{
				throw new InvalidOperationException("Invalid iterator position.");
			}
			TypedReference result = default(TypedReference);
			this.IntGetNextArg((void*)(&result));
			return result;
		}

		// Token: 0x060018D3 RID: 6355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe extern void IntGetNextArg(void* res);

		/// <summary>Возвращает следующий аргумент заданного типа из списка аргументов переменной длины.</summary>
		/// <param name="rth">Дескриптор типа среды CLR, определяющий тип извлекаемого аргумента.</param>
		/// <returns>Следующий аргумент как объект <see cref="T:System.TypedReference" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Предпринята попытка чтения за концом списка.</exception>
		/// <exception cref="T:System.ArgumentNullException">Указатель на остальные аргументы равен нулю.</exception>
		// Token: 0x060018D4 RID: 6356 RVA: 0x0005E168 File Offset: 0x0005C368
		[CLSCompliant(false)]
		public unsafe TypedReference GetNextArg(RuntimeTypeHandle rth)
		{
			if (this.num_args == this.next_arg)
			{
				throw new InvalidOperationException("Invalid iterator position.");
			}
			TypedReference result = default(TypedReference);
			this.IntGetNextArgWithType((void*)(&result), rth.Value);
			return result;
		}

		// Token: 0x060018D5 RID: 6357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe extern void IntGetNextArgWithType(void* res, IntPtr rth);

		/// <summary>Возвращает тип следующего аргумента.</summary>
		/// <returns>Тип следующего аргумента.</returns>
		// Token: 0x060018D6 RID: 6358 RVA: 0x0005E1A7 File Offset: 0x0005C3A7
		public RuntimeTypeHandle GetNextArgType()
		{
			if (this.num_args == this.next_arg)
			{
				throw new InvalidOperationException("Invalid iterator position.");
			}
			return new RuntimeTypeHandle(this.IntGetNextArgType());
		}

		// Token: 0x060018D7 RID: 6359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr IntGetNextArgType();

		/// <summary>Возвращает число оставшихся аргументов в списке.</summary>
		/// <returns>Число оставшихся аргументов.</returns>
		// Token: 0x060018D8 RID: 6360 RVA: 0x0005E1CD File Offset: 0x0005C3CD
		public int GetRemainingCount()
		{
			return this.num_args - this.next_arg;
		}

		// Token: 0x040016D7 RID: 5847
		private IntPtr sig;

		// Token: 0x040016D8 RID: 5848
		private IntPtr args;

		// Token: 0x040016D9 RID: 5849
		private int next_arg;

		// Token: 0x040016DA RID: 5850
		private int num_args;
	}
}
