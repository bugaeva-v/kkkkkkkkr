using System;

namespace System.Reflection
{
	/// <summary>Присоединяет модификатор к параметрам, позволяя привязке работать с подписями параметров с измененными типами.</summary>
	// Token: 0x020008B7 RID: 2231
	public readonly struct ParameterModifier
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Reflection.ParameterModifier" />, которая представляет указанное число параметров.</summary>
		/// <param name="parameterCount">Число параметров.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="parameterCount" /> является отрицательным значением.</exception>
		// Token: 0x060049DB RID: 18907 RVA: 0x000EF3E7 File Offset: 0x000ED5E7
		public ParameterModifier(int parameterCount)
		{
			if (parameterCount <= 0)
			{
				throw new ArgumentException("Must specify one or more parameters.");
			}
			this._byRef = new bool[parameterCount];
		}

		/// <summary>Возвращает или задает значение, которое указывает, будет ли параметр в указанном положении индекса изменен текущим элементом <see cref="T:System.Reflection.ParameterModifier" />.</summary>
		/// <param name="index">Позиция индекса параметра, состояние изменения которого проверяется или задается.</param>
		/// <returns>
		///   <see langword="true" />, если параметр в этой позиции индекса будет изменен этим элементом <see cref="T:System.Reflection.ParameterModifier" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x17000B9A RID: 2970
		public bool this[int index]
		{
			get
			{
				return this._byRef[index];
			}
			set
			{
				this._byRef[index] = value;
			}
		}

		// Token: 0x04002F0C RID: 12044
		private readonly bool[] _byRef;
	}
}
