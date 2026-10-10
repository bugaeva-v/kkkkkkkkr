using System;

namespace System.Reflection
{
	/// <summary>Предоставляет миграцию от более старого, более простого ключа строгого имени к более длинному ключу с более сильным алгоритмом хэширования.</summary>
	// Token: 0x0200088E RID: 2190
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	public sealed class AssemblySignatureKeyAttribute : Attribute
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Reflection.AssemblySignatureKeyAttribute" />, используя указанный открытый ключ и подпись другой стороны.</summary>
		/// <param name="publicKey">Открытый ключ или ключ удостоверения.</param>
		/// <param name="countersignature">Подпись другой стороны, которая является подписью в составе ключа строгого имени.</param>
		// Token: 0x06004871 RID: 18545 RVA: 0x000EE163 File Offset: 0x000EC363
		public AssemblySignatureKeyAttribute(string publicKey, string countersignature)
		{
			this.PublicKey = publicKey;
			this.Countersignature = countersignature;
		}

		/// <summary>Возвращает открытый ключ для строгого имени, используемого для подписывания сборки.</summary>
		/// <returns>Открытый ключ для этой сборки.</returns>
		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x000EE179 File Offset: 0x000EC379
		public string PublicKey { get; }

		/// <summary>Возвращает подпись другой стороны для строгого имени для этой сборки.</summary>
		/// <returns>Подпись другой стороны для этого ключа подписи.</returns>
		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x000EE181 File Offset: 0x000EC381
		public string Countersignature { get; }
	}
}
