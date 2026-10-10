using System;

namespace System.Drawing.Printing
{
	/// <summary>Указывает стандартные форматы бумаги.</summary>
	// Token: 0x020000BA RID: 186
	public enum PaperKind
	{
		/// <summary>Формат бумаги определен пользователем.</summary>
		// Token: 0x0400066C RID: 1644
		Custom,
		/// <summary>Лист Letter (8,5 х 11 дюймов).</summary>
		// Token: 0x0400066D RID: 1645
		Letter,
		/// <summary>Legal (8,5 х 14 дюймов).</summary>
		// Token: 0x0400066E RID: 1646
		Legal = 5,
		/// <summary>A4 (210 х 297 мм).</summary>
		// Token: 0x0400066F RID: 1647
		A4 = 9,
		/// <summary>Формат С (17 х 22 дюйма).</summary>
		// Token: 0x04000670 RID: 1648
		CSheet = 24,
		/// <summary>Формат D (22 х 34 дюйма).</summary>
		// Token: 0x04000671 RID: 1649
		DSheet,
		/// <summary>Формат E (34 х 44 дюйма).</summary>
		// Token: 0x04000672 RID: 1650
		ESheet,
		/// <summary>Лист Letter small (8,5 х 11 дюймов).</summary>
		// Token: 0x04000673 RID: 1651
		LetterSmall = 2,
		/// <summary>Формат Tabloid (11 х 17 дюймов).</summary>
		// Token: 0x04000674 RID: 1652
		Tabloid,
		/// <summary>Ledger (17 х 11 дюймов).</summary>
		// Token: 0x04000675 RID: 1653
		Ledger,
		/// <summary>Формат Statement (5,5 х 8,5 дюйма).</summary>
		// Token: 0x04000676 RID: 1654
		Statement = 6,
		/// <summary>Формат Executive (7,25 х 10,5 дюйма).</summary>
		// Token: 0x04000677 RID: 1655
		Executive,
		/// <summary>A3 (297 х 420 мм).</summary>
		// Token: 0x04000678 RID: 1656
		A3,
		/// <summary>A4 Small (210 х 297 мм).</summary>
		// Token: 0x04000679 RID: 1657
		A4Small = 10,
		/// <summary>A5 (148 х 210 мм).</summary>
		// Token: 0x0400067A RID: 1658
		A5,
		/// <summary>B4 (250 х 353 мм).</summary>
		// Token: 0x0400067B RID: 1659
		B4,
		/// <summary>B5 (176 х 250 мм).</summary>
		// Token: 0x0400067C RID: 1660
		B5,
		/// <summary>Формат Фолио (8,5 х 13 дюймов).</summary>
		// Token: 0x0400067D RID: 1661
		Folio,
		/// <summary>Quarto (215 х 275 мм).</summary>
		// Token: 0x0400067E RID: 1662
		Quarto,
		/// <summary>Стандартная бумага (10 х 14 дюймов).</summary>
		// Token: 0x0400067F RID: 1663
		Standard10x14,
		/// <summary>Стандартная бумага (11 х 17 дюймов).</summary>
		// Token: 0x04000680 RID: 1664
		Standard11x17,
		/// <summary>Формат для заметок (8,5 х 11 дюймов).</summary>
		// Token: 0x04000681 RID: 1665
		Note,
		/// <summary>#Конверт 9 (3,875 х 8,875 дюйма).</summary>
		// Token: 0x04000682 RID: 1666
		Number9Envelope,
		/// <summary>#Конверт 10 (4,125 х 9,5 дюйма).</summary>
		// Token: 0x04000683 RID: 1667
		Number10Envelope,
		/// <summary>#Конверт 11 (4,5 х 10,375 дюйма).</summary>
		// Token: 0x04000684 RID: 1668
		Number11Envelope,
		/// <summary>#Конверт 12 (4,75 х 11 дюймов).</summary>
		// Token: 0x04000685 RID: 1669
		Number12Envelope,
		/// <summary>#Конверт 14 (5 х 11,5 дюйма).</summary>
		// Token: 0x04000686 RID: 1670
		Number14Envelope,
		/// <summary>Конверт DL (110 х 220 мм).</summary>
		// Token: 0x04000687 RID: 1671
		DLEnvelope = 27,
		/// <summary>Конверт C5 (162 х 229 мм).</summary>
		// Token: 0x04000688 RID: 1672
		C5Envelope,
		/// <summary>Конверт C3 (324 х 458 мм).</summary>
		// Token: 0x04000689 RID: 1673
		C3Envelope,
		/// <summary>Конверт C4 (229 х 324 мм).</summary>
		// Token: 0x0400068A RID: 1674
		C4Envelope,
		/// <summary>Конверт C6 (114 х 162 мм).</summary>
		// Token: 0x0400068B RID: 1675
		C6Envelope,
		/// <summary>Конверт C65 (114 х 229 мм).</summary>
		// Token: 0x0400068C RID: 1676
		C65Envelope,
		/// <summary>Конверт B4 (250 х 353 мм).</summary>
		// Token: 0x0400068D RID: 1677
		B4Envelope,
		/// <summary>Конверт B5 (176 х 250 мм).</summary>
		// Token: 0x0400068E RID: 1678
		B5Envelope,
		/// <summary>Конверт B6 (176 х 125 мм).</summary>
		// Token: 0x0400068F RID: 1679
		B6Envelope,
		/// <summary>Итальянский конверт (110 х 230 мм).</summary>
		// Token: 0x04000690 RID: 1680
		ItalyEnvelope,
		/// <summary>Конверт Monarch (3,875 х 7,5 дюйма).</summary>
		// Token: 0x04000691 RID: 1681
		MonarchEnvelope,
		/// <summary>Конверт 6 3/4 (3,625 х 6,5 дюйма).</summary>
		// Token: 0x04000692 RID: 1682
		PersonalEnvelope,
		/// <summary>Standard Fanfold (США) (14,875 х 11 дюймов).</summary>
		// Token: 0x04000693 RID: 1683
		USStandardFanfold,
		/// <summary>Standard Fanfold (Германия) (8,5 х 12 дюймов).</summary>
		// Token: 0x04000694 RID: 1684
		GermanStandardFanfold,
		/// <summary>Legal Fanfold (Германия) (8,5 х 13 дюймов).</summary>
		// Token: 0x04000695 RID: 1685
		GermanLegalFanfold,
		/// <summary>ISO В4 (250 х 353 мм).</summary>
		// Token: 0x04000696 RID: 1686
		IsoB4,
		/// <summary>Почтовая карточка (Япония) (100 х 148 мм).</summary>
		// Token: 0x04000697 RID: 1687
		JapanesePostcard,
		/// <summary>Стандартная бумага (9 х 11 дюймов).</summary>
		// Token: 0x04000698 RID: 1688
		Standard9x11,
		/// <summary>Стандартная бумага (10 х 11 дюймов).</summary>
		// Token: 0x04000699 RID: 1689
		Standard10x11,
		/// <summary>Стандартная бумага (15 х 11 дюймов).</summary>
		// Token: 0x0400069A RID: 1690
		Standard15x11,
		/// <summary>Конверт для приглашений (220 х 220 мм).</summary>
		// Token: 0x0400069B RID: 1691
		InviteEnvelope,
		/// <summary>Лист Letter extra (9,275 х 12 дюймов). Это значение относится к драйверу PostScript и используется только принтерами Linotronic с целью экономии бумаги.</summary>
		// Token: 0x0400069C RID: 1692
		LetterExtra = 50,
		/// <summary>Legal extra (9,275 х 15 дюймов). Это значение относится к драйверу PostScript и используется только принтерами Linotronic с целью экономии бумаги.</summary>
		// Token: 0x0400069D RID: 1693
		LegalExtra,
		/// <summary>Формат Tabloid extra (11,69 х 18 дюймов). Это значение относится к драйверу PostScript и используется только принтерами Linotronic с целью экономии бумаги.</summary>
		// Token: 0x0400069E RID: 1694
		TabloidExtra,
		/// <summary>A4 Extra (236 х 322 мм). Это значение относится к драйверу PostScript и используется только принтерами Linotronic с целью экономии бумаги.</summary>
		// Token: 0x0400069F RID: 1695
		A4Extra,
		/// <summary>Лист Letter с поворотом (8,275 х 11 дюймов).</summary>
		// Token: 0x040006A0 RID: 1696
		LetterTransverse,
		/// <summary>A4 с поворотом (210 х 297 мм).</summary>
		// Token: 0x040006A1 RID: 1697
		A4Transverse,
		/// <summary>Лист Letter extra с поворотом (9,275 х 12 дюймов).</summary>
		// Token: 0x040006A2 RID: 1698
		LetterExtraTransverse,
		/// <summary>SuperA/SuperA/A4 (227 х 356 мм).</summary>
		// Token: 0x040006A3 RID: 1699
		APlus,
		/// <summary>SuperB/SuperB/A3 (305 х 487 мм).</summary>
		// Token: 0x040006A4 RID: 1700
		BPlus,
		/// <summary>Лист Letter plus (8,5 х 12,69 дюйма).</summary>
		// Token: 0x040006A5 RID: 1701
		LetterPlus,
		/// <summary>A4 Plus (210 х 330 мм).</summary>
		// Token: 0x040006A6 RID: 1702
		A4Plus,
		/// <summary>A5 с поворотом (148 х 210 мм).</summary>
		// Token: 0x040006A7 RID: 1703
		A5Transverse,
		/// <summary>JIS B5 с поворотом (182 х 257 мм).</summary>
		// Token: 0x040006A8 RID: 1704
		B5Transverse,
		/// <summary>A3 Extra (322 х 445 мм).</summary>
		// Token: 0x040006A9 RID: 1705
		A3Extra,
		/// <summary>A5 Extra (174 х 235 мм).</summary>
		// Token: 0x040006AA RID: 1706
		A5Extra,
		/// <summary>ISO B5 Extra (201 х 276 мм).</summary>
		// Token: 0x040006AB RID: 1707
		B5Extra,
		/// <summary>A2 (420 х 594 мм).</summary>
		// Token: 0x040006AC RID: 1708
		A2,
		/// <summary>A3 с поворотом (297 х 420 мм).</summary>
		// Token: 0x040006AD RID: 1709
		A3Transverse,
		/// <summary>A3 Extra с поворотом (322 х 445 мм).</summary>
		// Token: 0x040006AE RID: 1710
		A3ExtraTransverse,
		/// <summary>Двойная почтовая карточка (Япония) (200 х 148 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006AF RID: 1711
		JapaneseDoublePostcard,
		/// <summary>A6 (105 х 148 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006B0 RID: 1712
		A6,
		/// <summary>Конверт Kaku № 2 (Япония). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006B1 RID: 1713
		JapaneseEnvelopeKakuNumber2,
		/// <summary>Конверт Kaku № 3 (Япония). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006B2 RID: 1714
		JapaneseEnvelopeKakuNumber3,
		/// <summary>Конверт Chou № 3 (Япония). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006B3 RID: 1715
		JapaneseEnvelopeChouNumber3,
		/// <summary>Конверт Chou № 4 (Япония). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006B4 RID: 1716
		JapaneseEnvelopeChouNumber4,
		/// <summary>Лист Letter (повернуто) (11 х 8,5 дюйма).</summary>
		// Token: 0x040006B5 RID: 1717
		LetterRotated,
		/// <summary>A3, повернуто (420 х 297 мм).</summary>
		// Token: 0x040006B6 RID: 1718
		A3Rotated,
		/// <summary>A4, повернуто (297 х 210 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006B7 RID: 1719
		A4Rotated,
		/// <summary>A5, повернуто (210 х 148 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006B8 RID: 1720
		A5Rotated,
		/// <summary>JIS B4, повернуто (364 х 257 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006B9 RID: 1721
		B4JisRotated,
		/// <summary>JIS B5, повернуто (257 х 182 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006BA RID: 1722
		B5JisRotated,
		/// <summary>Почтовая карточка (Япония), повернуто (148 х 100 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006BB RID: 1723
		JapanesePostcardRotated,
		/// <summary>Двойная почтовая карточка (Япония), повернуто (148 х 200 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006BC RID: 1724
		JapaneseDoublePostcardRotated,
		/// <summary>A6, повернуто (148 х 105 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006BD RID: 1725
		A6Rotated,
		/// <summary>Конверт Kaku № 2 (Япония), повернуто. Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006BE RID: 1726
		JapaneseEnvelopeKakuNumber2Rotated,
		/// <summary>Конверт Kaku № 3 (Япония), повернуто. Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006BF RID: 1727
		JapaneseEnvelopeKakuNumber3Rotated,
		/// <summary>Конверт Chou № 3 (Япония), повернуто. Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C0 RID: 1728
		JapaneseEnvelopeChouNumber3Rotated,
		/// <summary>Конверт Chou № 4 (Япония), повернуто. Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C1 RID: 1729
		JapaneseEnvelopeChouNumber4Rotated,
		/// <summary>JIS B6 (128 х 182 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C2 RID: 1730
		B6Jis,
		/// <summary>JIS B6, повернуто (182 х 128 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C3 RID: 1731
		B6JisRotated,
		/// <summary>Стандартная бумага (12 х 11 дюймов). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C4 RID: 1732
		Standard12x11,
		/// <summary>Конверт You № 4 (Япония). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C5 RID: 1733
		JapaneseEnvelopeYouNumber4,
		/// <summary>Конверт You № 4 (Япония), повернуто. Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C6 RID: 1734
		JapaneseEnvelopeYouNumber4Rotated,
		/// <summary>16K (146 х 215 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C7 RID: 1735
		Prc16K,
		/// <summary>32K (97 х 151 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C8 RID: 1736
		Prc32K,
		/// <summary>32K (97 х 151 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006C9 RID: 1737
		Prc32KBig,
		/// <summary>#Конверт 1 (102 х 165 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006CA RID: 1738
		PrcEnvelopeNumber1,
		/// <summary>#Конверт 2 (102 х 176 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006CB RID: 1739
		PrcEnvelopeNumber2,
		/// <summary>#Конверт 3 (125 х 176 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006CC RID: 1740
		PrcEnvelopeNumber3,
		/// <summary>#Конверт 4 (110 х 208 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006CD RID: 1741
		PrcEnvelopeNumber4,
		/// <summary>#Конверт 5 (110 х 220 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006CE RID: 1742
		PrcEnvelopeNumber5,
		/// <summary>#Конверт 6 (120 х 230 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006CF RID: 1743
		PrcEnvelopeNumber6,
		/// <summary>#Конверт 7 (160 х 230 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D0 RID: 1744
		PrcEnvelopeNumber7,
		/// <summary>#Конверт 8 (120 х 309 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D1 RID: 1745
		PrcEnvelopeNumber8,
		/// <summary>#Конверт 9 (229 х 324 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D2 RID: 1746
		PrcEnvelopeNumber9,
		/// <summary>#Конверт 10 (324 х 458 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D3 RID: 1747
		PrcEnvelopeNumber10,
		/// <summary>16K, повернуто (146 х 215 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D4 RID: 1748
		Prc16KRotated,
		/// <summary>32K, повернуто (97 х 151 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D5 RID: 1749
		Prc32KRotated,
		/// <summary>32K, большой, повернуто (97 х 151 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D6 RID: 1750
		Prc32KBigRotated,
		/// <summary>#Конверт 1, повернуто (165 х 102 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D7 RID: 1751
		PrcEnvelopeNumber1Rotated,
		/// <summary>#Конверт 2, повернуто (176 х 102 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D8 RID: 1752
		PrcEnvelopeNumber2Rotated,
		/// <summary>#Конверт 3, повернуто (176 х 125 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006D9 RID: 1753
		PrcEnvelopeNumber3Rotated,
		/// <summary>#Конверт 4, повернуто (208 х 110 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006DA RID: 1754
		PrcEnvelopeNumber4Rotated,
		/// <summary>Конверт 5, повернуто (220 х 110 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006DB RID: 1755
		PrcEnvelopeNumber5Rotated,
		/// <summary>#Конверт 6, повернуто (230 х 120 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006DC RID: 1756
		PrcEnvelopeNumber6Rotated,
		/// <summary>#Конверт 7, повернуто (230 х 160 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006DD RID: 1757
		PrcEnvelopeNumber7Rotated,
		/// <summary>#Конверт 8, повернуто (309 х 120 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006DE RID: 1758
		PrcEnvelopeNumber8Rotated,
		/// <summary>#Конверт 9, повернуто (324 х 229 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006DF RID: 1759
		PrcEnvelopeNumber9Rotated,
		/// <summary>#Конверт 10, повернуто (458 х 324 мм). Требуется Windows 98, Windows NT 4.0 или более поздней версии.</summary>
		// Token: 0x040006E0 RID: 1760
		PrcEnvelopeNumber10Rotated
	}
}
