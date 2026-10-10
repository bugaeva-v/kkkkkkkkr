using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Поддерживает все классы в иерархии классов .NET Framework и предоставляет низкоуровневые службы для производных классов. Он является исходным базовым классом для всех классов платформы .NET Framework и корнем иерархии типов.</summary>
	// Token: 0x02000247 RID: 583
	[ClassInterface(ClassInterfaceType.AutoDual)]
	[ComVisible(true)]
	[Serializable]
	public class Object
	{
		/// <summary>Определяет, равен ли заданный объект текущему объекту.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект равен текущему объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001AE0 RID: 6880 RVA: 0x00028426 File Offset: 0x00026626
		public virtual bool Equals(object obj)
		{
			return this == obj;
		}

		/// <summary>Определяет, считаются ли равными указанные экземпляры объектов.</summary>
		/// <param name="objA">Первый из сравниваемых объектов.</param>
		/// <param name="objB">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если указанные объекты равны; в противном случае — <see langword="false" />. Если оба параметра <paramref name="objA" /> и <paramref name="objB" /> имеют значение NULL, метод возвращает значение <see langword="true" />.</returns>
		// Token: 0x06001AE1 RID: 6881 RVA: 0x00064560 File Offset: 0x00062760
		public static bool Equals(object objA, object objB)
		{
			return objA == objB || (objA != null && objB != null && objA.Equals(objB));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Object" />.</summary>
		// Token: 0x06001AE2 RID: 6882 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public Object()
		{
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x06001AE3 RID: 6883 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected virtual void Finalize()
		{
		}

		/// <summary>Служит хэш-функцией по умолчанию.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x06001AE4 RID: 6884 RVA: 0x00064577 File Offset: 0x00062777
		public virtual int GetHashCode()
		{
			return object.InternalGetHashCode(this);
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" /> для текущего экземпляра.</summary>
		/// <returns>Точный тип текущего экземпляра в среде выполнения.</returns>
		// Token: 0x06001AE5 RID: 6885
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Type GetType();

		/// <summary>Создает неполную копию текущего объекта <see cref="T:System.Object" />.</summary>
		/// <returns>Неполная копия объекта <see cref="T:System.Object" />.</returns>
		// Token: 0x06001AE6 RID: 6886
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern object MemberwiseClone();

		/// <summary>Возвращает строку, представляющую текущий объект.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x06001AE7 RID: 6887 RVA: 0x0006457F File Offset: 0x0006277F
		public virtual string ToString()
		{
			return this.GetType().ToString();
		}

		/// <summary>Определяет, совпадают ли указанные экземпляры <see cref="T:System.Object" />.</summary>
		/// <param name="objA">Первый из сравниваемых объектов.</param>
		/// <param name="objB">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="objA" /> соответствует тому же экземпляру, что и параметр <paramref name="objB" />, или же оба они имеют значение NULL; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06001AE8 RID: 6888 RVA: 0x00028426 File Offset: 0x00026626
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool ReferenceEquals(object objA, object objB)
		{
			return objA == objB;
		}

		// Token: 0x06001AE9 RID: 6889
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int InternalGetHashCode(object o);

		// Token: 0x06001AEA RID: 6890 RVA: 0x00004BF9 File Offset: 0x00002DF9
		private void FieldGetter(string typeName, string fieldName, ref object val)
		{
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00004BF9 File Offset: 0x00002DF9
		private void FieldSetter(string typeName, string fieldName, object val)
		{
		}
	}
}
