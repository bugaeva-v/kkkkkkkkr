using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>Токен, который возвращается, когда для события среды выполнения Windows добавляется обработчик событий. Токен используется для удаления обработчика события из события через некоторое время.</summary>
	// Token: 0x02000788 RID: 1928
	public struct EventRegistrationToken
	{
		// Token: 0x06004488 RID: 17544 RVA: 0x000E3B51 File Offset: 0x000E1D51
		internal EventRegistrationToken(ulong value)
		{
			this.m_value = value;
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x000E3B5A File Offset: 0x000E1D5A
		internal ulong Value
		{
			get
			{
				return this.m_value;
			}
		}

		/// <summary>Указывает, равны ли два экземпляра <see cref="T:System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken" />.</summary>
		/// <param name="left">Первый экземпляр для сравнения.</param>
		/// <param name="right">Второй экземпляр для сравнения.</param>
		/// <returns>
		///   <see langword="true" />, если два объекта равны; в противном случае <see langword="false" />.</returns>
		// Token: 0x0600448A RID: 17546 RVA: 0x000E3B62 File Offset: 0x000E1D62
		public static bool operator ==(EventRegistrationToken left, EventRegistrationToken right)
		{
			return left.Equals(right);
		}

		/// <summary>Показывает, являются ли два экземпляра <see cref="T:System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken" />неравными.</summary>
		/// <param name="left">Первый экземпляр для сравнения.</param>
		/// <param name="right">Второй экземпляр для сравнения.</param>
		/// <returns>Значение <see langword="true" /> если два экземпляра не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600448B RID: 17547 RVA: 0x000E3B77 File Offset: 0x000E1D77
		public static bool operator !=(EventRegistrationToken left, EventRegistrationToken right)
		{
			return !left.Equals(right);
		}

		/// <summary>Возвращает значение, показывающее, равен ли текущий объект указанному объекту.</summary>
		/// <param name="obj">Сравниваемый объект.</param>
		/// <returns>Значение <see langword="true" />, если текущий объект равен <paramref name="obj" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600448C RID: 17548 RVA: 0x000E3B90 File Offset: 0x000E1D90
		public override bool Equals(object obj)
		{
			return obj is EventRegistrationToken && ((EventRegistrationToken)obj).Value == this.Value;
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код данного экземпляра.</returns>
		// Token: 0x0600448D RID: 17549 RVA: 0x000E3BBD File Offset: 0x000E1DBD
		public override int GetHashCode()
		{
			return this.m_value.GetHashCode();
		}

		// Token: 0x04002C24 RID: 11300
		internal ulong m_value;
	}
}
