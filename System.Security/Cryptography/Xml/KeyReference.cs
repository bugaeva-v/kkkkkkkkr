using System;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет элемент <see langword="&lt;KeyReference&gt;" />, который используется при шифровании XML. Этот класс не наследуется.</summary>
	// Token: 0x02000047 RID: 71
	public sealed class KeyReference : EncryptedReference
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> для XML-шифрования.</summary>
		// Token: 0x060001E3 RID: 483 RVA: 0x00008D60 File Offset: 0x00006F60
		public KeyReference()
		{
			base.ReferenceType = "KeyReference";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> для XML-шифрования с помощью указанного URI.</summary>
		/// <param name="uri">Код URI, указывающий на зашифрованный ключ.</param>
		// Token: 0x060001E4 RID: 484 RVA: 0x00008D73 File Offset: 0x00006F73
		public KeyReference(string uri) : base(uri)
		{
			base.ReferenceType = "KeyReference";
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyReference" /> для XML-шифрования с помощью указанного URI и объекта <see cref="T:System.Security.Cryptography.Xml.TransformChain" />.</summary>
		/// <param name="uri">Код URI, указывающий на зашифрованный ключ.</param>
		/// <param name="transformChain">Объект <see cref="T:System.Security.Cryptography.Xml.TransformChain" />, описывающий преобразования, которые применяются к зашифрованному ключу.</param>
		// Token: 0x060001E5 RID: 485 RVA: 0x00008D87 File Offset: 0x00006F87
		public KeyReference(string uri, TransformChain transformChain) : base(uri, transformChain)
		{
			base.ReferenceType = "KeyReference";
		}
	}
}
