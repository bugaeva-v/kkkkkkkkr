using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace System
{
	/// <summary>
	///   <see cref="T:System.RuntimeMethodHandle" /> является дескриптором внутреннего представления метаданных метода.</summary>
	// Token: 0x0200024B RID: 587
	[ComVisible(true)]
	[Serializable]
	public struct RuntimeMethodHandle : ISerializable
	{
		// Token: 0x06001AFA RID: 6906 RVA: 0x00064706 File Offset: 0x00062906
		internal RuntimeMethodHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00064710 File Offset: 0x00062910
		private RuntimeMethodHandle(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			RuntimeMethodInfo runtimeMethodInfo = (RuntimeMethodInfo)info.GetValue("MethodObj", typeof(RuntimeMethodInfo));
			this.value = runtimeMethodInfo.MethodHandle.Value;
			if (this.value == IntPtr.Zero)
			{
				throw new SerializationException("Insufficient state.");
			}
		}

		/// <summary>Возвращает значение данного экземпляра.</summary>
		/// <returns>
		///   <see cref="T:System.RuntimeMethodHandle" />, являющийся дескриптором внутреннего представления метаданных метода.</returns>
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x00064777 File Offset: 0x00062977
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>Заполняет <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, которые необходимы для десериализации поля, представленного данным экземпляром.</summary>
		/// <param name="info">Объект, который требуется заполнить информацией о сериализации.</param>
		/// <param name="context">(Зарезервирован.) Место для хранения и извлечения сериализованных данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">
		///   <see cref="P:System.RuntimeMethodHandle.Value" /> недопустим.</exception>
		// Token: 0x06001AFD RID: 6909 RVA: 0x00064780 File Offset: 0x00062980
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			if (this.value == IntPtr.Zero)
			{
				throw new SerializationException("Object fields may not be properly initialized");
			}
			info.AddValue("MethodObj", (RuntimeMethodInfo)MethodBase.GetMethodFromHandle(this), typeof(RuntimeMethodInfo));
		}

		// Token: 0x06001AFE RID: 6910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetFunctionPointer(IntPtr m);

		/// <summary>Получает указатель на метод, представленный данным экземпляром.</summary>
		/// <returns>Указатель на метод, представленный данным экземпляром.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код не имеет необходимых разрешений для выполнения этой операции.</exception>
		// Token: 0x06001AFF RID: 6911 RVA: 0x000647DD File Offset: 0x000629DD
		public IntPtr GetFunctionPointer()
		{
			return RuntimeMethodHandle.GetFunctionPointer(this.value);
		}

		/// <summary>Определяет равенство этого экземпляра указанному объекту.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, сравниваемый с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значением параметра <paramref name="obj" /> является <see cref="T:System.RuntimeMethodHandle" />, равный значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001B00 RID: 6912 RVA: 0x000647EC File Offset: 0x000629EC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeMethodHandle)obj).Value;
		}

		/// <summary>Определяет равенство этого экземпляра указанному объекту <see cref="T:System.RuntimeMethodHandle" />.</summary>
		/// <param name="handle">Объект <see cref="T:System.RuntimeMethodHandle" />, сравниваемый с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="handle" /> равно значению этого экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001B01 RID: 6913 RVA: 0x00064834 File Offset: 0x00062A34
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public bool Equals(RuntimeMethodHandle handle)
		{
			return this.value == handle.Value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001B02 RID: 6914 RVA: 0x00064848 File Offset: 0x00062A48
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		/// <summary>Показывает, равны ли два экземпляра <see cref="T:System.RuntimeMethodHandle" />.</summary>
		/// <param name="left">Объект <see cref="T:System.RuntimeMethodHandle" /> для сравнения с параметром <paramref name="right" />.</param>
		/// <param name="right">Объект <see cref="T:System.RuntimeMethodHandle" /> для сравнения с параметром <paramref name="left" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="left" /> равно значению параметра <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001B03 RID: 6915 RVA: 0x00064855 File Offset: 0x00062A55
		public static bool operator ==(RuntimeMethodHandle left, RuntimeMethodHandle right)
		{
			return left.Equals(right);
		}

		/// <summary>Определяет, являются ли два экземпляра <see cref="T:System.RuntimeMethodHandle" /> неравными.</summary>
		/// <param name="left">Объект <see cref="T:System.RuntimeMethodHandle" /> для сравнения с параметром <paramref name="right" />.</param>
		/// <param name="right">Объект <see cref="T:System.RuntimeMethodHandle" /> для сравнения с параметром <paramref name="left" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="left" /> не равно значению параметра <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001B04 RID: 6916 RVA: 0x0006485F File Offset: 0x00062A5F
		public static bool operator !=(RuntimeMethodHandle left, RuntimeMethodHandle right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0006486C File Offset: 0x00062A6C
		internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Type[] genericArguments = method.GetGenericArguments();
			stringBuilder.Append("[");
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(genericArguments[i].Name);
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x000648D1 File Offset: 0x00062AD1
		internal bool IsNullHandle()
		{
			return this.value == IntPtr.Zero;
		}

		// Token: 0x04001779 RID: 6009
		private IntPtr value;
	}
}
