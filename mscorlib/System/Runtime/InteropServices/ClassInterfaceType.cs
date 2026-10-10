using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, какой тип интерфейса генерируется для класса.</summary>
	// Token: 0x020006E9 RID: 1769
	[ComVisible(true)]
	[Serializable]
	public enum ClassInterfaceType
	{
		/// <summary>Указывает, что для класса не создается интерфейса класса. Если интерфейсы не реализованы явно, класс может предоставить доступ только через позднее связывание при помощи интерфейса <see langword="IDispatch" />. Это значение является рекомендованным для <see cref="T:System.Runtime.InteropServices.ClassInterfaceAttribute" />. Использование <see langword="ClassInterfaceType.None" /> — это единственный способ предоставления функциональных возможностей при помощи интерфейсов, явно реализованных классом.</summary>
		// Token: 0x04002A36 RID: 10806
		None,
		/// <summary>Указывает, что класс поддерживает только позднее связывание для клиентов COM. Интерфейс <see langword="dispinterface" /> класса автоматически предоставляется клиентам COM по запросу. Библиотека типов, созданная программой Tlbexp.exe (программа экспорта библиотек типов), не содержит информации о типе для интерфейса <see langword="dispinterface" />, чтобы не допустить кэширование значений DISPID клиентами. Интерфейс <see langword="dispinterface" /> исключает возникновение проблем с версиями, рассмотренных в описании класса <see cref="T:System.Runtime.InteropServices.ClassInterfaceAttribute" />, поскольку клиенты могут использовать только позднее связывание с интерфейсом.</summary>
		// Token: 0x04002A37 RID: 10807
		AutoDispatch,
		/// <summary>Указывает, что для класса автоматически создается сдвоенный интерфейс класса, который предоставляется COM. Сведения о типе создаются для класса интерфейса и публикуются в библиотеке типов. Использование <see langword="AutoDual" /> крайне нежелательно из-за ограничений, связанных с версиями и описанных для атрибута <see cref="T:System.Runtime.InteropServices.ClassInterfaceAttribute" />.</summary>
		// Token: 0x04002A38 RID: 10808
		AutoDual
	}
}
