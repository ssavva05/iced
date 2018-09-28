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
	public sealed class IntelFormatterTest64_NoMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, IntelFormatterFactory.Create_NoMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_000.AllInfos_Length] {
			"add dh, cl",
			"add [rax], bh",
			"add si, cx",
			"add [rax], bx",
			"add esi, ecx",
			"add [rax], ebx",
			"add rsi, rcx",
			"add [rax], rbx",
			"add cl, dh",
			"add bh, [rax]",
			"add cx, si",
			"add bx, [rax]",
			"add ecx, esi",
			"add ebx, [rax]",
			"add rcx, rsi",
			"add rbx, [rax]",
			"add al, 0xa5",
			"add ax, 0x5aa5",
			"add eax, 0x12345aa5",
			"add rax, 0xffffffff82345aa5",
			"or dh, cl",
			"or [rax], bh",
			"or si, cx",
			"or [rax], bx",
			"or esi, ecx",
			"or [rax], ebx",
			"or rsi, rcx",
			"or [rax], rbx",
			"or cl, dh",
			"or bh, [rax]",
			"or cx, si",
			"or bx, [rax]",
			"or ecx, esi",
			"or ebx, [rax]",
			"or rcx, rsi",
			"or rbx, [rax]",
			"or al, 0xa5",
			"or ax, 0x5aa5",
			"or eax, 0x12345aa5",
			"or rax, 0xffffffff82345aa5",
			"adc dh, cl",
			"adc [rax], bh",
			"adc si, cx",
			"adc [rax], bx",
			"adc esi, ecx",
			"adc [rax], ebx",
			"adc rsi, rcx",
			"adc [rax], rbx",
			"adc cl, dh",
			"adc bh, [rax]",
			"adc cx, si",
			"adc bx, [rax]",
			"adc ecx, esi",
			"adc ebx, [rax]",
			"adc rcx, rsi",
			"adc rbx, [rax]",
			"adc al, 0xa5",
			"adc ax, 0x5aa5",
			"adc eax, 0x12345aa5",
			"adc rax, 0xffffffff82345aa5",
			"sbb dh, cl",
			"sbb [rax], bh",
			"sbb si, cx",
			"sbb [rax], bx",
			"sbb esi, ecx",
			"sbb [rax], ebx",
			"sbb rsi, rcx",
			"sbb [rax], rbx",
			"sbb cl, dh",
			"sbb bh, [rax]",
			"sbb cx, si",
			"sbb bx, [rax]",
			"sbb ecx, esi",
			"sbb ebx, [rax]",
			"sbb rcx, rsi",
			"sbb rbx, [rax]",
			"sbb al, 0xa5",
			"sbb ax, 0x5aa5",
			"sbb eax, 0x12345aa5",
			"sbb rax, 0xffffffff82345aa5",
			"and dh, cl",
			"and [rax], bh",
			"and si, cx",
			"and [rax], bx",
			"and esi, ecx",
			"and [rax], ebx",
			"and rsi, rcx",
			"and [rax], rbx",
			"and cl, dh",
			"and bh, [rax]",
			"and cx, si",
			"and bx, [rax]",
			"and ecx, esi",
			"and ebx, [rax]",
			"and rcx, rsi",
			"and rbx, [rax]",
			"and al, 0xa5",
			"and ax, 0x5aa5",
			"and eax, 0x12345aa5",
			"and rax, 0xffffffff82345aa5",
			"sub dh, cl",
			"sub [rax], bh",
			"sub si, cx",
			"sub [rax], bx",
			"sub esi, ecx",
			"sub [rax], ebx",
			"sub rsi, rcx",
			"sub [rax], rbx",
			"sub cl, dh",
			"sub bh, [rax]",
			"sub cx, si",
			"sub bx, [rax]",
			"sub ecx, esi",
			"sub ebx, [rax]",
			"sub rcx, rsi",
			"sub rbx, [rax]",
			"sub al, 0xa5",
			"sub ax, 0x5aa5",
			"sub eax, 0x12345aa5",
			"sub rax, 0xffffffff82345aa5",
			"xor dh, cl",
			"xor [rax], bh",
			"xor si, cx",
			"xor [rax], bx",
			"xor esi, ecx",
			"xor [rax], ebx",
			"xor rsi, rcx",
			"xor [rax], rbx",
			"xor cl, dh",
			"xor bh, [rax]",
			"xor cx, si",
			"xor bx, [rax]",
			"xor ecx, esi",
			"xor ebx, [rax]",
			"xor rcx, rsi",
			"xor rbx, [rax]",
			"xor al, 0xa5",
			"xor ax, 0x5aa5",
			"xor eax, 0x12345aa5",
			"xor rax, 0xffffffff82345aa5",
			"cmp dh, cl",
			"cmp [rax], bh",
			"cmp si, cx",
			"cmp [rax], bx",
			"cmp esi, ecx",
			"cmp [rax], ebx",
			"cmp rsi, rcx",
			"cmp [rax], rbx",
			"cmp cl, dh",
			"cmp bh, [rax]",
			"cmp cx, si",
			"cmp bx, [rax]",
			"cmp ecx, esi",
			"cmp ebx, [rax]",
			"cmp rcx, rsi",
			"cmp rbx, [rax]",
			"cmp al, 0xa5",
			"cmp ax, 0x5aa5",
			"cmp eax, 0x12345aa5",
			"cmp rax, 0xffffffff82345aa5",
			"push ax",
			"push r8w",
			"push rax",
			"push r8",
			"push cx",
			"push r9w",
			"push rcx",
			"push r9",
			"push dx",
			"push r10w",
			"push rdx",
			"push r10",
			"push bx",
			"push r11w",
			"push rbx",
			"push r11",
			"push sp",
			"push r12w",
			"push rsp",
			"push r12",
			"push bp",
			"push r13w",
			"push rbp",
			"push r13",
			"push si",
			"push r14w",
			"push rsi",
			"push r14",
			"push di",
			"push r15w",
			"push rdi",
			"push r15",
			"pop ax",
			"pop r8w",
			"pop rax",
			"pop r8",
			"pop cx",
			"pop r9w",
			"pop rcx",
			"pop r9",
			"pop dx",
			"pop r10w",
			"pop rdx",
			"pop r10",
			"pop bx",
			"pop r11w",
			"pop rbx",
			"pop r11",
			"pop sp",
			"pop r12w",
			"pop rsp",
			"pop r12",
			"pop bp",
			"pop r13w",
			"pop rbp",
			"pop r13",
			"pop si",
			"pop r14w",
			"pop rsi",
			"pop r14",
			"pop di",
			"pop r15w",
			"pop rdi",
			"pop r15",
			"movsxd cx, si",
			"movsxd bx, word ptr [rax]",
			"movsxd ecx, esi",
			"movsxd ebx, dword ptr [rax]",
			"movsxd rcx, esi",
			"movsxd rbx, dword ptr [rax]",
			"data16 push 0xa55a",
			"push 0xffffffff8412a55a",
			"imul cx, si, 0x5aa5",
			"imul bx, [rax], 0xa55a",
			"imul ecx, esi, 0x3412a55a",
			"imul ebx, [rax], 0x3412a55a",
			"imul rcx, rsi, 0xffffffff8412a55a",
			"imul rbx, [rax], 0xffffffff8412a55a",
			"data16 push 0xffa5",
			"push 0xffffffffffffffa5",
			"imul cx, si, 0xffa5",
			"imul bx, [rax], 0xffa5",
			"imul ecx, esi, 0xffffffa5",
			"imul ebx, [rax], 0xffffffa5",
			"imul rcx, rsi, 0xffffffffffffffa5",
			"imul rbx, [rax], 0xffffffffffffffa5",
			"insb [edi], dx",
			"insb [rdi], dx",
			"insw [edi], dx",
			"insw [rdi], dx",
			"insd [edi], dx",
			"insd [rdi], dx",
			"outsb dx, [esi]",
			"outsb dx, [rsi]",
			"outsw dx, [esi]",
			"outsw dx, [rsi]",
			"outsd dx, [esi]",
			"outsd dx, [rsi]",
			"jo 0x800000000000004c",
			"jno 0x800000000000004c",
			"jb 0x800000000000004c",
			"jae 0x800000000000004c",
			"je 0x800000000000004c",
			"jne 0x800000000000004c",
			"jbe 0x800000000000004c",
			"ja 0x800000000000004c",
			"js 0x800000000000004c",
			"jns 0x800000000000004c",
			"jp 0x800000000000004c",
			"jnp 0x800000000000004c",
			"jl 0x800000000000004c",
			"jge 0x800000000000004c",
			"jle 0x800000000000004c",
			"jg 0x800000000000004c",
			"add cl, 0x5a",
			"add byte ptr [rax], 0x5a",
			"or dl, 0xa5",
			"or byte ptr [rax], 0xa5",
			"adc bl, 0x5a",
			"adc byte ptr [rax], 0x5a",
			"sbb ah, 0xa5",
			"sbb byte ptr [rax], 0xa5",
			"and ch, 0x5a",
			"and byte ptr [rax], 0x5a",
			"sub dh, 0xa5",
			"sub byte ptr [rax], 0xa5",
			"xor bh, 0x5a",
			"xor byte ptr [rax], 0x5a",
			"cmp al, 0xa5",
			"cmp byte ptr [rax], 0xa5",
			"add cx, 0xa55a",
			"add word ptr [rax], 0xa55a",
			"add ecx, 0x3412a55a",
			"add dword ptr [rax], 0x3412a55a",
			"add rcx, 0xffffffff8412a55a",
			"add qword ptr [rax], 0xffffffff8412a55a",
			"or dx, 0x5aa5",
			"or word ptr [rax], 0x5aa5",
			"or edx, 0xab895aa5",
			"or dword ptr [rax], 0xab895aa5",
			"or rdx, 0xffffffff8412a55a",
			"or qword ptr [rax], 0xffffffff8412a55a",
			"adc bx, 0xa55a",
			"adc word ptr [rax], 0xa55a",
			"adc ebx, 0x3412a55a",
			"adc dword ptr [rax], 0x3412a55a",
			"adc rbx, 0xffffffff8412a55a",
			"adc qword ptr [rax], 0xffffffff8412a55a",
			"sbb sp, 0x5aa5",
			"sbb word ptr [rax], 0x5aa5",
			"sbb esp, 0xab895aa5",
			"sbb dword ptr [rax], 0xab895aa5",
			"sbb rsp, 0xffffffff8412a55a",
			"sbb qword ptr [rax], 0xffffffff8412a55a",
			"and bp, 0xa55a",
			"and word ptr [rax], 0xa55a",
			"and ebp, 0x3412a55a",
			"and dword ptr [rax], 0x3412a55a",
			"and rbp, 0xffffffff8412a55a",
			"and qword ptr [rax], 0xffffffff8412a55a",
			"sub si, 0x5aa5",
			"sub word ptr [rax], 0x5aa5",
			"sub esi, 0xab895aa5",
			"sub dword ptr [rax], 0xab895aa5",
			"sub rsi, 0xffffffff8412a55a",
			"sub qword ptr [rax], 0xffffffff8412a55a",
			"xor di, 0xa55a",
			"xor word ptr [rax], 0xa55a",
			"xor edi, 0x3412a55a",
			"xor dword ptr [rax], 0x3412a55a",
			"xor rdi, 0xffffffff8412a55a",
			"xor qword ptr [rax], 0xffffffff8412a55a",
			"cmp ax, 0x5aa5",
			"cmp word ptr [rax], 0x5aa5",
			"cmp eax, 0xab895aa5",
			"cmp dword ptr [rax], 0xab895aa5",
			"cmp r8, 0xffffffff8412a55a",
			"cmp qword ptr [rax], 0xffffffff8412a55a",
			"add cx, 0xffa5",
			"add word ptr [rax], 0xffa5",
			"add ecx, 0xffffffa5",
			"add dword ptr [rax], 0xffffffa5",
			"add rcx, 0xffffffffffffffa5",
			"add qword ptr [rax], 0xffffffffffffffa5",
			"or dx, 0xffa5",
			"or word ptr [rax], 0xffa5",
			"or edx, 0xffffffa5",
			"or dword ptr [rax], 0xffffffa5",
			"or rdx, 0xffffffffffffffa5",
			"or qword ptr [rax], 0xffffffffffffffa5",
			"adc bx, 0xffa5",
			"adc word ptr [rax], 0xffa5",
			"adc ebx, 0xffffffa5",
			"adc dword ptr [rax], 0xffffffa5",
			"adc rbx, 0xffffffffffffffa5",
			"adc qword ptr [rax], 0xffffffffffffffa5",
			"sbb sp, 0xffa5",
			"sbb word ptr [rax], 0xffa5",
			"sbb esp, 0xffffffa5",
			"sbb dword ptr [rax], 0xffffffa5",
			"sbb rsp, 0xffffffffffffffa5",
			"sbb qword ptr [rax], 0xffffffffffffffa5",
			"and bp, 0xffa5",
			"and word ptr [rax], 0xffa5",
			"and ebp, 0xffffffa5",
			"and dword ptr [rax], 0xffffffa5",
			"and rbp, 0xffffffffffffffa5",
			"and qword ptr [rax], 0xffffffffffffffa5",
			"sub si, 0xffa5",
			"sub word ptr [rax], 0xffa5",
			"sub esi, 0xffffffa5",
			"sub dword ptr [rax], 0xffffffa5",
			"sub rsi, 0xffffffffffffffa5",
			"sub qword ptr [rax], 0xffffffffffffffa5",
			"xor di, 0xffa5",
			"xor word ptr [rax], 0xffa5",
			"xor edi, 0xffffffa5",
			"xor dword ptr [rax], 0xffffffa5",
			"xor rdi, 0xffffffffffffffa5",
			"xor qword ptr [rax], 0xffffffffffffffa5",
			"cmp ax, 0xffa5",
			"cmp word ptr [rax], 0xffa5",
			"cmp eax, 0xffffffa5",
			"cmp dword ptr [rax], 0xffffffa5",
			"cmp r8, 0xffffffffffffffa5",
			"cmp qword ptr [rax], 0xffffffffffffffa5",
			"test dh, cl",
			"test [rax], bh",
			"test si, cx",
			"test [rax], bx",
			"test esi, ecx",
			"test [rax], ebx",
			"test rsi, rcx",
			"test [rax], rbx",
			"xchg dh, cl",
			"xchg [rax], bh",
			"xchg si, cx",
			"xchg [rax], bx",
			"xchg esi, ecx",
			"xchg [rax], ebx",
			"xchg rsi, rcx",
			"xchg [rax], rbx",
			"mov dh, cl",
			"mov [rax], bh",
			"mov si, cx",
			"mov [rax], bx",
			"mov esi, ecx",
			"mov [rax], ebx",
			"mov rsi, rcx",
			"mov [rax], rbx",
			"mov cl, dh",
			"mov bh, [rax]",
			"mov cx, si",
			"mov bx, [rax]",
			"mov ecx, esi",
			"mov ebx, [rax]",
			"mov rcx, rsi",
			"mov rbx, [rax]",
			"mov si, cs",
			"data16 mov [rax], ds",
			"mov esi, cs",
			"mov [rax], ds",
			"mov rsi, cs",
			"data64 mov [rax], ds",
			"lea bx, [rax]",
			"lea ebx, [rax]",
			"lea rbx, [rax]",
			"mov fs, si",
			"data16 mov ds, [rax]",
			"mov fs, esi",
			"mov ds, [rax]",
			"mov fs, rsi",
			"data64 mov ds, [rax]",
			"pop si",
			"pop word ptr [rax]",
			"pop rsi",
			"pop qword ptr [rax]",
			"xchg ax, ax",
			"xchg r8w, ax",
			"nop",
			"xchg r8d, eax",
			"xchg rax, rax",
			"xchg r8, rax",
			"xchg cx, ax",
			"xchg r9w, ax",
			"xchg ecx, eax",
			"xchg r9d, eax",
			"xchg rcx, rax",
			"xchg r9, rax",
			"xchg dx, ax",
			"xchg r10w, ax",
			"xchg edx, eax",
			"xchg r10d, eax",
			"xchg rdx, rax",
			"xchg r10, rax",
			"xchg bx, ax",
			"xchg r11w, ax",
			"xchg ebx, eax",
			"xchg r11d, eax",
			"xchg rbx, rax",
			"xchg r11, rax",
			"xchg sp, ax",
			"xchg r12w, ax",
			"xchg esp, eax",
			"xchg r12d, eax",
			"xchg rsp, rax",
			"xchg r12, rax",
			"xchg bp, ax",
			"xchg r13w, ax",
			"xchg ebp, eax",
			"xchg r13d, eax",
			"xchg rbp, rax",
			"xchg r13, rax",
			"xchg si, ax",
			"xchg r14w, ax",
			"xchg esi, eax",
			"xchg r14d, eax",
			"xchg rsi, rax",
			"xchg r14, rax",
			"xchg di, ax",
			"xchg r15w, ax",
			"xchg edi, eax",
			"xchg r15d, eax",
			"xchg rdi, rax",
			"xchg r15, rax",
			"pause",
			"cbw",
			"cwde",
			"cdqe",
			"cwd",
			"cdq",
			"cqo",
			"fwait",
			"pushf",
			"pushfq",
			"popf",
			"popfq",
			"sahf",
			"lahf",
			"mov al, [0xf0debc9a78563412]",
			"addr32 mov al, [0x78563412]",
			"mov ax, [0xf0debc9a78563412]",
			"addr32 mov ax, [0x78563412]",
			"mov eax, [0xf0debc9a78563412]",
			"addr32 mov eax, [0x78563412]",
			"mov rax, [0xf0debc9a78563412]",
			"addr32 mov rax, [0x78563412]",
			"mov [0xf0debc9a78563412], al",
			"addr32 mov [0x78563412], al",
			"mov [0xf0debc9a78563412], ax",
			"addr32 mov [0x78563412], ax",
			"mov [0xf0debc9a78563412], eax",
			"addr32 mov [0x78563412], eax",
			"mov [0xf0debc9a78563412], rax",
			"addr32 mov [0x78563412], rax",
			"movsb [edi], [esi]",
			"movsb [rdi], [rsi]",
			"movsw [edi], [esi]",
			"movsw [rdi], [rsi]",
			"movsd [edi], [esi]",
			"movsd [rdi], [rsi]",
			"movsq [edi], [esi]",
			"movsq [rdi], [rsi]",
			"cmpsb [esi], [edi]",
			"cmpsb [rsi], [rdi]",
			"cmpsw [esi], [edi]",
			"cmpsw [rsi], [rdi]",
			"cmpsd [esi], [edi]",
			"cmpsd [rsi], [rdi]",
			"cmpsq [esi], [edi]",
			"cmpsq [rsi], [rdi]",
			"test al, 0xa5",
			"test ax, 0x5aa5",
			"test eax, 0x12345aa5",
			"test rax, 0xffffffff82345aa5",
			"stosb [edi]",
			"stosb [rdi]",
			"stosw [edi]",
			"stosw [rdi]",
			"stosd [edi]",
			"stosd [rdi]",
			"stosq [edi]",
			"stosq [rdi]",
			"lodsb [esi]",
			"lodsb [rsi]",
			"lodsw [esi]",
			"lodsw [rsi]",
			"lodsd [esi]",
			"lodsd [rsi]",
			"lodsq [esi]",
			"lodsq [rsi]",
			"scasb [edi]",
			"scasb [rdi]",
			"scasw [edi]",
			"scasw [rdi]",
			"scasd [edi]",
			"scasd [rdi]",
			"scasq [edi]",
			"scasq [rdi]",
			"mov al, 0x5a",
			"mov r8b, 0x5a",
			"mov cl, 0xa5",
			"mov r9b, 0xa5",
			"mov dl, 0x5a",
			"mov r10b, 0x5a",
			"mov bl, 0xa5",
			"mov r11b, 0xa5",
			"mov ah, 0x5a",
			"mov spl, 0x5a",
			"mov r12b, 0x5a",
			"mov ch, 0xa5",
			"mov bpl, 0xa5",
			"mov r13b, 0xa5",
			"mov dh, 0x5a",
			"mov sil, 0x5a",
			"mov r14b, 0x5a",
			"mov bh, 0xa5",
			"mov dil, 0xa5",
			"mov r15b, 0xa5",
			"mov ax, 0xa55a",
			"mov r8w, 0xa55a",
			"mov eax, 0x3412a55a",
			"mov r8d, 0x3412a55a",
			"mov rax, 0x3412a55a37261504",
			"mov r8, 0x3412a55a37261504",
			"mov cx, 0x5aa5",
			"mov r9w, 0x5aa5",
			"mov ecx, 0x78565aa5",
			"mov r9d, 0x78565aa5",
			"mov rcx, 0x78565aa537261504",
			"mov r9, 0x78565aa537261504",
			"mov dx, 0xa55a",
			"mov r10w, 0xa55a",
			"mov edx, 0x3412a55a",
			"mov r10d, 0x3412a55a",
			"mov rdx, 0x3412a55a37261504",
			"mov r10, 0x3412a55a37261504",
			"mov bx, 0x5aa5",
			"mov r11w, 0x5aa5",
			"mov ebx, 0x78565aa5",
			"mov r11d, 0x78565aa5",
			"mov rbx, 0x78565aa537261504",
			"mov r11, 0x78565aa537261504",
			"mov sp, 0xa55a",
			"mov r12w, 0xa55a",
			"mov esp, 0x3412a55a",
			"mov r12d, 0x3412a55a",
			"mov rsp, 0x3412a55a37261504",
			"mov r12, 0x3412a55a37261504",
			"mov bp, 0x5aa5",
			"mov r13w, 0x5aa5",
			"mov ebp, 0x78565aa5",
			"mov r13d, 0x78565aa5",
			"mov rbp, 0x78565aa537261504",
			"mov r13, 0x78565aa537261504",
			"mov si, 0xa55a",
			"mov r14w, 0xa55a",
			"mov esi, 0x3412a55a",
			"mov r14d, 0x3412a55a",
			"mov rsi, 0x3412a55a37261504",
			"mov r14, 0x3412a55a37261504",
			"mov di, 0x5aa5",
			"mov r15w, 0x5aa5",
			"mov edi, 0x78565aa5",
			"mov r15d, 0x78565aa5",
			"mov rdi, 0x78565aa537261504",
			"mov r15, 0x78565aa537261504",
			"rol cl, 0x5a",
			"rol byte ptr [rax], 0x5a",
			"ror dl, 0xa5",
			"ror byte ptr [rax], 0xa5",
			"rcl bl, 0x5a",
			"rcl byte ptr [rax], 0x5a",
			"rcr ah, 0xa5",
			"rcr byte ptr [rax], 0xa5",
			"shl ch, 0x5a",
			"shl byte ptr [rax], 0x5a",
			"shr dh, 0xa5",
			"shr byte ptr [rax], 0xa5",
			"sar al, 0xa5",
			"sar byte ptr [rax], 0xa5",
			"rol cx, 0x5a",
			"rol word ptr [rax], 0x5a",
			"rol ecx, 0x5a",
			"rol dword ptr [rax], 0x5a",
			"rol rcx, 0x5a",
			"rol qword ptr [rax], 0x5a",
			"ror dx, 0xa5",
			"ror word ptr [rax], 0xa5",
			"ror edx, 0xa5",
			"ror dword ptr [rax], 0xa5",
			"ror rdx, 0xa5",
			"ror qword ptr [rax], 0xa5",
			"rcl bx, 0x5a",
			"rcl word ptr [rax], 0x5a",
			"rcl ebx, 0x5a",
			"rcl dword ptr [rax], 0x5a",
			"rcl rbx, 0x5a",
			"rcl qword ptr [rax], 0x5a",
			"rcr sp, 0xa5",
			"rcr word ptr [rax], 0xa5",
			"rcr esp, 0xa5",
			"rcr dword ptr [rax], 0xa5",
			"rcr rsp, 0xa5",
			"rcr qword ptr [rax], 0xa5",
			"shl bp, 0x5a",
			"shl word ptr [rax], 0x5a",
			"shl ebp, 0x5a",
			"shl dword ptr [rax], 0x5a",
			"shl rbp, 0x5a",
			"shl qword ptr [rax], 0x5a",
			"shr si, 0xa5",
			"shr word ptr [rax], 0xa5",
			"shr esi, 0xa5",
			"shr dword ptr [rax], 0xa5",
			"shr rsi, 0xa5",
			"shr qword ptr [rax], 0xa5",
			"sar ax, 0xa5",
			"sar word ptr [rax], 0xa5",
			"sar eax, 0xa5",
			"sar dword ptr [rax], 0xa5",
			"sar r8, 0xa5",
			"sar qword ptr [rax], 0xa5",
			"ret 0xa55a",
			"ret",
			"mov cl, 0x5a",
			"mov byte ptr [rax], 0x5a",
			"xabort 0x5a",
			"mov cx, 0xa55a",
			"mov word ptr [rax], 0xa55a",
			"mov ecx, 0x3412a55a",
			"mov dword ptr [rax], 0x3412a55a",
			"mov rcx, 0xffffffff8412a55a",
			"mov qword ptr [rax], 0xffffffff8412a55a",
			"data16 xbegin 0x7fffffffffffa54f",
			"xbegin 0x800000003412a550",
			"data64 xbegin 0x800000003412a551",
			"data16 enter 0xa55a, 0xa6",
			"enter 0xa55a, 0xa6",
			"data16 leave",
			"leave",
			"data16 ret far 0xa55a",
			"data32 ret far 0xa55a",
			"data64 ret far 0xa55a",
			"data16 ret far",
			"data32 ret far",
			"data64 ret far",
			"int3",
			"int 0x5a",
			"iret",
			"iretd",
			"iretq",
			"rol cl, 1",
			"rol byte ptr [rax], 1",
			"ror dl, 1",
			"ror byte ptr [rax], 1",
			"rcl bl, 1",
			"rcl byte ptr [rax], 1",
			"rcr ah, 1",
			"rcr byte ptr [rax], 1",
			"shl ch, 1",
			"shl byte ptr [rax], 1",
			"shr dh, 1",
			"shr byte ptr [rax], 1",
			"sar al, 1",
			"sar byte ptr [rax], 1",
			"rol cx, 1",
			"rol word ptr [rax], 1",
			"rol ecx, 1",
			"rol dword ptr [rax], 1",
			"rol rcx, 1",
			"rol qword ptr [rax], 1",
			"ror dx, 1",
			"ror word ptr [rax], 1",
			"ror edx, 1",
			"ror dword ptr [rax], 1",
			"ror rdx, 1",
			"ror qword ptr [rax], 1",
			"rcl bx, 1",
			"rcl word ptr [rax], 1",
			"rcl ebx, 1",
			"rcl dword ptr [rax], 1",
			"rcl rbx, 1",
			"rcl qword ptr [rax], 1",
			"rcr sp, 1",
			"rcr word ptr [rax], 1",
			"rcr esp, 1",
			"rcr dword ptr [rax], 1",
			"rcr rsp, 1",
			"rcr qword ptr [rax], 1",
			"shl bp, 1",
			"shl word ptr [rax], 1",
			"shl ebp, 1",
			"shl dword ptr [rax], 1",
			"shl rbp, 1",
			"shl qword ptr [rax], 1",
			"shr si, 1",
			"shr word ptr [rax], 1",
			"shr esi, 1",
			"shr dword ptr [rax], 1",
			"shr rsi, 1",
			"shr qword ptr [rax], 1",
			"sar ax, 1",
			"sar word ptr [rax], 1",
			"sar eax, 1",
			"sar dword ptr [rax], 1",
			"sar r8, 1",
			"sar qword ptr [rax], 1",
			"rol cl, cl",
			"rol byte ptr [rax], cl",
			"ror dl, cl",
			"ror byte ptr [rax], cl",
			"rcl bl, cl",
			"rcl byte ptr [rax], cl",
			"rcr ah, cl",
			"rcr byte ptr [rax], cl",
			"shl ch, cl",
			"shl byte ptr [rax], cl",
			"shr dh, cl",
			"shr byte ptr [rax], cl",
			"sar al, cl",
			"sar byte ptr [rax], cl",
			"rol cx, cl",
			"rol word ptr [rax], cl",
			"rol ecx, cl",
			"rol dword ptr [rax], cl",
			"rol rcx, cl",
			"rol qword ptr [rax], cl",
			"ror dx, cl",
			"ror word ptr [rax], cl",
			"ror edx, cl",
			"ror dword ptr [rax], cl",
			"ror rdx, cl",
			"ror qword ptr [rax], cl",
			"rcl bx, cl",
			"rcl word ptr [rax], cl",
			"rcl ebx, cl",
			"rcl dword ptr [rax], cl",
			"rcl rbx, cl",
			"rcl qword ptr [rax], cl",
			"rcr sp, cl",
			"rcr word ptr [rax], cl",
			"rcr esp, cl",
			"rcr dword ptr [rax], cl",
			"rcr rsp, cl",
			"rcr qword ptr [rax], cl",
			"shl bp, cl",
			"shl word ptr [rax], cl",
			"shl ebp, cl",
			"shl dword ptr [rax], cl",
			"shl rbp, cl",
			"shl qword ptr [rax], cl",
			"shr si, cl",
			"shr word ptr [rax], cl",
			"shr esi, cl",
			"shr dword ptr [rax], cl",
			"shr rsi, cl",
			"shr qword ptr [rax], cl",
			"sar ax, cl",
			"sar word ptr [rax], cl",
			"sar eax, cl",
			"sar dword ptr [rax], cl",
			"sar r8, cl",
			"sar qword ptr [rax], cl",
			"xlat [rbx]",
			"fadd st, dword ptr [rax]",
			"fmul st, dword ptr [rax]",
			"fcom st, dword ptr [rax]",
			"fcomp st, dword ptr [rax]",
			"fsub st, dword ptr [rax]",
			"fsubr st, dword ptr [rax]",
			"fdiv st, dword ptr [rax]",
			"fdivr st, dword ptr [rax]",
			"fadd st, st(3)",
			"fmul st, st(3)",
			"fcom st, st(3)",
			"fcomp st, st(3)",
			"fsub st, st(3)",
			"fsubr st, st(3)",
			"fdiv st, st(3)",
			"fdivr st, st(3)",
			"fld st, dword ptr [rax]",
			"fst dword ptr [rax], st",
			"fstp dword ptr [rax], st",
			"fldenv fpuenv14 ptr [rax]",
			"fldenv [rax]",
			"fldcw [rax]",
			"fnstenv fpuenv14 ptr [rax]",
			"fnstenv [rax]",
			"fnstcw [rax]",
			"fld st, st(3)",
			"fxch st, st(3)",
			"fnop",
			"fchs",
			"fabs",
			"ftst",
			"fxam",
			"fld1",
			"fldl2t",
			"fldl2e",
			"fldpi",
			"fldlg2",
			"fldln2",
			"fldz",
			"f2xm1",
			"fyl2x",
			"fptan",
			"fpatan",
			"fxtract",
			"fprem1",
			"fdecstp",
			"fincstp",
			"fprem",
			"fyl2xp1",
			"fsqrt",
			"fsincos",
			"frndint",
			"fscale",
			"fsin",
			"fcos",
			"fiadd st, dword ptr [rax]",
			"fimul st, dword ptr [rax]",
			"ficom st, dword ptr [rax]",
			"ficomp st, dword ptr [rax]",
			"fisub st, dword ptr [rax]",
			"fisubr st, dword ptr [rax]",
			"fidiv st, dword ptr [rax]",
			"fidivr st, dword ptr [rax]",
			"fcmovb st, st(3)",
			"fcmove st, st(3)",
			"fcmovbe st, st(3)",
			"fcmovu st, st(3)",
			"fucompp",
			"fild st, dword ptr [rax]",
			"fisttp dword ptr [rax], st",
			"fist dword ptr [rax], st",
			"fistp dword ptr [rax], st",
			"fld st, tbyte ptr [rax]",
			"fstp tbyte ptr [rax], st",
			"fcmovnb st, st(3)",
			"fcmovne st, st(3)",
			"fcmovnbe st, st(3)",
			"fcmovnu st, st(3)",
			"fnclex",
			"fninit",
			"fucomi st, st(3)",
			"fcomi st, st(3)",
			"fadd st, qword ptr [rax]",
			"fmul st, qword ptr [rax]",
			"fcom st, qword ptr [rax]",
			"fcomp st, qword ptr [rax]",
			"fsub st, qword ptr [rax]",
			"fsubr st, qword ptr [rax]",
			"fdiv st, qword ptr [rax]",
			"fdivr st, qword ptr [rax]",
			"fadd st(3), st",
			"fmul st(3), st",
			"fsubr st(3), st",
			"fsub st(3), st",
			"fdivr st(3), st",
			"fdiv st(3), st",
			"fld st, qword ptr [rax]",
			"fisttp qword ptr [rax], st",
			"fst qword ptr [rax], st",
			"fstp qword ptr [rax], st",
			"frstor fpustate94 ptr [rax]",
			"frstor [rax]",
			"fnsave fpustate94 ptr [rax]",
			"fnsave [rax]",
			"fnstsw [rax]",
			"ffree st(3)",
			"fst st(3), st",
			"fstp st(3), st",
			"fucom st, st(3)",
			"fucomp st, st(3)",
			"fiadd st, word ptr [rax]",
			"fimul st, word ptr [rax]",
			"ficom st, word ptr [rax]",
			"ficomp st, word ptr [rax]",
			"fisub st, word ptr [rax]",
			"fisubr st, word ptr [rax]",
			"fidiv st, word ptr [rax]",
			"fidivr st, word ptr [rax]",
			"faddp st(3), st",
			"fmulp st(3), st",
			"fcompp",
			"fsubrp st(3), st",
			"fsubp st(3), st",
			"fdivrp st(3), st",
			"fdivp st(3), st",
			"fild st, word ptr [rax]",
			"fisttp word ptr [rax], st",
			"fist word ptr [rax], st",
			"fistp word ptr [rax], st",
			"fbld st, tbyte ptr [rax]",
			"fild st, qword ptr [rax]",
			"fbstp tbyte ptr [rax], st",
			"fistp qword ptr [rax], st",
			"fnstsw ax",
			"fucomip st, st(3)",
			"fcomip st, st(3)",
			"data16 addr32 loopne 0x004e",
			"addr32 loopne 0x800000000000004d",
			"data16 loopne 0x004d",
			"loopne 0x800000000000004c",
			"data16 addr32 loope 0x004e",
			"addr32 loope 0x800000000000004d",
			"data16 loope 0x004d",
			"loope 0x800000000000004c",
			"data16 addr32 loop 0x004e",
			"addr32 loop 0x800000000000004d",
			"data16 loop 0x004d",
			"loop 0x800000000000004c",
			"data16 jecxz 0x004e",
			"jecxz 0x800000000000004d",
			"data16 jrcxz 0x004d",
			"jrcxz 0x800000000000004c",
			"in al, 0x5a",
			"in ax, 0x5a",
			"in eax, 0x5a",
			"out 0x5a, al",
			"out 0x5a, ax",
			"out 0x5a, eax",
			"call 0x7fffffffa55a3407",
			"jmp 0x7fffffffa55a3407",
			"jmp 0x800000000000004c",
			"in al, dx",
			"in ax, dx",
			"in eax, dx",
			"out dx, al",
			"out dx, ax",
			"out dx, eax",
			"int1",
			"hlt",
			"cmc",
			"test cl, 0x5a",
			"test byte ptr [rax], 0x5a",
			"not cl",
			"not byte ptr [rax]",
			"neg dh",
			"neg byte ptr [rax]",
			"mul ch",
			"mul byte ptr [rax]",
			"imul dh",
			"imul byte ptr [rax]",
			"div bh",
			"div byte ptr [rax]",
			"idiv al",
		};
	}
}
#endif
