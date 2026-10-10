using System;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Представляет класс, описывающий способ маршалинга поля из управляемого в неуправляемый код. Этот класс не наследуется.</summary>
	// Token: 0x0200094A RID: 2378
	[ComVisible(true)]
	[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead.")]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class UnmanagedMarshal
	{
		// Token: 0x0600535B RID: 21339 RVA: 0x00105C9A File Offset: 0x00103E9A
		private UnmanagedMarshal(UnmanagedType maint, int cnt)
		{
			this.count = cnt;
			this.t = maint;
			this.tbase = maint;
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x00105CB7 File Offset: 0x00103EB7
		private UnmanagedMarshal(UnmanagedType maint, UnmanagedType elemt)
		{
			this.count = 0;
			this.t = maint;
			this.tbase = elemt;
		}

		/// <summary>Получает неуправляемый базовый тип. Это свойство доступно только для чтения.</summary>
		/// <returns>Объект <see langword="UnmanagedType" />.</returns>
		/// <exception cref="T:System.ArgumentException">Неуправляемый тип — не <see langword="LPArray" /> или <see langword="SafeArray" />.</exception>
		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x0600535D RID: 21341 RVA: 0x00105CD4 File Offset: 0x00103ED4
		public UnmanagedType BaseType
		{
			get
			{
				if (this.t == UnmanagedType.LPArray)
				{
					throw new ArgumentException();
				}
				if (this.t == UnmanagedType.SafeArray)
				{
					throw new ArgumentException();
				}
				return this.tbase;
			}
		}

		/// <summary>Получает номер элемента. Это свойство доступно только для чтения.</summary>
		/// <returns>Целое число, показывающее счетчик элементов.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент не является неуправляемым счетчиком элементов.</exception>
		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x0600535E RID: 21342 RVA: 0x00105CFC File Offset: 0x00103EFC
		public int ElementCount
		{
			get
			{
				return this.count;
			}
		}

		/// <summary>Указывает неуправляемый тип. Это свойство доступно только для чтения.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.InteropServices.UnmanagedType" />.</returns>
		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x0600535F RID: 21343 RVA: 0x00105D04 File Offset: 0x00103F04
		public UnmanagedType GetUnmanagedType
		{
			get
			{
				return this.t;
			}
		}

		/// <summary>Получает идентификатор GUID. Это свойство доступно только для чтения.</summary>
		/// <returns>Объект <see cref="T:System.Guid" />.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент не является пользовательским кодом маршалинга.</exception>
		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06005360 RID: 21344 RVA: 0x00105D0C File Offset: 0x00103F0C
		public Guid IIDGuid
		{
			get
			{
				return new Guid(this.guid);
			}
		}

		/// <summary>Задает массив (ByValArray) заданной длины для маршалинга в неуправляемый код.</summary>
		/// <param name="elemCount">Число элементов в массиве заданной длины.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.UnmanagedMarshal" />.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент не принадлежит к простому присущему данному объекту типу.</exception>
		// Token: 0x06005361 RID: 21345 RVA: 0x00105D19 File Offset: 0x00103F19
		public static UnmanagedMarshal DefineByValArray(int elemCount)
		{
			return new UnmanagedMarshal(UnmanagedType.ByValArray, elemCount);
		}

		/// <summary>Задает строку в фиксированном буфере массива (ByValTStr) для маршалинга в неуправляемый код.</summary>
		/// <param name="elemCount">Число элементов в фиксированном буфере массива.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.UnmanagedMarshal" />.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент не принадлежит к простому присущему данному объекту типу.</exception>
		// Token: 0x06005362 RID: 21346 RVA: 0x00105D23 File Offset: 0x00103F23
		public static UnmanagedMarshal DefineByValTStr(int elemCount)
		{
			return new UnmanagedMarshal(UnmanagedType.ByValTStr, elemCount);
		}

		/// <summary>Задает <see langword="LPArray" /> для маршалинга в неуправляемый код. Длина <see langword="LPArray" /> определяется во время выполнения в зависимости от размера реального массива, маршалинг которого выполняется.</summary>
		/// <param name="elemType">Неуправляемый тип для маршалинга массива.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.UnmanagedMarshal" />.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент не принадлежит к простому присущему данному объекту типу.</exception>
		// Token: 0x06005363 RID: 21347 RVA: 0x00105D2D File Offset: 0x00103F2D
		public static UnmanagedMarshal DefineLPArray(UnmanagedType elemType)
		{
			return new UnmanagedMarshal(UnmanagedType.LPArray, elemType);
		}

		/// <summary>Задает <see langword="SafeArray" /> для маршалинга в неуправляемый код.</summary>
		/// <param name="elemType">Базовый тип или <see langword="UnmanagedType" /> каждого элемента массива.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.UnmanagedMarshal" />.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент не принадлежит к простому присущему данному объекту типу.</exception>
		// Token: 0x06005364 RID: 21348 RVA: 0x00105D37 File Offset: 0x00103F37
		public static UnmanagedMarshal DefineSafeArray(UnmanagedType elemType)
		{
			return new UnmanagedMarshal(UnmanagedType.SafeArray, elemType);
		}

		/// <summary>Указывает заданный тип, для которого необходимо упаковать и передать в неуправляемый код.</summary>
		/// <param name="unmanagedType">Неуправляемый тип, в который следует упаковать и передать данный тип.</param>
		/// <returns>Объект <see cref="T:System.Reflection.Emit.UnmanagedMarshal" />.</returns>
		/// <exception cref="T:System.ArgumentException">Аргумент не принадлежит к простому присущему данному объекту типу.</exception>
		// Token: 0x06005365 RID: 21349 RVA: 0x00105D41 File Offset: 0x00103F41
		public static UnmanagedMarshal DefineUnmanagedMarshal(UnmanagedType unmanagedType)
		{
			return new UnmanagedMarshal(unmanagedType, unmanagedType);
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00105D4C File Offset: 0x00103F4C
		internal static UnmanagedMarshal DefineCustom(Type typeref, string cookie, string mtype, Guid id)
		{
			UnmanagedMarshal unmanagedMarshal = new UnmanagedMarshal(UnmanagedType.CustomMarshaler, UnmanagedType.CustomMarshaler);
			unmanagedMarshal.mcookie = cookie;
			unmanagedMarshal.marshaltype = mtype;
			unmanagedMarshal.marshaltyperef = typeref;
			if (id == Guid.Empty)
			{
				unmanagedMarshal.guid = string.Empty;
			}
			else
			{
				unmanagedMarshal.guid = id.ToString();
			}
			return unmanagedMarshal;
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x00105DA6 File Offset: 0x00103FA6
		internal static UnmanagedMarshal DefineLPArrayInternal(UnmanagedType elemType, int sizeConst, int sizeParamIndex)
		{
			return new UnmanagedMarshal(UnmanagedType.LPArray, elemType)
			{
				count = sizeConst,
				param_num = sizeParamIndex,
				has_size = true
			};
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x000173AD File Offset: 0x000155AD
		internal UnmanagedMarshal()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400333F RID: 13119
		private int count;

		// Token: 0x04003340 RID: 13120
		private UnmanagedType t;

		// Token: 0x04003341 RID: 13121
		private UnmanagedType tbase;

		// Token: 0x04003342 RID: 13122
		private string guid;

		// Token: 0x04003343 RID: 13123
		private string mcookie;

		// Token: 0x04003344 RID: 13124
		private string marshaltype;

		// Token: 0x04003345 RID: 13125
		internal Type marshaltyperef;

		// Token: 0x04003346 RID: 13126
		private int param_num;

		// Token: 0x04003347 RID: 13127
		private bool has_size;
	}
}
