using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Определяет средства чтения, записи и методы для предварительно созданных, типизированных сериализаторов.
	///       </summary>
	// Token: 0x02000301 RID: 769
	public abstract class XmlSerializerImplementation
	{
		/// <summary>
		///         Возвращает объект чтения XML, используемый сериализатором.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> Используемый для чтения поток XML-документ или данных.
		///       </returns>
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual XmlSerializationReader Reader
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>
		///         Получает объект модуля записи XML для сериализатора.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> Используемый для записи в XML-документ или поток XML-данных.
		///       </returns>
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual XmlSerializationWriter Writer
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает коллекцию методов, который используется для считывания потока данных.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Hashtable" /> содержащий методы.
		///       </returns>
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual Hashtable ReadMethods
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает коллекцию методов, используемый для записи в поток данных.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Hashtable" /> содержащий методы.
		///       </returns>
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual Hashtable WriteMethods
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>
		///         Получает коллекцию типизированных сериализаторов, найденные в сборке.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Hashtable" /> содержащий типизированных сериализаторов.
		///       </returns>
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual Hashtable TypedSerializers
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>
		///         Возвращает значение, определяющее, может ли быть сериализован тип.
		///       </summary>
		/// <param name="type">
		///           Объект <see cref="T:System.Type" /> для сериализации.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если тип можно сериализовать; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001FE7 RID: 8167 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual bool CanSerialize(Type type)
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Возвращает сериализатор для указанного типа.
		///       </summary>
		/// <param name="type">
		///           Объект <see cref="T:System.Type" /> для сериализации.
		///         </param>
		/// <returns>
		///         Экземпляр типа, производного от <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса.
		///       </returns>
		// Token: 0x06001FE8 RID: 8168 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public virtual XmlSerializer GetSerializer(Type type)
		{
			throw new NotSupportedException();
		}
	}
}
