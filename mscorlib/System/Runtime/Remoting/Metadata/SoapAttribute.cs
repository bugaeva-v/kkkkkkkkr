using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Предоставляет назначенные по умолчанию функциональные возможности для всех атрибутов SOAP.</summary>
	// Token: 0x020005D8 RID: 1496
	[ComVisible(true)]
	public class SoapAttribute : Attribute
	{
		/// <summary>Возвращает или задает значение, указывающее на необходимость вложения типа при сериализации протокола SOAP.</summary>
		/// <returns>
		///   <see langword="true" />, если целевой объект необходимо вложить во время сериализации SOAP; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x000CAF8E File Offset: 0x000C918E
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x000CAF96 File Offset: 0x000C9196
		public virtual bool Embedded
		{
			get
			{
				return this._nested;
			}
			set
			{
				this._nested = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, будет ли сериализован целевой объект текущего атрибута как атрибут XML вместо поля XML.</summary>
		/// <returns>
		///   <see langword="true" />, если целевой объект текущего атрибута необходимо сериализовать в качестве атрибута XML; <see langword="false" />, если целевой объект необходимо сериализовать в качестве подэлемента.</returns>
		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x000CAF9F File Offset: 0x000C919F
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x000CAFA7 File Offset: 0x000C91A7
		public virtual bool UseAttribute
		{
			get
			{
				return this._useAttribute;
			}
			set
			{
				this._useAttribute = value;
			}
		}

		/// <summary>Возвращает или задает имя пространства имен XML.</summary>
		/// <returns>Имя пространства имен XML, под которым сериализуется целевой объект текущего атрибута.</returns>
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x000CAFB0 File Offset: 0x000C91B0
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x000CAFB8 File Offset: 0x000C91B8
		public virtual string XmlNamespace
		{
			get
			{
				return this.ProtXmlNamespace;
			}
			set
			{
				this.ProtXmlNamespace = value;
			}
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x000CAFC1 File Offset: 0x000C91C1
		internal virtual void SetReflectionObject(object reflectionObject)
		{
			this.ReflectInfo = reflectionObject;
		}

		// Token: 0x040025FE RID: 9726
		private bool _nested;

		// Token: 0x040025FF RID: 9727
		private bool _useAttribute;

		/// <summary>Имя пространства имен XML, под которым сериализуется текущий атрибут SOAP.</summary>
		// Token: 0x04002600 RID: 9728
		protected string ProtXmlNamespace;

		/// <summary>Объект отражения, используемый классами атрибутов, производными от класса <see cref="T:System.Runtime.Remoting.Metadata.SoapAttribute" />, для задания информации о сериализации XML.</summary>
		// Token: 0x04002601 RID: 9729
		protected object ReflectInfo;
	}
}
