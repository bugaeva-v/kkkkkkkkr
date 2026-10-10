using System;

namespace System
{
	/// <summary>Используется для установки политики оптимизации загрузчика для основного метода исполняемого приложения.</summary>
	// Token: 0x020001CB RID: 459
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class LoaderOptimizationAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.LoaderOptimizationAttribute" /> с указанным значением.</summary>
		/// <param name="value">Значение эквивалентно константе <see cref="T:System.LoaderOptimization" />.</param>
		// Token: 0x060013B9 RID: 5049 RVA: 0x0004E80D File Offset: 0x0004CA0D
		public LoaderOptimizationAttribute(byte value)
		{
			this._val = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.LoaderOptimizationAttribute" /> с указанным значением.</summary>
		/// <param name="value">Константа <see cref="T:System.LoaderOptimization" />.</param>
		// Token: 0x060013BA RID: 5050 RVA: 0x0004E81C File Offset: 0x0004CA1C
		public LoaderOptimizationAttribute(LoaderOptimization value)
		{
			this._val = (byte)value;
		}

		/// <summary>Возвращает текущее значение <see cref="T:System.LoaderOptimization" /> данного экземпляра.</summary>
		/// <returns>Константа <see cref="T:System.LoaderOptimization" />.</returns>
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x0004E82C File Offset: 0x0004CA2C
		public LoaderOptimization Value
		{
			get
			{
				return (LoaderOptimization)this._val;
			}
		}

		// Token: 0x04001454 RID: 5204
		private readonly byte _val;
	}
}
