using System;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет элемент <see langword="&lt;DataReference&gt;" />, который используется при шифровании XML. Этот класс не наследуется.</summary>
	// Token: 0x02000032 RID: 50
	public sealed class DataReference : EncryptedReference
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.DataReference" />.</summary>
		// Token: 0x06000109 RID: 265 RVA: 0x000058A0 File Offset: 0x00003AA0
		public DataReference()
		{
			base.ReferenceType = "DataReference";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.DataReference" /> с помощью указанного универсального кода ресурса (URI).</summary>
		/// <param name="uri">Универсальный код ресурса (URI), указывающий на зашифрованные данные.</param>
		// Token: 0x0600010A RID: 266 RVA: 0x000058B3 File Offset: 0x00003AB3
		public DataReference(string uri) : base(uri)
		{
			base.ReferenceType = "DataReference";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.DataReference" /> с помощью указанного универсального кода ресурса (URI) и объекта <see cref="T:System.Security.Cryptography.Xml.TransformChain" />.</summary>
		/// <param name="uri">Универсальный код ресурса (URI), указывающий на зашифрованные данные.</param>
		/// <param name="transformChain">Объект <see cref="T:System.Security.Cryptography.Xml.TransformChain" />, описывающий преобразования, которые применяются к зашифрованным данным.</param>
		// Token: 0x0600010B RID: 267 RVA: 0x000058C7 File Offset: 0x00003AC7
		public DataReference(string uri, TransformChain transformChain) : base(uri, transformChain)
		{
			base.ReferenceType = "DataReference";
		}
	}
}
