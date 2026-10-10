using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет метод обратного вызова, который будет обрабатывать события проверки схемы XML и <see cref="T:System.Xml.Schema.ValidationEventArgs" />.
	///       </summary>
	/// <param name="sender">
	///           Источник события.
	///
	///           Примечание    определить тип отправителя перед его использованием в коде.
	///            Нельзя предполагать, что отправитель является экземпляром определенного типа.
	///            Отправитель не имеет значение null, также не гарантируется.
	///            Всегда окружите логику обработки ошибок к приведения.
	///         </param>
	/// <param name="e">
	///           Данные события.
	///         </param>
	// Token: 0x0200057F RID: 1407
	// (Invoke) Token: 0x060038AD RID: 14509
	public delegate void ValidationEventHandler(object sender, ValidationEventArgs e);
}
