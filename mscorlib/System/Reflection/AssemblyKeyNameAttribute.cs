using System;

namespace System.Reflection
{
	/// <summary>Задает имя контейнера ключей в поставщике служб шифрования, содержащего пару ключей, которая используется для создания строгого имени.</summary>
	// Token: 0x0200088A RID: 2186
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyKeyNameAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyKeyNameAttribute" /> с именем контейнера, содержащего пару ключей, используемую для создания строгого имени для сборки с данным атрибутом.</summary>
		/// <param name="keyName">Имя контейнера, содержащего пару ключей.</param>
		// Token: 0x0600486A RID: 18538 RVA: 0x000EE10F File Offset: 0x000EC30F
		public AssemblyKeyNameAttribute(string keyName)
		{
			this.KeyName = keyName;
		}

		/// <summary>Возвращает имя контейнера, содержащего пару ключей, используемую для создания строгого имени для сборки с данным атрибутом.</summary>
		/// <returns>Строка, содержащая имя контейнера, который содержит соответствующую пару ключей.</returns>
		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x000EE11E File Offset: 0x000EC31E
		public string KeyName { get; }
	}
}
