using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Представляет метку в потоке инструкций. <see langword="Label" /> используется совместно с классом <see cref="T:System.Reflection.Emit.ILGenerator" />.</summary>
	// Token: 0x02000932 RID: 2354
	[ComVisible(true)]
	[Serializable]
	public readonly struct Label : IEquatable<Label>
	{
		// Token: 0x060050EC RID: 20716 RVA: 0x000FD770 File Offset: 0x000FB970
		internal Label(int val)
		{
			this.label = val;
		}

		/// <summary>Проверяет, является ли данный объект экземпляром <see langword="Label" /> и равен ли он этому экземпляру.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром <see langword="Label" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="Label" /> и равен этому объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060050ED RID: 20717 RVA: 0x000FD77C File Offset: 0x000FB97C
		public override bool Equals(object obj)
		{
			bool flag = obj is Label;
			if (flag)
			{
				Label label = (Label)obj;
				flag = (this.label == label.label);
			}
			return flag;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.Label" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.Label" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060050EE RID: 20718 RVA: 0x000FD7AD File Offset: 0x000FB9AD
		public bool Equals(Label obj)
		{
			return this.label == obj.label;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.Label" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.Label" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.Label" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060050EF RID: 20719 RVA: 0x000FD7BD File Offset: 0x000FB9BD
		public static bool operator ==(Label a, Label b)
		{
			return a.Equals(b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.Label" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.Label" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.Label" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060050F0 RID: 20720 RVA: 0x000FD7C7 File Offset: 0x000FB9C7
		public static bool operator !=(Label a, Label b)
		{
			return !(a == b);
		}

		/// <summary>Создает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код для данного экземпляра.</returns>
		// Token: 0x060050F1 RID: 20721 RVA: 0x000FD7D3 File Offset: 0x000FB9D3
		public override int GetHashCode()
		{
			return this.label.GetHashCode();
		}

		// Token: 0x040031B2 RID: 12722
		internal readonly int label;
	}
}
