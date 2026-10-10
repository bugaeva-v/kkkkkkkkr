using System;

namespace System.EnterpriseServices
{
	/// <summary>Флаги используются с классом <see cref="T:System.EnterpriseServices.RegistrationHelper" />.</summary>
	// Token: 0x02000030 RID: 48
	[Flags]
	[Serializable]
	public enum InstallationFlags
	{
		/// <summary>Не следует использовать.</summary>
		// Token: 0x04000060 RID: 96
		Configure = 1024,
		/// <summary>Настраивает только компоненты, но не настраивает методы или интерфейсы.</summary>
		// Token: 0x04000061 RID: 97
		ConfigureComponentsOnly = 16,
		/// <summary>Создает конечное приложение. Если целевой объект уже существует, возникает ошибка.</summary>
		// Token: 0x04000062 RID: 98
		CreateTargetApplication = 2,
		/// <summary>Произведите установку по умолчанию, которая производит настройку, установку и регистрацию, предполагая, что приложение уже существует.</summary>
		// Token: 0x04000063 RID: 99
		Default = 0,
		/// <summary>Не следует экспортировать библиотеку типов; она может быть найдена по созданному или предоставленному имени.</summary>
		// Token: 0x04000064 RID: 100
		ExpectExistingTypeLib = 1,
		/// <summary>Создает приложение, если оно отсутствует; в противном случае, используется существующее приложение.</summary>
		// Token: 0x04000065 RID: 101
		FindOrCreateTargetApplication = 4,
		/// <summary>Не следует использовать.</summary>
		// Token: 0x04000066 RID: 102
		Install = 512,
		/// <summary>Если используется существующее приложение, гарантирует совпадение свойств этого приложения со свойствами в сборке.</summary>
		// Token: 0x04000067 RID: 103
		ReconfigureExistingApplication = 8,
		/// <summary>Не следует использовать.</summary>
		// Token: 0x04000068 RID: 104
		Register = 256,
		/// <summary>При получении текста оповещения выводит его на консоль.</summary>
		// Token: 0x04000069 RID: 105
		ReportWarningsToConsole = 32
	}
}
