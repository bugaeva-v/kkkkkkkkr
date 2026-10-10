using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Указывает, что поле может отсутствовать из сериализованного потока, таким образом, <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> и <see cref="T:System.Runtime.Serialization.Formatters.Soap.SoapFormatter" /> не создают исключение.</summary>
	// Token: 0x0200066C RID: 1644
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public sealed class OptionalFieldAttribute : Attribute
	{
		/// <summary>Получает или задает номер версии, указывающий когда добавлено дополнительное поле.</summary>
		/// <returns>Версия объекта <see cref="T:System.Runtime.Serialization.OptionalFieldAttribute" />.</returns>
		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x000D4A67 File Offset: 0x000D2C67
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x000D4A6F File Offset: 0x000D2C6F
		public int VersionAdded
		{
			get
			{
				return this.versionAdded;
			}
			set
			{
				if (value < 1)
				{
					throw new ArgumentException(Environment.GetResourceString("Version value must be positive."));
				}
				this.versionAdded = value;
			}
		}

		// Token: 0x04002781 RID: 10113
		private int versionAdded = 1;
	}
}
