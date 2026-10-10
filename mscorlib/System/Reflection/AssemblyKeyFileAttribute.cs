using System;

namespace System.Reflection
{
	/// <summary>Задает имя файла, содержащего пару ключей, которая используется для создания строгого имени.</summary>
	// Token: 0x02000889 RID: 2185
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyKeyFileAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="AssemblyKeyFileAttribute" /> с именем файла, содержащего пару ключей, используемую, чтобы создавать строгое имя для сборки с данным атрибутом.</summary>
		/// <param name="keyFile">Имя файла, содержащего пару ключей.</param>
		// Token: 0x06004868 RID: 18536 RVA: 0x000EE0F8 File Offset: 0x000EC2F8
		public AssemblyKeyFileAttribute(string keyFile)
		{
			this.KeyFile = keyFile;
		}

		/// <summary>Возвращает имя файла, содержащего пару ключей, используемую для создания строгого имени для сборки с данным атрибутом.</summary>
		/// <returns>Строка, содержащая имя файла, где находится данная пара ключей.</returns>
		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x000EE107 File Offset: 0x000EC307
		public string KeyFile { get; }
	}
}
