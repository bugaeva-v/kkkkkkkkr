using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Позволяет переопределять атрибуты, примененные к свойствам, полям и классов при использовании <see cref="T:System.Xml.Serialization.XmlSerializer" /> для сериализации или десериализации объекта как закодированного SOAP.
	///       </summary>
	// Token: 0x020002AB RID: 683
	public class SoapAttributeOverrides
	{
		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Serialization.SoapAttributes" /> в коллекцию <see cref="T:System.Xml.Serialization.SoapAttributes" /> объектов.
		///         <paramref name="type" /> Определяет объект, должна быть переопределена <see cref="T:System.Xml.Serialization.SoapAttributes" />.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Переопределяемого объекта.
		///         </param>
		/// <param name="attributes">
		///           Объект <see cref="T:System.Xml.Serialization.SoapAttributes" /> представляющий переопределяемые атрибуты.
		///         </param>
		// Token: 0x060019C0 RID: 6592 RVA: 0x0009428D File Offset: 0x0009248D
		public void Add(Type type, SoapAttributes attributes)
		{
			this.Add(type, string.Empty, attributes);
		}

		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Serialization.SoapAttributes" /> в коллекцию <see cref="T:System.Xml.Serialization.SoapAttributes" /> объектов, содержащихся в <see cref="T:System.Xml.Serialization.SoapAttributeOverrides" />.
		///         <paramref name="type" /> Параметр указывает объект для переопределения <see cref="T:System.Xml.Serialization.SoapAttributes" />.
		///         <paramref name="member" /> Параметр указывает имя переопределяемого члена.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объекта для переопределения.
		///         </param>
		/// <param name="member">
		///           Имя переопределяемого члена.
		///         </param>
		/// <param name="attributes">
		///           Объект <see cref="T:System.Xml.Serialization.SoapAttributes" /> представляющий переопределяемые атрибуты.
		///         </param>
		// Token: 0x060019C1 RID: 6593 RVA: 0x0009429C File Offset: 0x0009249C
		public void Add(Type type, string member, SoapAttributes attributes)
		{
			Hashtable hashtable = (Hashtable)this.types[type];
			if (hashtable == null)
			{
				hashtable = new Hashtable();
				this.types.Add(type, hashtable);
			}
			else if (hashtable[member] != null)
			{
				throw new InvalidOperationException(Res.GetString("{0}. {1} already has attributes.", new object[]
				{
					type.FullName,
					member
				}));
			}
			hashtable.Add(member, attributes);
		}

		/// <summary>
		///         Возвращает объект, связанный с типом указанного (базовый класс).
		///       </summary>
		/// <param name="type">
		///           Базовый класс <see cref="T:System.Type" /> связанный с коллекцией атрибутов, которые необходимо получить.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.Serialization.SoapAttributes" /> представляющий коллекцию переопределяемых атрибутов.
		///       </returns>
		// Token: 0x170004EE RID: 1262
		public SoapAttributes this[Type type]
		{
			get
			{
				return this[type, string.Empty];
			}
		}

		/// <summary>
		///         Возвращает объект, связанный с типом указанного (базовый класс).
		///         <paramref name="member" /> Параметр задает переопределяемый член базового класса.
		///       </summary>
		/// <param name="type">
		///           Базовый класс <see cref="T:System.Type" /> связанный с коллекцией атрибутов, которые необходимо переопределить.
		///         </param>
		/// <param name="member">
		///           Имя переопределяемого члена, которое задает <see cref="T:System.Xml.Serialization.SoapAttributes" /> для возврата.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.Serialization.SoapAttributes" /> представляющий коллекцию переопределяемых атрибутов.
		///       </returns>
		// Token: 0x170004EF RID: 1263
		public SoapAttributes this[Type type, string member]
		{
			get
			{
				Hashtable hashtable = (Hashtable)this.types[type];
				if (hashtable == null)
				{
					return null;
				}
				return (SoapAttributes)hashtable[member];
			}
		}

		// Token: 0x04001941 RID: 6465
		private Hashtable types = new Hashtable();
	}
}
