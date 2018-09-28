﻿/*
    Copyright (C) 2018 de4dot@gmail.com

    This file is part of Iced.

    Iced is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Iced is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Iced.  If not, see <https://www.gnu.org/licenses/>.
*/

#if !NO_INTEL_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Intel {
	public sealed class IntelFormatterTest64_ForceMemSize_008 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, IntelFormatterFactory.Create_ForceMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_008.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_008.AllInfos_Length] {
			"vpcompressb zmm19{k3}{z}, zmm10",
			"vpcompressb zmmword ptr [rax+1], zmm2",
			"vpcompressw xmm3, xmm2",
			"vpcompressw xmmword ptr [rax+2], xmm2",
			"vpcompressw ymm3{k3}, ymm2",
			"vpcompressw ymmword ptr [rax+2]{k3}, ymm2",
			"vpcompressw zmm19{k3}{z}, zmm10",
			"vpcompressw zmmword ptr [rax+2], zmm2",
			"vpshldvw xmm2{k3}, xmm6, xmm3",
			"vpshldvw xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vpshldvw ymm2{k3}, ymm6, ymm3",
			"vpshldvw ymm2{k3}, ymm6, ymmword ptr [rax+0x20]",
			"vpshldvw zmm18{k3}{z}, zmm14, zmm3",
			"vpshldvw zmm2{k3}{z}, zmm6, zmmword ptr [rax+0x40]",
			"vpshldvd xmm18{k3}, xmm14, xmm3",
			"vpshldvd xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vpshldvd xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vpshldvd ymm18{k3}, ymm14, ymm3",
			"vpshldvd ymm2{k3}, ymm6, ymmword ptr [rax+0x20]",
			"vpshldvd ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vpshldvd zmm2{k3}{z}, zmm6, zmm3",
			"vpshldvd zmm2, zmm6, zmmword ptr [rax+0x40]",
			"vpshldvd zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"vpshldvq xmm18{k3}, xmm14, xmm3",
			"vpshldvq xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vpshldvq xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vpshldvq ymm18{k3}, ymm14, ymm3",
			"vpshldvq ymm2{k3}, ymm6, ymmword ptr [rax+0x20]",
			"vpshldvq ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vpshldvq zmm2{k3}{z}, zmm6, zmm3",
			"vpshldvq zmm2, zmm6, zmmword ptr [rax+0x40]",
			"vpshldvq zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"vpshrdvw xmm2{k3}, xmm6, xmm3",
			"vpshrdvw xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vpshrdvw ymm2{k3}, ymm6, ymm3",
			"vpshrdvw ymm2{k3}, ymm6, ymmword ptr [rax+0x20]",
			"vpshrdvw zmm18{k3}{z}, zmm14, zmm3",
			"vpshrdvw zmm2{k3}{z}, zmm6, zmmword ptr [rax+0x40]",
			"vpshrdvd xmm18{k3}, xmm14, xmm3",
			"vpshrdvd xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vpshrdvd xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}",
			"vpshrdvd ymm18{k3}, ymm14, ymm3",
			"vpshrdvd ymm2{k3}, ymm6, ymmword ptr [rax+0x20]",
			"vpshrdvd ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}",
			"vpshrdvd zmm2{k3}{z}, zmm6, zmm3",
			"vpshrdvd zmm2, zmm6, zmmword ptr [rax+0x40]",
			"vpshrdvd zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}",
			"vpshrdvq xmm18{k3}, xmm14, xmm3",
			"vpshrdvq xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vpshrdvq xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}",
			"vpshrdvq ymm18{k3}, ymm14, ymm3",
			"vpshrdvq ymm2{k3}, ymm6, ymmword ptr [rax+0x20]",
			"vpshrdvq ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}",
			"vpshrdvq zmm2{k3}{z}, zmm6, zmm3",
			"vpshrdvq zmm2, zmm6, zmmword ptr [rax+0x40]",
			"vpshrdvq zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}",
			"vpshufbitqmb k2{k3}, xmm6, xmm3",
			"vpshufbitqmb k2, xmm6, xmmword ptr [rax+0x10]",
			"vpshufbitqmb k2{k3}, ymm6, ymm3",
			"vpshufbitqmb k2{k3}, ymm6, ymmword ptr [rax+0x20]",
			"vpshufbitqmb k2{k3}, zmm6, zmm3",
			"vpshufbitqmb k2, zmm6, zmmword ptr [rax+0x40]",
			"gf2p8mulb xmm1, xmm5",
			"gf2p8mulb xmm1, xmmword ptr [rax]",
			"vgf2p8mulb xmm2, xmm6, xmm3",
			"vgf2p8mulb xmm2, xmm6, xmmword ptr [rax]",
			"vgf2p8mulb ymm2, ymm6, ymm3",
			"vgf2p8mulb ymm2, ymm6, ymmword ptr [rax]",
			"vgf2p8mulb xmm2{k3}, xmm6, xmm3",
			"vgf2p8mulb xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vgf2p8mulb ymm2{k3}, ymm6, ymm3",
			"vgf2p8mulb ymm2{k3}, ymm6, ymmword ptr [rax+0x20]",
			"vgf2p8mulb zmm18{k3}{z}, zmm14, zmm3",
			"vgf2p8mulb zmm2{k5}{z}, zmm6, zmmword ptr [rax+0x40]",
			"vaesenc ymm2, ymm6, ymm3",
			"vaesenc ymm2, ymm6, ymmword ptr [rax]",
			"vaesenc xmm2, xmm6, xmm3",
			"vaesenc xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vaesenc ymm2, ymm6, ymm3",
			"vaesenc ymm2, ymm6, ymmword ptr [rax+0x20]",
			"vaesenc zmm2, zmm6, zmm3",
			"vaesenc zmm2, zmm6, zmmword ptr [rax+0x40]",
			"vaesenclast ymm2, ymm6, ymm3",
			"vaesenclast ymm2, ymm6, ymmword ptr [rax]",
			"vaesenclast xmm2, xmm6, xmm3",
			"vaesenclast xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vaesenclast ymm2, ymm6, ymm3",
			"vaesenclast ymm2, ymm6, ymmword ptr [rax+0x20]",
			"vaesenclast zmm2, zmm6, zmm3",
			"vaesenclast zmm2, zmm6, zmmword ptr [rax+0x40]",
			"vaesdec ymm2, ymm6, ymm3",
			"vaesdec ymm2, ymm6, ymmword ptr [rax]",
			"vaesdec xmm2, xmm6, xmm3",
			"vaesdec xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vaesdec ymm2, ymm6, ymm3",
			"vaesdec ymm2, ymm6, ymmword ptr [rax+0x20]",
			"vaesdec zmm2, zmm6, zmm3",
			"vaesdec zmm2, zmm6, zmmword ptr [rax+0x40]",
			"vaesdeclast ymm2, ymm6, ymm3",
			"vaesdeclast ymm2, ymm6, ymmword ptr [rax]",
			"vaesdeclast xmm2, xmm6, xmm3",
			"vaesdeclast xmm2, xmm6, xmmword ptr [rax+0x10]",
			"vaesdeclast ymm2, ymm6, ymm3",
			"vaesdeclast ymm2, ymm6, ymmword ptr [rax+0x20]",
			"vaesdeclast zmm2, zmm6, zmm3",
			"vaesdeclast zmm2, zmm6, zmmword ptr [rax+0x40]",
			"wrussd dword ptr [rax], ebx",
			"wrussq qword ptr [rax], rbx",
			"wrssd dword ptr [rax], ebx",
			"wrssq qword ptr [rax], rbx",
			"movdir64b ebx, zmmword ptr [eax]",
			"movdir64b rbx, zmmword ptr [rax]",
			"movdiri dword ptr [rax], ebx",
			"movdiri qword ptr [rax], rbx",
			"vpclmulqdq ymm2, ymm6, ymm3, -0x5b",
			"vpclmulqdq ymm2, ymm6, ymmword ptr [rax], -0x5b",
			"vpclmulqdq xmm2, xmm6, xmm3, -0x5b",
			"vpclmulqdq xmm2, xmm6, xmmword ptr [rax+0x10], -0x5b",
			"vpclmulqdq ymm2, ymm6, ymm3, -0x5b",
			"vpclmulqdq ymm2, ymm6, ymmword ptr [rax+0x20], -0x5b",
			"vpclmulqdq zmm2, zmm6, zmm3, -0x5b",
			"vpclmulqdq zmm2, zmm6, zmmword ptr [rax+0x40], -0x5b",
			"vpshldw xmm2{k3}, xmm6, xmm3, -0x5b",
			"vpshldw xmm2{k3}, xmm6, xmmword ptr [rax+0x10], -0x5b",
			"vpshldw ymm18{k3}{z}, ymm14, ymm3, -0x5b",
			"vpshldw ymm2{k5}{z}, ymm6, ymmword ptr [rax+0x20], -0x5b",
			"vpshldw zmm2{k3}, zmm6, zmm3, -0x5b",
			"vpshldw zmm2, zmm6, zmmword ptr [rax+0x40], -0x5b",
			"vpshldd xmm2{k3}, xmm6, xmm3, -0x5b",
			"vpshldd xmm2{k3}, xmm6, xmmword ptr [rax+0x10], -0x5b",
			"vpshldd xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}, -0x5b",
			"vpshldd ymm2{k3}{z}, ymm6, ymm3, -0x5b",
			"vpshldd ymm2, ymm6, ymmword ptr [rax+0x20], -0x5b",
			"vpshldd ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}, -0x5b",
			"vpshldd zmm2{k3}, zmm6, zmm3, -0x5b",
			"vpshldd zmm2, zmm6, zmmword ptr [rax+0x40], -0x5b",
			"vpshldd zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}, -0x5b",
			"vpshldq xmm18{k3}, xmm14, xmm3, -0x5b",
			"vpshldq xmm2{k3}, xmm6, xmmword ptr [rax+0x10], -0x5b",
			"vpshldq xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}, -0x5b",
			"vpshldq ymm2{k3}{z}, ymm6, ymm3, -0x5b",
			"vpshldq ymm2, ymm6, ymmword ptr [rax+0x20], -0x5b",
			"vpshldq ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}, -0x5b",
			"vpshldq zmm18{k3}, zmm14, zmm3, -0x5b",
			"vpshldq zmm2, zmm6, zmmword ptr [rax+0x40], -0x5b",
			"vpshldq zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}, -0x5b",
			"vpshrdw xmm2{k3}, xmm6, xmm3, -0x5b",
			"vpshrdw xmm2{k3}, xmm6, xmmword ptr [rax+0x10], -0x5b",
			"vpshrdw ymm18{k3}{z}, ymm14, ymm3, -0x5b",
			"vpshrdw ymm2{k5}{z}, ymm6, ymmword ptr [rax+0x20], -0x5b",
			"vpshrdw zmm2{k3}, zmm6, zmm3, -0x5b",
			"vpshrdw zmm2, zmm6, zmmword ptr [rax+0x40], -0x5b",
			"vpshrdd xmm2{k3}, xmm6, xmm3, -0x5b",
			"vpshrdd xmm2{k3}, xmm6, xmmword ptr [rax+0x10], -0x5b",
			"vpshrdd xmm2{k5}{z}, xmm6, dword ptr [rax+4]{1to4}, -0x5b",
			"vpshrdd ymm2{k3}{z}, ymm6, ymm3, -0x5b",
			"vpshrdd ymm2, ymm6, ymmword ptr [rax+0x20], -0x5b",
			"vpshrdd ymm2{k5}{z}, ymm6, dword ptr [rax+4]{1to8}, -0x5b",
			"vpshrdd zmm2{k3}, zmm6, zmm3, -0x5b",
			"vpshrdd zmm2, zmm6, zmmword ptr [rax+0x40], -0x5b",
			"vpshrdd zmm2{k5}{z}, zmm6, dword ptr [rax+4]{1to16}, -0x5b",
			"vpshrdq xmm18{k3}, xmm14, xmm3, -0x5b",
			"vpshrdq xmm2{k3}, xmm6, xmmword ptr [rax+0x10], -0x5b",
			"vpshrdq xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}, -0x5b",
			"vpshrdq ymm2{k3}{z}, ymm6, ymm3, -0x5b",
			"vpshrdq ymm2, ymm6, ymmword ptr [rax+0x20], -0x5b",
			"vpshrdq ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}, -0x5b",
			"vpshrdq zmm18{k3}, zmm14, zmm3, -0x5b",
			"vpshrdq zmm2, zmm6, zmmword ptr [rax+0x40], -0x5b",
			"vpshrdq zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}, -0x5b",
			"gf2p8affineqb xmm1, xmm5, -0x5b",
			"gf2p8affineqb xmm1, xmmword ptr [rax], -0x5b",
			"vgf2p8affineqb xmm2, xmm6, xmm3, -0x5b",
			"vgf2p8affineqb xmm2, xmm6, xmmword ptr [rax], -0x5b",
			"vgf2p8affineqb ymm2, ymm6, ymm3, -0x5b",
			"vgf2p8affineqb ymm2, ymm6, ymmword ptr [rax], -0x5b",
			"vgf2p8affineqb xmm18{k3}, xmm14, xmm3, -0x5b",
			"vgf2p8affineqb xmm2{k3}, xmm6, xmmword ptr [rax+0x10], -0x5b",
			"vgf2p8affineqb xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}, -0x5b",
			"vgf2p8affineqb ymm2{k3}{z}, ymm6, ymm3, -0x5b",
			"vgf2p8affineqb ymm2, ymm6, ymmword ptr [rax+0x20], -0x5b",
			"vgf2p8affineqb ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}, -0x5b",
			"vgf2p8affineqb zmm18{k3}, zmm14, zmm3, -0x5b",
			"vgf2p8affineqb zmm2, zmm6, zmmword ptr [rax+0x40], -0x5b",
			"vgf2p8affineqb zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}, -0x5b",
			"gf2p8affineinvqb xmm1, xmm5, -0x5b",
			"gf2p8affineinvqb xmm1, xmmword ptr [rax], -0x5b",
			"vgf2p8affineinvqb xmm2, xmm6, xmm3, -0x5b",
			"vgf2p8affineinvqb xmm2, xmm6, xmmword ptr [rax], -0x5b",
			"vgf2p8affineinvqb ymm2, ymm6, ymm3, -0x5b",
			"vgf2p8affineinvqb ymm2, ymm6, ymmword ptr [rax], -0x5b",
			"vgf2p8affineinvqb xmm18{k3}, xmm14, xmm3, -0x5b",
			"vgf2p8affineinvqb xmm2{k3}, xmm6, xmmword ptr [rax+0x10], -0x5b",
			"vgf2p8affineinvqb xmm2{k5}{z}, xmm6, qword ptr [rax+8]{1to2}, -0x5b",
			"vgf2p8affineinvqb ymm2{k3}{z}, ymm6, ymm3, -0x5b",
			"vgf2p8affineinvqb ymm2, ymm6, ymmword ptr [rax+0x20], -0x5b",
			"vgf2p8affineinvqb ymm2{k5}{z}, ymm6, qword ptr [rax+8]{1to4}, -0x5b",
			"vgf2p8affineinvqb zmm18{k3}, zmm14, zmm3, -0x5b",
			"vgf2p8affineinvqb zmm2, zmm6, zmmword ptr [rax+0x40], -0x5b",
			"vgf2p8affineinvqb zmm2{k5}{z}, zmm6, qword ptr [rax+8]{1to8}, -0x5b",
		};
	}
}
#endif
