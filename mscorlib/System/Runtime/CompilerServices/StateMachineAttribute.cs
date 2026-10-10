using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Позволяет определить, является ли метод методом конечного компьютера.</summary>
	// Token: 0x02000805 RID: 2053
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public class StateMachineAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.StateMachineAttribute" />.</summary>
		/// <param name="stateMachineType">Объект типа для типа базового конечного автомата, который был создан компилятором для реализации метода конечного автомата.</param>
		// Token: 0x06004620 RID: 17952 RVA: 0x000E5933 File Offset: 0x000E3B33
		public StateMachineAttribute(Type stateMachineType)
		{
			this.StateMachineType = stateMachineType;
		}

		/// <summary>Возвращает объект типа для типа базового конечного автомата, который был создан компилятором для реализации метода конечного автомата.</summary>
		/// <returns>Получает объект типа для типа базового конечного автомата, который был создан компилятором для реализации метода конечного автомата.</returns>
		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x000E5942 File Offset: 0x000E3B42
		public Type StateMachineType { get; }
	}
}
