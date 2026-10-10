using System;

namespace System
{
	/// <summary>Определяет стандартные клавиши консоли.</summary>
	// Token: 0x020001BF RID: 447
	public enum ConsoleKey
	{
		/// <summary>Клавиша BACKSPACE.</summary>
		// Token: 0x040013A9 RID: 5033
		Backspace = 8,
		/// <summary>Клавиша TAB.</summary>
		// Token: 0x040013AA RID: 5034
		Tab,
		/// <summary>Клавиша CLEAR.</summary>
		// Token: 0x040013AB RID: 5035
		Clear = 12,
		/// <summary>Клавиша ВВОД.</summary>
		// Token: 0x040013AC RID: 5036
		Enter,
		/// <summary>Клавиша PAUSE.</summary>
		// Token: 0x040013AD RID: 5037
		Pause = 19,
		/// <summary>Клавиша ESC.</summary>
		// Token: 0x040013AE RID: 5038
		Escape = 27,
		/// <summary>Клавиша ПРОБЕЛ.</summary>
		// Token: 0x040013AF RID: 5039
		Spacebar = 32,
		/// <summary>Клавиша PAGE UP.</summary>
		// Token: 0x040013B0 RID: 5040
		PageUp,
		/// <summary>Клавиша PAGE DOWN.</summary>
		// Token: 0x040013B1 RID: 5041
		PageDown,
		/// <summary>Клавиша END.</summary>
		// Token: 0x040013B2 RID: 5042
		End,
		/// <summary>Клавиша HOME.</summary>
		// Token: 0x040013B3 RID: 5043
		Home,
		/// <summary>Клавиша СТРЕЛКА ВЛЕВО.</summary>
		// Token: 0x040013B4 RID: 5044
		LeftArrow,
		/// <summary>Клавиша СТРЕЛКА ВВЕРХ.</summary>
		// Token: 0x040013B5 RID: 5045
		UpArrow,
		/// <summary>Клавиша СТРЕЛКА ВПРАВО.</summary>
		// Token: 0x040013B6 RID: 5046
		RightArrow,
		/// <summary>Клавиша СТРЕЛКА ВНИЗ.</summary>
		// Token: 0x040013B7 RID: 5047
		DownArrow,
		/// <summary>Клавиша SELECT.</summary>
		// Token: 0x040013B8 RID: 5048
		Select,
		/// <summary>Клавиша PRINT.</summary>
		// Token: 0x040013B9 RID: 5049
		Print,
		/// <summary>Клавиша EXECUTE.</summary>
		// Token: 0x040013BA RID: 5050
		Execute,
		/// <summary>Клавиша PRINT SCREEN.</summary>
		// Token: 0x040013BB RID: 5051
		PrintScreen,
		/// <summary>Клавиша INSERT.</summary>
		// Token: 0x040013BC RID: 5052
		Insert,
		/// <summary>Клавиша DELETE.</summary>
		// Token: 0x040013BD RID: 5053
		Delete,
		/// <summary>Клавиша HELP.</summary>
		// Token: 0x040013BE RID: 5054
		Help,
		/// <summary>Клавиша 0.</summary>
		// Token: 0x040013BF RID: 5055
		D0,
		/// <summary>Клавиша 1.</summary>
		// Token: 0x040013C0 RID: 5056
		D1,
		/// <summary>Клавиша 2.</summary>
		// Token: 0x040013C1 RID: 5057
		D2,
		/// <summary>Клавиша 3.</summary>
		// Token: 0x040013C2 RID: 5058
		D3,
		/// <summary>Клавиша 4.</summary>
		// Token: 0x040013C3 RID: 5059
		D4,
		/// <summary>Клавиша 5.</summary>
		// Token: 0x040013C4 RID: 5060
		D5,
		/// <summary>Клавиша 6.</summary>
		// Token: 0x040013C5 RID: 5061
		D6,
		/// <summary>Клавиша 7.</summary>
		// Token: 0x040013C6 RID: 5062
		D7,
		/// <summary>Клавиша 8.</summary>
		// Token: 0x040013C7 RID: 5063
		D8,
		/// <summary>Клавиша 9.</summary>
		// Token: 0x040013C8 RID: 5064
		D9,
		/// <summary>Клавиша A.</summary>
		// Token: 0x040013C9 RID: 5065
		A = 65,
		/// <summary>Клавиша B.</summary>
		// Token: 0x040013CA RID: 5066
		B,
		/// <summary>Клавиша C.</summary>
		// Token: 0x040013CB RID: 5067
		C,
		/// <summary>Клавиша D.</summary>
		// Token: 0x040013CC RID: 5068
		D,
		/// <summary>Клавиша E.</summary>
		// Token: 0x040013CD RID: 5069
		E,
		/// <summary>Клавиша F.</summary>
		// Token: 0x040013CE RID: 5070
		F,
		/// <summary>Клавиша G.</summary>
		// Token: 0x040013CF RID: 5071
		G,
		/// <summary>Клавиша H.</summary>
		// Token: 0x040013D0 RID: 5072
		H,
		/// <summary>Клавиша I.</summary>
		// Token: 0x040013D1 RID: 5073
		I,
		/// <summary>Клавиша J.</summary>
		// Token: 0x040013D2 RID: 5074
		J,
		/// <summary>Клавиша K.</summary>
		// Token: 0x040013D3 RID: 5075
		K,
		/// <summary>Клавиша L.</summary>
		// Token: 0x040013D4 RID: 5076
		L,
		/// <summary>Клавиша M.</summary>
		// Token: 0x040013D5 RID: 5077
		M,
		/// <summary>Клавиша N.</summary>
		// Token: 0x040013D6 RID: 5078
		N,
		/// <summary>Клавиша O.</summary>
		// Token: 0x040013D7 RID: 5079
		O,
		/// <summary>Клавиша P.</summary>
		// Token: 0x040013D8 RID: 5080
		P,
		/// <summary>Клавиша Q.</summary>
		// Token: 0x040013D9 RID: 5081
		Q,
		/// <summary>Клавиша R.</summary>
		// Token: 0x040013DA RID: 5082
		R,
		/// <summary>Клавиша S.</summary>
		// Token: 0x040013DB RID: 5083
		S,
		/// <summary>Клавиша T.</summary>
		// Token: 0x040013DC RID: 5084
		T,
		/// <summary>Клавиша U.</summary>
		// Token: 0x040013DD RID: 5085
		U,
		/// <summary>Клавиша V.</summary>
		// Token: 0x040013DE RID: 5086
		V,
		/// <summary>Клавиша W.</summary>
		// Token: 0x040013DF RID: 5087
		W,
		/// <summary>Клавиша X.</summary>
		// Token: 0x040013E0 RID: 5088
		X,
		/// <summary>Клавиша Y.</summary>
		// Token: 0x040013E1 RID: 5089
		Y,
		/// <summary>Клавиша Z.</summary>
		// Token: 0x040013E2 RID: 5090
		Z,
		/// <summary>Левая клавиша с логотипом Windows (клавиатура Microsoft Natural Keyboard).</summary>
		// Token: 0x040013E3 RID: 5091
		LeftWindows,
		/// <summary>Правая клавиша с логотипом Windows (клавиатура Microsoft Natural Keyboard).</summary>
		// Token: 0x040013E4 RID: 5092
		RightWindows,
		/// <summary>Клавиша приложения (клавиатура Microsoft Natural Keyboard).</summary>
		// Token: 0x040013E5 RID: 5093
		Applications,
		/// <summary>Клавиша перевода компьютера в спящий режим.</summary>
		// Token: 0x040013E6 RID: 5094
		Sleep = 95,
		/// <summary>Клавиша 0 на цифровой клавиатуре.</summary>
		// Token: 0x040013E7 RID: 5095
		NumPad0,
		/// <summary>Клавиша 1 на цифровой клавиатуре.</summary>
		// Token: 0x040013E8 RID: 5096
		NumPad1,
		/// <summary>Клавиша 2 на цифровой клавиатуре.</summary>
		// Token: 0x040013E9 RID: 5097
		NumPad2,
		/// <summary>Клавиша 3 на цифровой клавиатуре.</summary>
		// Token: 0x040013EA RID: 5098
		NumPad3,
		/// <summary>Клавиша 4 на цифровой клавиатуре.</summary>
		// Token: 0x040013EB RID: 5099
		NumPad4,
		/// <summary>Клавиша 5 на цифровой клавиатуре.</summary>
		// Token: 0x040013EC RID: 5100
		NumPad5,
		/// <summary>Клавиша 6 на цифровой клавиатуре.</summary>
		// Token: 0x040013ED RID: 5101
		NumPad6,
		/// <summary>Клавиша 7 на цифровой клавиатуре.</summary>
		// Token: 0x040013EE RID: 5102
		NumPad7,
		/// <summary>Клавиша 8 на цифровой клавиатуре.</summary>
		// Token: 0x040013EF RID: 5103
		NumPad8,
		/// <summary>Клавиша 9 на цифровой клавиатуре.</summary>
		// Token: 0x040013F0 RID: 5104
		NumPad9,
		/// <summary>Клавиша знака умножения на цифровой клавиатуре.</summary>
		// Token: 0x040013F1 RID: 5105
		Multiply,
		/// <summary>Клавиша плюс на цифровой клавиатуре.</summary>
		// Token: 0x040013F2 RID: 5106
		Add,
		/// <summary>Клавиша разделителя.</summary>
		// Token: 0x040013F3 RID: 5107
		Separator,
		/// <summary>Клавиша минус на цифровой клавиатуре.</summary>
		// Token: 0x040013F4 RID: 5108
		Subtract,
		/// <summary>Клавиша десятичного разделителя на цифровой клавиатуре.</summary>
		// Token: 0x040013F5 RID: 5109
		Decimal,
		/// <summary>Клавиша знака деления на цифровой клавиатуре.</summary>
		// Token: 0x040013F6 RID: 5110
		Divide,
		/// <summary>Клавиша F1.</summary>
		// Token: 0x040013F7 RID: 5111
		F1,
		/// <summary>Клавиша F2.</summary>
		// Token: 0x040013F8 RID: 5112
		F2,
		/// <summary>Клавиша F3.</summary>
		// Token: 0x040013F9 RID: 5113
		F3,
		/// <summary>Клавиша F4.</summary>
		// Token: 0x040013FA RID: 5114
		F4,
		/// <summary>Клавиша F5.</summary>
		// Token: 0x040013FB RID: 5115
		F5,
		/// <summary>Клавиша F6.</summary>
		// Token: 0x040013FC RID: 5116
		F6,
		/// <summary>Клавиша F7.</summary>
		// Token: 0x040013FD RID: 5117
		F7,
		/// <summary>Клавиша F8.</summary>
		// Token: 0x040013FE RID: 5118
		F8,
		/// <summary>Клавиша F9.</summary>
		// Token: 0x040013FF RID: 5119
		F9,
		/// <summary>Клавиша F10.</summary>
		// Token: 0x04001400 RID: 5120
		F10,
		/// <summary>Клавиша F11.</summary>
		// Token: 0x04001401 RID: 5121
		F11,
		/// <summary>Клавиша F12.</summary>
		// Token: 0x04001402 RID: 5122
		F12,
		/// <summary>Клавиша F13.</summary>
		// Token: 0x04001403 RID: 5123
		F13,
		/// <summary>Клавиша F14.</summary>
		// Token: 0x04001404 RID: 5124
		F14,
		/// <summary>Клавиша F15.</summary>
		// Token: 0x04001405 RID: 5125
		F15,
		/// <summary>Клавиша F16.</summary>
		// Token: 0x04001406 RID: 5126
		F16,
		/// <summary>Клавиша F17.</summary>
		// Token: 0x04001407 RID: 5127
		F17,
		/// <summary>Клавиша F18.</summary>
		// Token: 0x04001408 RID: 5128
		F18,
		/// <summary>Клавиша F19.</summary>
		// Token: 0x04001409 RID: 5129
		F19,
		/// <summary>Клавиша F20.</summary>
		// Token: 0x0400140A RID: 5130
		F20,
		/// <summary>Клавиша F21.</summary>
		// Token: 0x0400140B RID: 5131
		F21,
		/// <summary>Клавиша F22.</summary>
		// Token: 0x0400140C RID: 5132
		F22,
		/// <summary>Клавиша F23.</summary>
		// Token: 0x0400140D RID: 5133
		F23,
		/// <summary>Клавиша F24.</summary>
		// Token: 0x0400140E RID: 5134
		F24,
		/// <summary>Клавиша перехода назад в браузере (Windows 2000 или более поздней версии).</summary>
		// Token: 0x0400140F RID: 5135
		BrowserBack = 166,
		/// <summary>Клавиша перехода вперед в браузере (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001410 RID: 5136
		BrowserForward,
		/// <summary>Клавиша обновления в браузере (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001411 RID: 5137
		BrowserRefresh,
		/// <summary>Клавиша остановки в браузере (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001412 RID: 5138
		BrowserStop,
		/// <summary>Клавиша поиска в браузере (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001413 RID: 5139
		BrowserSearch,
		/// <summary>Клавиша избранного в браузере (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001414 RID: 5140
		BrowserFavorites,
		/// <summary>Клавиша домашней страницы в браузере (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001415 RID: 5141
		BrowserHome,
		/// <summary>Клавиша отключения звука (клавиатура Microsoft Natural Keyboard, Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001416 RID: 5142
		VolumeMute,
		/// <summary>Клавиша уменьшения громкости (клавиатура Microsoft Natural Keyboard, Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001417 RID: 5143
		VolumeDown,
		/// <summary>Клавиша увеличения громкости (клавиатура Microsoft Natural Keyboard, Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001418 RID: 5144
		VolumeUp,
		/// <summary>Клавиша перехода к следующей записи (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001419 RID: 5145
		MediaNext,
		/// <summary>Клавиша перехода к предыдущей записи (Windows 2000 или более поздней версии).</summary>
		// Token: 0x0400141A RID: 5146
		MediaPrevious,
		/// <summary>Клавиша остановки воспроизведения (Windows 2000 или более поздней версии).</summary>
		// Token: 0x0400141B RID: 5147
		MediaStop,
		/// <summary>Клавиша воспроизведения и приостановки воспроизведения (Windows 2000 или более поздней версии).</summary>
		// Token: 0x0400141C RID: 5148
		MediaPlay,
		/// <summary>Клавиша запуска почты (клавиатура Microsoft Natural Keyboard, Windows 2000 или более поздней версии).</summary>
		// Token: 0x0400141D RID: 5149
		LaunchMail,
		/// <summary>Клавиша выбора носителя (клавиатура Microsoft Natural Keyboard, Windows 2000 или более поздней версии).</summary>
		// Token: 0x0400141E RID: 5150
		LaunchMediaSelect,
		/// <summary>Клавиша запуска приложения 1 (клавиатура Microsoft Natural Keyboard, Windows 2000 или более поздней версии).</summary>
		// Token: 0x0400141F RID: 5151
		LaunchApp1,
		/// <summary>Клавиша запуска приложения 2 (клавиатура Microsoft Natural Keyboard, Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001420 RID: 5152
		LaunchApp2,
		/// <summary>Клавиша OEM 1 (используемая изготовителем оборудования).</summary>
		// Token: 0x04001421 RID: 5153
		Oem1 = 186,
		/// <summary>Клавиша OEM со знаком плюс на клавиатуре любой страны или региона (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001422 RID: 5154
		OemPlus,
		/// <summary>Клавиша OEM с запятой на клавиатуре любой страны или региона (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001423 RID: 5155
		OemComma,
		/// <summary>Клавиша OEM со знаком минус на клавиатуре любой страны или региона (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001424 RID: 5156
		OemMinus,
		/// <summary>Клавиша OEM с точкой на клавиатуре любой страны или региона (Windows 2000 или более поздней версии).</summary>
		// Token: 0x04001425 RID: 5157
		OemPeriod,
		/// <summary>Клавиша OEM 2 (используемая изготовителем оборудования).</summary>
		// Token: 0x04001426 RID: 5158
		Oem2,
		/// <summary>Клавиша OEM 3 (используемая изготовителем оборудования).</summary>
		// Token: 0x04001427 RID: 5159
		Oem3,
		/// <summary>Клавиша OEM 4 (используемая изготовителем оборудования).</summary>
		// Token: 0x04001428 RID: 5160
		Oem4 = 219,
		/// <summary>Клавиша OEM 5 (используемая изготовителем оборудования).</summary>
		// Token: 0x04001429 RID: 5161
		Oem5,
		/// <summary>Клавиша OEM 6 (используемая изготовителем оборудования).</summary>
		// Token: 0x0400142A RID: 5162
		Oem6,
		/// <summary>Клавиша OEM 7 (используемая изготовителем оборудования).</summary>
		// Token: 0x0400142B RID: 5163
		Oem7,
		/// <summary>Клавиша OEM 8 (используемая изготовителем оборудования).</summary>
		// Token: 0x0400142C RID: 5164
		Oem8,
		/// <summary>Клавиша OEM 102 (используемая изготовителем оборудования).</summary>
		// Token: 0x0400142D RID: 5165
		Oem102 = 226,
		/// <summary>Клавиша IME PROCESS.</summary>
		// Token: 0x0400142E RID: 5166
		Process = 229,
		/// <summary>Клавиша PACKET (используется для передачи символов Юникода путем нажатия клавиш).</summary>
		// Token: 0x0400142F RID: 5167
		Packet = 231,
		/// <summary>Клавиша ATTN.</summary>
		// Token: 0x04001430 RID: 5168
		Attention = 246,
		/// <summary>Клавиша CRSEL (CURSOR SELECT).</summary>
		// Token: 0x04001431 RID: 5169
		CrSel,
		/// <summary>Клавиша EXSEL (EXTEND SELECTION).</summary>
		// Token: 0x04001432 RID: 5170
		ExSel,
		/// <summary>Клавиша ERASE EOF.</summary>
		// Token: 0x04001433 RID: 5171
		EraseEndOfFile,
		/// <summary>Клавиша PLAY.</summary>
		// Token: 0x04001434 RID: 5172
		Play,
		/// <summary>Клавиша ZOOM.</summary>
		// Token: 0x04001435 RID: 5173
		Zoom,
		/// <summary>Константа, зарезервированная для использования в будущем.</summary>
		// Token: 0x04001436 RID: 5174
		NoName,
		/// <summary>Клавиша PA1.</summary>
		// Token: 0x04001437 RID: 5175
		Pa1,
		/// <summary>Клавиша CLEAR (используемая изготовителем оборудования).</summary>
		// Token: 0x04001438 RID: 5176
		OemClear
	}
}
