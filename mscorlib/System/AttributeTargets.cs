using System;

namespace System
{
	/// <summary>Задает элементы приложения, в которых допустимо применять аргумент.</summary>
	// Token: 0x020000FD RID: 253
	[Flags]
	public enum AttributeTargets
	{
		/// <summary>Атрибут может быть применен к сборке.</summary>
		// Token: 0x04001054 RID: 4180
		Assembly = 1,
		/// <summary>Атрибут может быть применен к модулю.</summary>
		// Token: 0x04001055 RID: 4181
		Module = 2,
		/// <summary>Атрибут может быть применен к классу.</summary>
		// Token: 0x04001056 RID: 4182
		Class = 4,
		/// <summary>Атрибут может быть применен к структуре, т.е. может являться типом значения.</summary>
		// Token: 0x04001057 RID: 4183
		Struct = 8,
		/// <summary>Атрибут может быть применен к перечислению.</summary>
		// Token: 0x04001058 RID: 4184
		Enum = 16,
		/// <summary>Атрибут может быть применен к конструктору.</summary>
		// Token: 0x04001059 RID: 4185
		Constructor = 32,
		/// <summary>Атрибут может быть применен к методу.</summary>
		// Token: 0x0400105A RID: 4186
		Method = 64,
		/// <summary>Атрибут может быть применен к свойству.</summary>
		// Token: 0x0400105B RID: 4187
		Property = 128,
		/// <summary>Атрибут может быть применен к полю.</summary>
		// Token: 0x0400105C RID: 4188
		Field = 256,
		/// <summary>Атрибут может быть применен к событию.</summary>
		// Token: 0x0400105D RID: 4189
		Event = 512,
		/// <summary>Атрибут может быть применен к интерфейсу.</summary>
		// Token: 0x0400105E RID: 4190
		Interface = 1024,
		/// <summary>Атрибут может быть применен к параметру.</summary>
		// Token: 0x0400105F RID: 4191
		Parameter = 2048,
		/// <summary>Атрибут может быть применен к делегату.</summary>
		// Token: 0x04001060 RID: 4192
		Delegate = 4096,
		/// <summary>Атрибут может быть применен к возвращаемому значению.</summary>
		// Token: 0x04001061 RID: 4193
		ReturnValue = 8192,
		/// <summary>Атрибут может быть применен к универсальному параметру.</summary>
		// Token: 0x04001062 RID: 4194
		GenericParameter = 16384,
		/// <summary>Атрибут может быть применен к любому элементу приложения.</summary>
		// Token: 0x04001063 RID: 4195
		All = 32767
	}
}
