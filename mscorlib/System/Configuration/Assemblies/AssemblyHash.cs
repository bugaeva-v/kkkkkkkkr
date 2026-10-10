using System;
using System.Runtime.InteropServices;

namespace System.Configuration.Assemblies
{
	/// <summary>Представляет хэш-значение содержимого манифеста сборки.</summary>
	// Token: 0x02000A0E RID: 2574
	[ComVisible(true)]
	[Obsolete]
	[Serializable]
	public struct AssemblyHash : ICloneable
	{
		/// <summary>Получает или задает хэш-алгоритм.</summary>
		/// <returns>Хэш-алгоритм сборки.</returns>
		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x00134A03 File Offset: 0x00132C03
		// (set) Token: 0x06005B67 RID: 23399 RVA: 0x00134A0B File Offset: 0x00132C0B
		[Obsolete]
		public AssemblyHashAlgorithm Algorithm
		{
			get
			{
				return this._algorithm;
			}
			set
			{
				this._algorithm = value;
			}
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Configuration.Assemblies.AssemblyHash" /> заданным хэш-алгоритмом и хэш-значением.</summary>
		/// <param name="algorithm">Алгоритм, используемый для генерации хэш-значения. Значения для этого параметра берутся из перечисления <see cref="T:System.Configuration.Assemblies.AssemblyHashAlgorithm" />.</param>
		/// <param name="value">Хэш-значение.</param>
		// Token: 0x06005B68 RID: 23400 RVA: 0x00134A14 File Offset: 0x00132C14
		[Obsolete]
		public AssemblyHash(AssemblyHashAlgorithm algorithm, byte[] value)
		{
			this._algorithm = algorithm;
			if (value != null)
			{
				this._value = (byte[])value.Clone();
				return;
			}
			this._value = null;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Configuration.Assemblies.AssemblyHash" /> заданным хэш-значением. По умолчанию используется хэш-алгоритм <see cref="F:System.Configuration.Assemblies.AssemblyHashAlgorithm.SHA1" />.</summary>
		/// <param name="value">Хэш-значение.</param>
		// Token: 0x06005B69 RID: 23401 RVA: 0x00134A39 File Offset: 0x00132C39
		[Obsolete]
		public AssemblyHash(byte[] value)
		{
			this = new AssemblyHash(AssemblyHashAlgorithm.SHA1, value);
		}

		/// <summary>Клонирует данный объект.</summary>
		/// <returns>Точная копия данного объекта.</returns>
		// Token: 0x06005B6A RID: 23402 RVA: 0x00134A47 File Offset: 0x00132C47
		[Obsolete]
		public object Clone()
		{
			return new AssemblyHash(this._algorithm, this._value);
		}

		/// <summary>Получает хэш-значение.</summary>
		/// <returns>Хэш-значение.</returns>
		// Token: 0x06005B6B RID: 23403 RVA: 0x00134A5F File Offset: 0x00132C5F
		[Obsolete]
		public byte[] GetValue()
		{
			return this._value;
		}

		/// <summary>Задает хэш-значение.</summary>
		/// <param name="value">Хэш-значение.</param>
		// Token: 0x06005B6C RID: 23404 RVA: 0x00134A67 File Offset: 0x00132C67
		[Obsolete]
		public void SetValue(byte[] value)
		{
			this._value = value;
		}

		// Token: 0x04003861 RID: 14433
		private AssemblyHashAlgorithm _algorithm;

		// Token: 0x04003862 RID: 14434
		private byte[] _value;

		/// <summary>Пустой объект <see cref="T:System.Configuration.Assemblies.AssemblyHash" /></summary>
		// Token: 0x04003863 RID: 14435
		[Obsolete]
		public static readonly AssemblyHash Empty = new AssemblyHash(AssemblyHashAlgorithm.None, null);
	}
}
