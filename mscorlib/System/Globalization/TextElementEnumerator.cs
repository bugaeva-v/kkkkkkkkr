using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Unity;

namespace System.Globalization
{
	/// <summary>Перечисляет текстовые элементы строки.</summary>
	// Token: 0x02000998 RID: 2456
	[ComVisible(true)]
	[Serializable]
	public class TextElementEnumerator : IEnumerator
	{
		// Token: 0x06005817 RID: 22551 RVA: 0x00128F6D File Offset: 0x0012716D
		internal TextElementEnumerator(string str, int startIndex, int strLen)
		{
			this.str = str;
			this.startIndex = startIndex;
			this.strLen = strLen;
			this.Reset();
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x00128F90 File Offset: 0x00127190
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this.charLen = -1;
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x00128F9C File Offset: 0x0012719C
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.strLen = this.endIndex + 1;
			this.currTextElementLen = this.nextTextElementLen;
			if (this.charLen == -1)
			{
				this.uc = CharUnicodeInfo.InternalGetUnicodeCategory(this.str, this.index, out this.charLen);
			}
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x00128FE9 File Offset: 0x001271E9
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			this.endIndex = this.strLen - 1;
			this.nextTextElementLen = this.currTextElementLen;
		}

		/// <summary>Перемещает перечислитель на следующий текстовый элемент строки.</summary>
		/// <returns>
		///   <see langword="true" />, если перечислитель был успешно перемещен на следующий текстовый элемент; <see langword="false" />, если перечислитель достиг конца строки.</returns>
		// Token: 0x0600581B RID: 22555 RVA: 0x00129008 File Offset: 0x00127208
		public bool MoveNext()
		{
			if (this.index >= this.strLen)
			{
				this.index = this.strLen + 1;
				return false;
			}
			this.currTextElementLen = StringInfo.GetCurrentTextElementLen(this.str, this.index, this.strLen, ref this.uc, ref this.charLen);
			this.index += this.currTextElementLen;
			return true;
		}

		/// <summary>Возвращает текущий текстовый элемент строки.</summary>
		/// <returns>Объект, содержащий текущий текстовый элемент строки.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель помещается перед первым текстовым элементом или после последнего текстового элемента.</exception>
		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x00129070 File Offset: 0x00127270
		public object Current
		{
			get
			{
				return this.GetTextElement();
			}
		}

		/// <summary>Возвращает текущий текстовый элемент строки.</summary>
		/// <returns>Новая строка, содержащая текущий текстовый элемент в читаемой строке.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель помещается перед первым текстовым элементом или после последнего текстового элемента.</exception>
		// Token: 0x0600581D RID: 22557 RVA: 0x00129078 File Offset: 0x00127278
		public string GetTextElement()
		{
			if (this.index == this.startIndex)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Enumeration has not started. Call MoveNext."));
			}
			if (this.index > this.strLen)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Enumeration already finished."));
			}
			return this.str.Substring(this.index - this.currTextElementLen, this.currTextElementLen);
		}

		/// <summary>Возвращает индекс текстового элемента, в котором в настоящий момент находится перечислитель.</summary>
		/// <returns>Индекс текстового элемента, в котором в настоящий момент находится перечислитель.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель помещается перед первым текстовым элементом или после последнего текстового элемента.</exception>
		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x0600581E RID: 22558 RVA: 0x001290DF File Offset: 0x001272DF
		public int ElementIndex
		{
			get
			{
				if (this.index == this.startIndex)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Enumeration has not started. Call MoveNext."));
				}
				return this.index - this.currTextElementLen;
			}
		}

		/// <summary>Перемещает перечислитель в исходное положение, перед первым текстовым элементом в строке.</summary>
		// Token: 0x0600581F RID: 22559 RVA: 0x0012910C File Offset: 0x0012730C
		public void Reset()
		{
			this.index = this.startIndex;
			if (this.index < this.strLen)
			{
				this.uc = CharUnicodeInfo.InternalGetUnicodeCategory(this.str, this.index, out this.charLen);
			}
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x000173AD File Offset: 0x000155AD
		internal TextElementEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040036A0 RID: 13984
		private string str;

		// Token: 0x040036A1 RID: 13985
		private int index;

		// Token: 0x040036A2 RID: 13986
		private int startIndex;

		// Token: 0x040036A3 RID: 13987
		[NonSerialized]
		private int strLen;

		// Token: 0x040036A4 RID: 13988
		[NonSerialized]
		private int currTextElementLen;

		// Token: 0x040036A5 RID: 13989
		[OptionalField(VersionAdded = 2)]
		private UnicodeCategory uc;

		// Token: 0x040036A6 RID: 13990
		[OptionalField(VersionAdded = 2)]
		private int charLen;

		// Token: 0x040036A7 RID: 13991
		private int endIndex;

		// Token: 0x040036A8 RID: 13992
		private int nextTextElementLen;
	}
}
