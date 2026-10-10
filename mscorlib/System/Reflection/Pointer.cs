using System;
using System.Runtime.Serialization;
using Unity;

namespace System.Reflection
{
	/// <summary>Обеспечивает класс-оболочку для указателей.</summary>
	// Token: 0x020008B8 RID: 2232
	[CLSCompliant(false)]
	public sealed class Pointer : ISerializable
	{
		// Token: 0x060049DE RID: 18910 RVA: 0x000EF419 File Offset: 0x000ED619
		private unsafe Pointer(void* ptr, Type ptrType)
		{
			this._ptr = ptr;
			this._ptrType = ptrType;
		}

		/// <summary>Заключает предоставленный указатель на неуправляемую память и тип, сопоставленный этому указателю, в управляемый объекте-оболочку <see cref="T:System.Reflection.Pointer" />. Значение и тип сохраняются и поэтому могут быть доступны при вызове из машинного кода при вызове.</summary>
		/// <param name="ptr">Предоставленный указатель на неуправляемую память.</param>
		/// <param name="type">Тип, сопоставленный параметру <paramref name="ptr" />.</param>
		/// <returns>Объект-указатель.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является указателем.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060049DF RID: 18911 RVA: 0x000EF430 File Offset: 0x000ED630
		public unsafe static object Box(void* ptr, Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (!type.IsPointer)
			{
				throw new ArgumentException("Type must be a Pointer.", "ptr");
			}
			if (!type.IsRuntimeImplemented())
			{
				throw new ArgumentException("Type must be a type provided by the runtime.", "ptr");
			}
			return new Pointer(ptr, type);
		}

		/// <summary>Возвращает сохраненный указатель.</summary>
		/// <param name="ptr">Хранимый указатель.</param>
		/// <returns>Этот метод возвращает пустое значение.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="ptr" /> не является указателем.</exception>
		// Token: 0x060049E0 RID: 18912 RVA: 0x000EF488 File Offset: 0x000ED688
		public unsafe static void* Unbox(object ptr)
		{
			if (!(ptr is Pointer))
			{
				throw new ArgumentException("Type must be a Pointer.", "ptr");
			}
			return ((Pointer)ptr)._ptr;
		}

		/// <summary>Устанавливает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с именем файла, журналом слияния и дополнительными сведениями об исключении.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x060049E1 RID: 18913 RVA: 0x0001B98B File Offset: 0x00019B8B
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x000EF4AD File Offset: 0x000ED6AD
		internal Type GetPointerType()
		{
			return this._ptrType;
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x000EF4B5 File Offset: 0x000ED6B5
		internal IntPtr GetPointerValue()
		{
			return (IntPtr)this._ptr;
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x000173AD File Offset: 0x000155AD
		internal Pointer()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002F0D RID: 12045
		private unsafe readonly void* _ptr;

		// Token: 0x04002F0E RID: 12046
		private readonly Type _ptrType;
	}
}
