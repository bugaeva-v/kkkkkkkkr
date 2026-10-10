using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Представляет отсутствующий объект <see cref="T:System.Object" />. Этот класс не наследуется.</summary>
	// Token: 0x020008B0 RID: 2224
	public sealed class Missing : ISerializable
	{
		// Token: 0x06004970 RID: 18800 RVA: 0x0000259F File Offset: 0x0000079F
		private Missing()
		{
		}

		/// <summary>Устанавливает для объекта <see cref="T:System.Runtime.Serialization.SerializationInfo" /> сведения логического контекста, необходимые для воссоздания единственного экземпляра объекта <see cref="T:System.Reflection.Missing" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который будет заполняться сведениями о сериализации.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, представляющий контекст назначения сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004971 RID: 18801 RVA: 0x0001B98B File Offset: 0x00019B8B
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Представляет единственный экземпляр класса <see cref="T:System.Reflection.Missing" />.</summary>
		// Token: 0x04002EEF RID: 12015
		public static readonly Missing Value = new Missing();
	}
}
