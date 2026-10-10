using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Описывает объекты, которые содержат одновременно управляемый указатель на местоположение и представление типа среды выполнения, который может храниться в этом местоположении.</summary>
	// Token: 0x0200020F RID: 527
	[CLSCompliant(false)]
	[ComVisible(true)]
	[NonVersionable]
	public ref struct TypedReference
	{
		/// <summary>Создает объект типа <see langword="TypedReference" /> для поля, определяемого по указанному объекту и списку описаний полей.</summary>
		/// <param name="target">Объект, содержащий поле, описываемое первым элементом параметра <paramref name="flds" />.</param>
		/// <param name="flds">Список описаний полей, каждый элемент которого описывает поле, в котором содержится поле, описываемое следующим элементом. Каждое описываемое поле должно относиться к типу значения. Описания полей должны быть объектами типа <see langword="RuntimeFieldInfo" />, предоставляемыми системой типов.</param>
		/// <returns>Объект типа <see cref="T:System.TypedReference" /> для поля, описываемого последним элементом массива <paramref name="flds" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="target" /> или <paramref name="flds" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Элемент <paramref name="flds" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="flds" /> не содержит элементов.  
		///
		/// или - 
		/// Элемент <paramref name="flds" /> не является объектом <see langword="RuntimeFieldInfo" />.  
		///
		/// или - 
		/// Свойство <see cref="P:System.Reflection.FieldInfo.IsInitOnly" /> или <see cref="P:System.Reflection.FieldInfo.IsStatic" /> любого элемента <paramref name="flds" /> имеет значение <see langword="true" />.</exception>
		/// <exception cref="T:System.MissingMemberException">Параметр <paramref name="target" /> не содержит поле, описываемое первым элементом <paramref name="flds" />, или элемент <paramref name="flds" /> описывает поле, которое не содержится в поле, описываемом следующим элементом <paramref name="flds" />.  
		///
		/// или - 
		/// Поле, описываемое элементом <paramref name="flds" />, не является типом значения.</exception>
		// Token: 0x06001736 RID: 5942 RVA: 0x0005A738 File Offset: 0x00058938
		[CLSCompliant(false)]
		[SecurityCritical]
		public unsafe static TypedReference MakeTypedReference(object target, FieldInfo[] flds)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (flds == null)
			{
				throw new ArgumentNullException("flds");
			}
			if (flds.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Array must not be of length zero."), "flds");
			}
			IntPtr[] array = new IntPtr[flds.Length];
			RuntimeType runtimeType = (RuntimeType)target.GetType();
			for (int i = 0; i < flds.Length; i++)
			{
				RuntimeFieldInfo runtimeFieldInfo = flds[i] as RuntimeFieldInfo;
				if (runtimeFieldInfo == null)
				{
					throw new ArgumentException(Environment.GetResourceString("FieldInfo must be a runtime FieldInfo object."));
				}
				if (runtimeFieldInfo.IsStatic)
				{
					throw new ArgumentException(Environment.GetResourceString("Field in TypedReferences cannot be static or init only."));
				}
				if (runtimeType != runtimeFieldInfo.GetDeclaringTypeInternal() && !runtimeType.IsSubclassOf(runtimeFieldInfo.GetDeclaringTypeInternal()))
				{
					throw new MissingMemberException(Environment.GetResourceString("FieldInfo does not match the target Type."));
				}
				RuntimeType runtimeType2 = (RuntimeType)runtimeFieldInfo.FieldType;
				if (runtimeType2.IsPrimitive)
				{
					throw new ArgumentException(Environment.GetResourceString("TypedReferences cannot be redefined as primitives."));
				}
				if (i < flds.Length - 1 && !runtimeType2.IsValueType)
				{
					throw new MissingMemberException(Environment.GetResourceString("TypedReference can only be made on nested value Types."));
				}
				array[i] = runtimeFieldInfo.FieldHandle.Value;
				runtimeType = runtimeType2;
			}
			TypedReference result = default(TypedReference);
			TypedReference.InternalMakeTypedReference((void*)(&result), target, array, runtimeType);
			return result;
		}

		// Token: 0x06001737 RID: 5943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType);

		/// <summary>Возвращает хэш-код для этого объекта.</summary>
		/// <returns>Хэш-код данного объекта.</returns>
		// Token: 0x06001738 RID: 5944 RVA: 0x0005A880 File Offset: 0x00058A80
		public override int GetHashCode()
		{
			if (this.Type == IntPtr.Zero)
			{
				return 0;
			}
			return __reftype(this).GetHashCode();
		}

		/// <summary>Проверяет, эквивалентен ли данный объект указанному объекту.</summary>
		/// <param name="o">Объект, сравниваемый с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если этот объект эквивалентен заданному объекту; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не реализован.</exception>
		// Token: 0x06001739 RID: 5945 RVA: 0x0005A8A8 File Offset: 0x00058AA8
		public override bool Equals(object o)
		{
			throw new NotSupportedException(Environment.GetResourceString("This feature is not currently implemented."));
		}

		/// <summary>Преобразует указанную ссылку <see langword="TypedReference" /> в <see langword="Object" />.</summary>
		/// <param name="value">Преобразуемая структура <see langword="TypedReference" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, в который был преобразован объект типа <see langword="TypedReference" />.</returns>
		// Token: 0x0600173A RID: 5946 RVA: 0x0005A8B9 File Offset: 0x00058AB9
		[SecuritySafeCritical]
		public unsafe static object ToObject(TypedReference value)
		{
			return TypedReference.InternalToObject((void*)(&value));
		}

		// Token: 0x0600173B RID: 5947
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern object InternalToObject(void* value);

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x0005A8C3 File Offset: 0x00058AC3
		internal bool IsNull
		{
			get
			{
				return this.Value == IntPtr.Zero && this.Type == IntPtr.Zero;
			}
		}

		/// <summary>Возвращает тип целевого объекта для заданного объекта типа <see langword="TypedReference" />.</summary>
		/// <param name="value">Значение, для которого необходимо вернуть тип целевого объекта.</param>
		/// <returns>Тип целевого объекта для заданного объекта типа <see langword="TypedReference" />.</returns>
		// Token: 0x0600173D RID: 5949 RVA: 0x0005A8E9 File Offset: 0x00058AE9
		public static Type GetTargetType(TypedReference value)
		{
			return __reftype(value);
		}

		/// <summary>Возвращает внутренний дескриптор типа метаданных для указанного объекта типа <see langword="TypedReference" />.</summary>
		/// <param name="value">Объект типа <see langword="TypedReference" />, для которого запрашивается дескриптор типа.</param>
		/// <returns>Возвращает внутренний дескриптор типа метаданных для указанного объекта типа <see langword="TypedReference" />.</returns>
		// Token: 0x0600173E RID: 5950 RVA: 0x0005A8F3 File Offset: 0x00058AF3
		public static RuntimeTypeHandle TargetTypeToken(TypedReference value)
		{
			return __reftype(value).TypeHandle;
		}

		/// <summary>Преобразовывает указанное значение в объект типа <see langword="TypedReference" />. Этот метод не поддерживается.</summary>
		/// <param name="target">Целевой объект преобразования.</param>
		/// <param name="value">Преобразуемое значение.</param>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600173F RID: 5951 RVA: 0x0005A902 File Offset: 0x00058B02
		[SecuritySafeCritical]
		[CLSCompliant(false)]
		public static void SetTypedReference(TypedReference target, object value)
		{
			throw new NotImplementedException("SetTypedReference");
		}

		// Token: 0x0400162C RID: 5676
		private RuntimeTypeHandle type;

		// Token: 0x0400162D RID: 5677
		private IntPtr Value;

		// Token: 0x0400162E RID: 5678
		private IntPtr Type;
	}
}
