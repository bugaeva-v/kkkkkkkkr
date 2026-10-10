using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Позволяет переопределять свойства, поля и атрибуты классов при использовании <see cref="T:System.Xml.Serialization.XmlSerializer" /> для сериализации или десериализации объекта.
	///       </summary>
	// Token: 0x020002CA RID: 714
	public class XmlAttributeOverrides
	{
		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Serialization.XmlAttributes" /> объект в коллекцию <see cref="T:System.Xml.Serialization.XmlAttributes" /> объектов.
		///         <paramref name="type" /> Определяет объект, должна быть переопределена <see cref="T:System.Xml.Serialization.XmlAttributes" /> объекта.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Переопределяемого объекта.
		///         </param>
		/// <param name="attributes">
		///           <see cref="T:System.Xml.Serialization.XmlAttributes" /> Объект, который представляет переопределенные атрибуты.
		///         </param>
		// Token: 0x06001B28 RID: 6952 RVA: 0x0009B7AF File Offset: 0x000999AF
		public void Add(Type type, XmlAttributes attributes)
		{
			this.Add(type, string.Empty, attributes);
		}

		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Serialization.XmlAttributes" /> объект в коллекцию <see cref="T:System.Xml.Serialization.XmlAttributes" /> объектов.
		///         <paramref name="type" /> Параметр указывает объект для переопределения.
		///         <paramref name="member" /> Параметр указывает имя переопределяемого члена.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объекта для переопределения.
		///         </param>
		/// <param name="member">
		///           Имя переопределяемого члена.
		///         </param>
		/// <param name="attributes">
		///           <see cref="T:System.Xml.Serialization.XmlAttributes" /> Объект, который представляет переопределенные атрибуты.
		///         </param>
		// Token: 0x06001B29 RID: 6953 RVA: 0x0009B7C0 File Offset: 0x000999C0
		public void Add(Type type, string member, XmlAttributes attributes)
		{
			Hashtable hashtable = (Hashtable)this.types[type];
			if (hashtable == null)
			{
				hashtable = new Hashtable();
				this.types.Add(type, hashtable);
			}
			else if (hashtable[member] != null)
			{
				throw new InvalidOperationException(Res.GetString("'{0}.{1}' already has attributes.", new object[]
				{
					type.FullName,
					member
				}));
			}
			hashtable.Add(member, attributes);
		}

		/// <summary>
		///         Возвращает объект, связанный с указанным типом базового класса.
		///       </summary>
		/// <param name="type">
		///           Базовый класс <see cref="T:System.Type" /> связанный с коллекцией атрибутов, которые необходимо получить.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlAttributes" /> Представляющий коллекцию переопределяемых атрибутов.
		///       </returns>
		// Token: 0x1700054D RID: 1357
		public XmlAttributes this[Type type]
		{
			get
			{
				return this[type, string.Empty];
			}
		}

		/// <summary>
		///         Возвращает объект, связанный с указанным типом (базового класса).
		///          Параметр члена указывает переопределяемого члена базового класса.
		///       </summary>
		/// <param name="type">
		///           Базовый класс <see cref="T:System.Type" /> связанный с коллекцией атрибутов, которые вы хотите.
		///         </param>
		/// <param name="member">
		///           Имя переопределяемого члена, которое задает <see cref="T:System.Xml.Serialization.XmlAttributes" /> для возврата.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlAttributes" /> Представляющий коллекцию переопределяемых атрибутов.
		///       </returns>
		// Token: 0x1700054E RID: 1358
		public XmlAttributes this[Type type, string member]
		{
			get
			{
				Hashtable hashtable = (Hashtable)this.types[type];
				if (hashtable == null)
				{
					return null;
				}
				return (XmlAttributes)hashtable[member];
			}
		}

		// Token: 0x040019CA RID: 6602
		private Hashtable types = new Hashtable();
	}
}
