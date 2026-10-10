using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Представляет поле, в котором используется внутренний маркер метаданных.</summary>
	// Token: 0x0200024A RID: 586
	[ComVisible(true)]
	[Serializable]
	public struct RuntimeFieldHandle : ISerializable
	{
		// Token: 0x06001AEC RID: 6892 RVA: 0x0006458C File Offset: 0x0006278C
		internal RuntimeFieldHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00064598 File Offset: 0x00062798
		private RuntimeFieldHandle(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			RuntimeFieldInfo runtimeFieldInfo = (RuntimeFieldInfo)info.GetValue("FieldObj", typeof(RuntimeFieldInfo));
			this.value = runtimeFieldInfo.FieldHandle.Value;
			if (this.value == IntPtr.Zero)
			{
				throw new SerializationException("Insufficient state.");
			}
		}

		/// <summary>Возвращает дескриптор поля, представленного текущим экземпляром.</summary>
		/// <returns>Объект <see cref="T:System.IntPtr" />, содержащий дескриптор поля, представленного текущим экземпляром.</returns>
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x000645FF File Offset: 0x000627FF
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00064607 File Offset: 0x00062807
		internal bool IsNullHandle()
		{
			return this.value == IntPtr.Zero;
		}

		/// <summary>Заполняет <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, которые необходимы для десериализации поля, представленного текущим экземпляром.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который требуется заполнить данными сериализации.</param>
		/// <param name="context">(Зарезервирован.) Место для хранения и извлечения сериализованных данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Свойство <see cref="P:System.RuntimeFieldHandle.Value" /> текущего экземпляра не является допустимым дескриптором.</exception>
		// Token: 0x06001AF0 RID: 6896 RVA: 0x0006461C File Offset: 0x0006281C
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
			info.AddValue("FieldObj", (RuntimeFieldInfo)FieldInfo.GetFieldFromHandle(this), typeof(RuntimeFieldInfo));
		}

		/// <summary>Указывает, равнозначен ли текущий экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является объектом <see cref="T:System.RuntimeFieldHandle" /> и равен значению текущего экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001AF1 RID: 6897 RVA: 0x0006467C File Offset: 0x0006287C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeFieldHandle)obj).Value;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.RuntimeFieldHandle" />.</summary>
		/// <param name="handle">
		///   <see cref="T:System.RuntimeFieldHandle" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="handle" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001AF2 RID: 6898 RVA: 0x000646C4 File Offset: 0x000628C4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public bool Equals(RuntimeFieldHandle handle)
		{
			return this.value == handle.Value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>32-разрядное целое число со знаком, являющееся хэш-кодом для данного экземпляра.</returns>
		// Token: 0x06001AF3 RID: 6899 RVA: 0x000646D8 File Offset: 0x000628D8
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.RuntimeFieldHandle" />.</summary>
		/// <param name="left">Объект <see cref="T:System.RuntimeFieldHandle" />, используемый для сравнения с <paramref name="right" />.</param>
		/// <param name="right">Объект <see cref="T:System.RuntimeFieldHandle" />, используемый для сравнения с <paramref name="left" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001AF4 RID: 6900 RVA: 0x000646E5 File Offset: 0x000628E5
		public static bool operator ==(RuntimeFieldHandle left, RuntimeFieldHandle right)
		{
			return left.Equals(right);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.RuntimeFieldHandle" />.</summary>
		/// <param name="left">Объект <see cref="T:System.RuntimeFieldHandle" />, используемый для сравнения с <paramref name="right" />.</param>
		/// <param name="right">Объект <see cref="T:System.RuntimeFieldHandle" />, используемый для сравнения с <paramref name="left" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001AF5 RID: 6901 RVA: 0x000646EF File Offset: 0x000628EF
		public static bool operator !=(RuntimeFieldHandle left, RuntimeFieldHandle right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06001AF6 RID: 6902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetValueInternal(FieldInfo fi, object obj, object value);

		// Token: 0x06001AF7 RID: 6903 RVA: 0x000646FC File Offset: 0x000628FC
		internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized)
		{
			RuntimeFieldHandle.SetValueInternal(field, obj, value);
		}

		// Token: 0x06001AF8 RID: 6904
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern object GetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, RuntimeType contextType);

		// Token: 0x06001AF9 RID: 6905
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType);

		// Token: 0x04001778 RID: 6008
		private IntPtr value;
	}
}
