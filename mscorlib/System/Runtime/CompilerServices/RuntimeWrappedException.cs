using System;
using System.Runtime.Serialization;
using System.Security;
using Unity;

namespace System.Runtime.CompilerServices
{
	/// <summary>Создает оболочку для исключения, не являющегося производным от класса <see cref="T:System.Exception" />. Этот класс не наследуется.</summary>
	// Token: 0x02000803 RID: 2051
	[Serializable]
	public sealed class RuntimeWrappedException : Exception
	{
		// Token: 0x0600461A RID: 17946 RVA: 0x000E58C2 File Offset: 0x000E3AC2
		public RuntimeWrappedException(object thrownObject) : base("An object that does not derive from System.Exception has been wrapped in a RuntimeWrappedException.")
		{
			base.HResult = -2146233026;
			this._wrappedException = thrownObject;
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x000E58E1 File Offset: 0x000E3AE1
		private RuntimeWrappedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._wrappedException = info.GetValue("WrappedException", typeof(object));
		}

		/// <summary>Задает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий информацию об исключении.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта по возникающему исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600461C RID: 17948 RVA: 0x000E5906 File Offset: 0x000E3B06
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("WrappedException", this._wrappedException, typeof(object));
		}

		/// <summary>Возвращает объект, заключенный в оболочку объекта <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" />.</summary>
		/// <returns>Объект, заключенный в оболочку объекта <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" />.</returns>
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x000E592B File Offset: 0x000E3B2B
		public object WrappedException
		{
			get
			{
				return this._wrappedException;
			}
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x000173AD File Offset: 0x000155AD
		internal RuntimeWrappedException()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002D40 RID: 11584
		private object _wrappedException;
	}
}
