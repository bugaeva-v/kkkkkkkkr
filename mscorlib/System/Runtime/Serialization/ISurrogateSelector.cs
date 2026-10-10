using System;

namespace System.Runtime.Serialization
{
	/// <summary>Указывает класс селектора суррогата сериализации.</summary>
	// Token: 0x02000653 RID: 1619
	public interface ISurrogateSelector
	{
		/// <summary>Задает следующий <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> для суррогатов, если у текущего экземпляра отсутствует суррогат для заданного типа и сборки в заданном контексте.</summary>
		/// <param name="selector">Следующий проверяемый селектор суррогата.</param>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003C9C RID: 15516
		void ChainSelector(ISurrogateSelector selector);

		/// <summary>Находит суррогат, который представляет тип заданного объекта, начиная с заданного селектора суррогата для заданного контекста сериализации.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> объекта (класса), для которого необходим суррогат.</param>
		/// <param name="context">Контекст источника или назначения для текущей сериализации.</param>
		/// <param name="selector">Когда этот метод возвращается, содержит <see cref="T:System.Runtime.Serialization.ISurrogateSelector" />, хранящий ссылку на селектор суррогата, в котором найден соответствующий суррогат. Этот параметр передается неинициализированным.</param>
		/// <returns>Соответствующий суррогат для заданного типа в заданном контексте.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003C9D RID: 15517
		ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);

		/// <summary>Возвращает следующий селектор суррогата в цепочку.</summary>
		/// <returns>Следующий селектор суррогата в цепочке или <see langword="null" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003C9E RID: 15518
		ISurrogateSelector GetNextSelector();
	}
}
