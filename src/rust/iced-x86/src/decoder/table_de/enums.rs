/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

use core::fmt;

// GENERATOR-BEGIN: SerializedDataKind
// ⚠️This was generated by GENERATOR!🦹‍♂️
#[derive(Copy, Clone, Eq, PartialEq)]
#[allow(non_camel_case_types)]
#[allow(dead_code)]
pub(crate) enum SerializedDataKind {
	HandlerReference,
	ArrayReference,
}
#[cfg_attr(feature = "cargo-fmt", rustfmt::skip)]
static GEN_DEBUG_SERIALIZED_DATA_KIND: [&str; 2] = [
	"HandlerReference",
	"ArrayReference",
];
impl fmt::Debug for SerializedDataKind {
	#[inline]
	fn fmt<'a>(&self, f: &mut fmt::Formatter<'a>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_SERIALIZED_DATA_KIND[*self as usize])?;
		Ok(())
	}
}
impl Default for SerializedDataKind {
	#[cfg_attr(has_must_use, must_use)]
	#[inline]
	fn default() -> Self {
		SerializedDataKind::HandlerReference
	}
}
// GENERATOR-END: SerializedDataKind

// GENERATOR-BEGIN: OpCodeHandlerKind
// ⚠️This was generated by GENERATOR!🦹‍♂️
#[derive(Copy, Clone, Eq, PartialEq)]
#[allow(non_camel_case_types)]
#[allow(dead_code)]
pub(crate) enum OpCodeHandlerKind {
	Bitness,
	Bitness_DontReadModRM,
	Invalid,
	Invalid_NoModRM,
	Invalid2,
	Dup,
	Null,
	HandlerReference,
	ArrayReference,
	RM,
	Options3,
	Options5,
	Options_DontReadModRM,
	AnotherTable,
	Group,
	Group8x64,
	Group8x8,
	MandatoryPrefix,
	MandatoryPrefix4,
	Ev_REXW_1a,
	MandatoryPrefix_NoModRM,
	MandatoryPrefix3,
	D3NOW,
	EVEX,
	VEX2,
	VEX3,
	XOP,
	AL_DX,
	Ap,
	B_BM,
	B_Ev,
	B_MIB,
	BM_B,
	BranchIw,
	BranchSimple,
	C_R_3a,
	C_R_3b,
	DX_AL,
	DX_eAX,
	eAX_DX,
	Eb_1,
	Eb_2,
	Eb_CL,
	Eb_Gb_1,
	Eb_Gb_2,
	Eb_Ib_1,
	Eb_Ib_2,
	Eb1,
	Ed_V_Ib,
	Ep,
	Ev_3a,
	Ev_3b,
	Ev_4,
	Ev_CL,
	Ev_Gv_32_64,
	Ev_Gv_3a,
	Ev_Gv_3b,
	Ev_Gv_4,
	Ev_Gv_CL,
	Ev_Gv_Ib,
	Ev_Gv_REX,
	Ev_Ib_3,
	Ev_Ib_4,
	Ev_Ib2_3,
	Ev_Ib2_4,
	Ev_Iz_3,
	Ev_Iz_4,
	Ev_P,
	Ev_REXW,
	Ev_Sw,
	Ev_VX,
	Ev1,
	Evj,
	Evw,
	Ew,
	Gb_Eb,
	Gdq_Ev,
	Gv_Eb,
	Gv_Eb_REX,
	Gv_Ev_32_64,
	Gv_Ev_3a,
	Gv_Ev_3b,
	Gv_Ev_Ib,
	Gv_Ev_Ib_REX,
	Gv_Ev_Iz,
	Gv_Ev_REX,
	Gv_Ev2,
	Gv_Ev3,
	Gv_Ew,
	Gv_M,
	Gv_M_as,
	Gv_Ma,
	Gv_Mp_2,
	Gv_Mp_3,
	Gv_Mv,
	Gv_N,
	Gv_N_Ib_REX,
	Gv_RX,
	Gv_W,
	GvM_VX_Ib,
	Ib,
	Ib3,
	IbReg,
	IbReg2,
	Iw_Ib,
	Jb,
	Jb2,
	Jdisp,
	Jx,
	Jz,
	M_1,
	M_2,
	M_REXW_2,
	M_REXW_4,
	MemBx,
	Mf_1,
	Mf_2a,
	Mf_2b,
	MIB_B,
	MP,
	Ms,
	MV,
	Mv_Gv,
	Mv_Gv_REXW,
	NIb,
	Ob_Reg,
	Ov_Reg,
	P_Ev,
	P_Ev_Ib,
	P_Q,
	P_Q_Ib,
	P_R,
	P_W,
	PushEv,
	PushIb2,
	PushIz,
	PushOpSizeReg_4a,
	PushOpSizeReg_4b,
	PushSimple2,
	PushSimpleReg,
	Q_P,
	R_C_3a,
	R_C_3b,
	rDI_P_N,
	rDI_VX_RX,
	Reg,
	Reg_Ib2,
	Reg_Iz,
	Reg_Ob,
	Reg_Ov,
	Reg_Xb,
	Reg_Xv,
	Reg_Xv2,
	Reg_Yb,
	Reg_Yv,
	RegIb,
	RegIb3,
	RegIz2,
	ReservedNop,
	RIb,
	RIbIb,
	Rv,
	Rv_32_64,
	RvMw_Gw,
	Simple,
	Simple_ModRM,
	Simple2_3a,
	Simple2_3b,
	Simple2Iw,
	Simple3,
	Simple4,
	Simple5,
	Simple5_ModRM_as,
	SimpleReg,
	ST_STi,
	STi,
	STi_ST,
	Sw_Ev,
	V_Ev,
	VM,
	VN,
	VQ,
	VRIbIb,
	VW_2,
	VW_3,
	VWIb_2,
	VWIb_3,
	VX_E_Ib,
	VX_Ev,
	Wbinvd,
	WV,
	Xb_Yb,
	Xchg_Reg_rAX,
	Xv_Yv,
	Yb_Reg,
	Yb_Xb,
	Yv_Reg,
	Yv_Reg2,
	Yv_Xv,
	Simple4b,
	Options1632_1,
	Options1632_2,
	M_Sw,
	Sw_M,
}
#[cfg_attr(feature = "cargo-fmt", rustfmt::skip)]
static GEN_DEBUG_OP_CODE_HANDLER_KIND: [&str; 204] = [
	"Bitness",
	"Bitness_DontReadModRM",
	"Invalid",
	"Invalid_NoModRM",
	"Invalid2",
	"Dup",
	"Null",
	"HandlerReference",
	"ArrayReference",
	"RM",
	"Options3",
	"Options5",
	"Options_DontReadModRM",
	"AnotherTable",
	"Group",
	"Group8x64",
	"Group8x8",
	"MandatoryPrefix",
	"MandatoryPrefix4",
	"Ev_REXW_1a",
	"MandatoryPrefix_NoModRM",
	"MandatoryPrefix3",
	"D3NOW",
	"EVEX",
	"VEX2",
	"VEX3",
	"XOP",
	"AL_DX",
	"Ap",
	"B_BM",
	"B_Ev",
	"B_MIB",
	"BM_B",
	"BranchIw",
	"BranchSimple",
	"C_R_3a",
	"C_R_3b",
	"DX_AL",
	"DX_eAX",
	"eAX_DX",
	"Eb_1",
	"Eb_2",
	"Eb_CL",
	"Eb_Gb_1",
	"Eb_Gb_2",
	"Eb_Ib_1",
	"Eb_Ib_2",
	"Eb1",
	"Ed_V_Ib",
	"Ep",
	"Ev_3a",
	"Ev_3b",
	"Ev_4",
	"Ev_CL",
	"Ev_Gv_32_64",
	"Ev_Gv_3a",
	"Ev_Gv_3b",
	"Ev_Gv_4",
	"Ev_Gv_CL",
	"Ev_Gv_Ib",
	"Ev_Gv_REX",
	"Ev_Ib_3",
	"Ev_Ib_4",
	"Ev_Ib2_3",
	"Ev_Ib2_4",
	"Ev_Iz_3",
	"Ev_Iz_4",
	"Ev_P",
	"Ev_REXW",
	"Ev_Sw",
	"Ev_VX",
	"Ev1",
	"Evj",
	"Evw",
	"Ew",
	"Gb_Eb",
	"Gdq_Ev",
	"Gv_Eb",
	"Gv_Eb_REX",
	"Gv_Ev_32_64",
	"Gv_Ev_3a",
	"Gv_Ev_3b",
	"Gv_Ev_Ib",
	"Gv_Ev_Ib_REX",
	"Gv_Ev_Iz",
	"Gv_Ev_REX",
	"Gv_Ev2",
	"Gv_Ev3",
	"Gv_Ew",
	"Gv_M",
	"Gv_M_as",
	"Gv_Ma",
	"Gv_Mp_2",
	"Gv_Mp_3",
	"Gv_Mv",
	"Gv_N",
	"Gv_N_Ib_REX",
	"Gv_RX",
	"Gv_W",
	"GvM_VX_Ib",
	"Ib",
	"Ib3",
	"IbReg",
	"IbReg2",
	"Iw_Ib",
	"Jb",
	"Jb2",
	"Jdisp",
	"Jx",
	"Jz",
	"M_1",
	"M_2",
	"M_REXW_2",
	"M_REXW_4",
	"MemBx",
	"Mf_1",
	"Mf_2a",
	"Mf_2b",
	"MIB_B",
	"MP",
	"Ms",
	"MV",
	"Mv_Gv",
	"Mv_Gv_REXW",
	"NIb",
	"Ob_Reg",
	"Ov_Reg",
	"P_Ev",
	"P_Ev_Ib",
	"P_Q",
	"P_Q_Ib",
	"P_R",
	"P_W",
	"PushEv",
	"PushIb2",
	"PushIz",
	"PushOpSizeReg_4a",
	"PushOpSizeReg_4b",
	"PushSimple2",
	"PushSimpleReg",
	"Q_P",
	"R_C_3a",
	"R_C_3b",
	"rDI_P_N",
	"rDI_VX_RX",
	"Reg",
	"Reg_Ib2",
	"Reg_Iz",
	"Reg_Ob",
	"Reg_Ov",
	"Reg_Xb",
	"Reg_Xv",
	"Reg_Xv2",
	"Reg_Yb",
	"Reg_Yv",
	"RegIb",
	"RegIb3",
	"RegIz2",
	"ReservedNop",
	"RIb",
	"RIbIb",
	"Rv",
	"Rv_32_64",
	"RvMw_Gw",
	"Simple",
	"Simple_ModRM",
	"Simple2_3a",
	"Simple2_3b",
	"Simple2Iw",
	"Simple3",
	"Simple4",
	"Simple5",
	"Simple5_ModRM_as",
	"SimpleReg",
	"ST_STi",
	"STi",
	"STi_ST",
	"Sw_Ev",
	"V_Ev",
	"VM",
	"VN",
	"VQ",
	"VRIbIb",
	"VW_2",
	"VW_3",
	"VWIb_2",
	"VWIb_3",
	"VX_E_Ib",
	"VX_Ev",
	"Wbinvd",
	"WV",
	"Xb_Yb",
	"Xchg_Reg_rAX",
	"Xv_Yv",
	"Yb_Reg",
	"Yb_Xb",
	"Yv_Reg",
	"Yv_Reg2",
	"Yv_Xv",
	"Simple4b",
	"Options1632_1",
	"Options1632_2",
	"M_Sw",
	"Sw_M",
];
impl fmt::Debug for OpCodeHandlerKind {
	#[inline]
	fn fmt<'a>(&self, f: &mut fmt::Formatter<'a>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_OP_CODE_HANDLER_KIND[*self as usize])?;
		Ok(())
	}
}
impl Default for OpCodeHandlerKind {
	#[cfg_attr(has_must_use, must_use)]
	#[inline]
	fn default() -> Self {
		OpCodeHandlerKind::Bitness
	}
}
// GENERATOR-END: OpCodeHandlerKind

// GENERATOR-BEGIN: EvexOpCodeHandlerKind
// ⚠️This was generated by GENERATOR!🦹‍♂️
#[derive(Copy, Clone, Eq, PartialEq)]
#[allow(non_camel_case_types)]
#[cfg(not(feature = "no_evex"))]
#[allow(dead_code)]
pub(crate) enum EvexOpCodeHandlerKind {
	Invalid,
	Invalid2,
	Dup,
	HandlerReference,
	ArrayReference,
	RM,
	Group,
	W,
	MandatoryPrefix2,
	VectorLength,
	VectorLength_er,
	Ed_V_Ib,
	Ev_VX,
	Ev_VX_Ib,
	Gv_W_er,
	GvM_VX_Ib,
	HkWIb_3,
	HkWIb_3b,
	HWIb,
	KkHW_3,
	KkHW_3b,
	KkHWIb_sae_3,
	KkHWIb_sae_3b,
	KkHWIb_3,
	KkHWIb_3b,
	KkWIb_3,
	KkWIb_3b,
	KP1HW,
	KR,
	MV,
	V_H_Ev_er,
	V_H_Ev_Ib,
	VHM,
	VHW_3,
	VHW_4,
	VHWIb,
	VK,
	Vk_VSIB,
	VkEv_REXW_2,
	VkEv_REXW_3,
	VkHM,
	VkHW_3,
	VkHW_3b,
	VkHW_5,
	VkHW_er_4,
	VkHW_er_4b,
	VkHWIb_3,
	VkHWIb_3b,
	VkHWIb_5,
	VkHWIb_er_4,
	VkHWIb_er_4b,
	VkM,
	VkW_3,
	VkW_3b,
	VkW_4,
	VkW_4b,
	VkW_er_4,
	VkW_er_5,
	VkW_er_6,
	VkWIb_3,
	VkWIb_3b,
	VkWIb_er,
	VM,
	VSIB_k1,
	VSIB_k1_VX,
	VW,
	VW_er,
	VX_Ev,
	WkHV,
	WkV_3,
	WkV_4a,
	WkV_4b,
	WkVIb,
	WkVIb_er,
	WV,
}
#[cfg(not(feature = "no_evex"))]
#[cfg_attr(feature = "cargo-fmt", rustfmt::skip)]
static GEN_DEBUG_EVEX_OP_CODE_HANDLER_KIND: [&str; 75] = [
	"Invalid",
	"Invalid2",
	"Dup",
	"HandlerReference",
	"ArrayReference",
	"RM",
	"Group",
	"W",
	"MandatoryPrefix2",
	"VectorLength",
	"VectorLength_er",
	"Ed_V_Ib",
	"Ev_VX",
	"Ev_VX_Ib",
	"Gv_W_er",
	"GvM_VX_Ib",
	"HkWIb_3",
	"HkWIb_3b",
	"HWIb",
	"KkHW_3",
	"KkHW_3b",
	"KkHWIb_sae_3",
	"KkHWIb_sae_3b",
	"KkHWIb_3",
	"KkHWIb_3b",
	"KkWIb_3",
	"KkWIb_3b",
	"KP1HW",
	"KR",
	"MV",
	"V_H_Ev_er",
	"V_H_Ev_Ib",
	"VHM",
	"VHW_3",
	"VHW_4",
	"VHWIb",
	"VK",
	"Vk_VSIB",
	"VkEv_REXW_2",
	"VkEv_REXW_3",
	"VkHM",
	"VkHW_3",
	"VkHW_3b",
	"VkHW_5",
	"VkHW_er_4",
	"VkHW_er_4b",
	"VkHWIb_3",
	"VkHWIb_3b",
	"VkHWIb_5",
	"VkHWIb_er_4",
	"VkHWIb_er_4b",
	"VkM",
	"VkW_3",
	"VkW_3b",
	"VkW_4",
	"VkW_4b",
	"VkW_er_4",
	"VkW_er_5",
	"VkW_er_6",
	"VkWIb_3",
	"VkWIb_3b",
	"VkWIb_er",
	"VM",
	"VSIB_k1",
	"VSIB_k1_VX",
	"VW",
	"VW_er",
	"VX_Ev",
	"WkHV",
	"WkV_3",
	"WkV_4a",
	"WkV_4b",
	"WkVIb",
	"WkVIb_er",
	"WV",
];
#[cfg(not(feature = "no_evex"))]
impl fmt::Debug for EvexOpCodeHandlerKind {
	#[inline]
	fn fmt<'a>(&self, f: &mut fmt::Formatter<'a>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_EVEX_OP_CODE_HANDLER_KIND[*self as usize])?;
		Ok(())
	}
}
#[cfg(not(feature = "no_evex"))]
impl Default for EvexOpCodeHandlerKind {
	#[cfg_attr(has_must_use, must_use)]
	#[inline]
	fn default() -> Self {
		EvexOpCodeHandlerKind::Invalid
	}
}
// GENERATOR-END: EvexOpCodeHandlerKind

// GENERATOR-BEGIN: VexOpCodeHandlerKind
// ⚠️This was generated by GENERATOR!🦹‍♂️
#[derive(Copy, Clone, Eq, PartialEq)]
#[allow(non_camel_case_types)]
#[cfg(any(not(feature = "no_vex"), not(feature = "no_xop")))]
#[allow(dead_code)]
pub(crate) enum VexOpCodeHandlerKind {
	Invalid,
	Invalid2,
	Dup,
	Invalid_NoModRM,
	Bitness_DontReadModRM,
	HandlerReference,
	ArrayReference,
	RM,
	Group,
	W,
	MandatoryPrefix2_1,
	MandatoryPrefix2_4,
	MandatoryPrefix2_NoModRM,
	VectorLength_NoModRM,
	VectorLength,
	Ed_V_Ib,
	Ev_VX,
	G_VK,
	Gv_Ev_Gv,
	Gv_Ev_Ib,
	Gv_Ev_Id,
	Gv_GPR_Ib,
	Gv_Gv_Ev,
	Gv_RX,
	Gv_W,
	GvM_VX_Ib,
	HRIb,
	Hv_Ed_Id,
	Hv_Ev,
	M,
	MHV,
	M_VK,
	MV,
	rDI_VX_RX,
	RdRq,
	Simple,
	VHEv,
	VHEvIb,
	VHIs4W,
	VHIs5W,
	VHM,
	VHW_2,
	VHW_3,
	VHW_4,
	VHWIb_2,
	VHWIb_4,
	VHWIs4,
	VHWIs5,
	VK_HK_RK,
	VK_R,
	VK_RK,
	VK_RK_Ib,
	VK_WK,
	VM,
	VW_2,
	VW_3,
	VWH,
	VWIb_2,
	VWIb_3,
	VX_Ev,
	VX_VSIB_HX,
	WHV,
	WV,
	WVIb,
	VT_SIBMEM,
	SIBMEM_VT,
	VT,
	VT_RT_HT,
	Group8x64,
	Bitness,
	Null,
}
#[cfg(any(not(feature = "no_vex"), not(feature = "no_xop")))]
#[cfg_attr(feature = "cargo-fmt", rustfmt::skip)]
static GEN_DEBUG_VEX_OP_CODE_HANDLER_KIND: [&str; 71] = [
	"Invalid",
	"Invalid2",
	"Dup",
	"Invalid_NoModRM",
	"Bitness_DontReadModRM",
	"HandlerReference",
	"ArrayReference",
	"RM",
	"Group",
	"W",
	"MandatoryPrefix2_1",
	"MandatoryPrefix2_4",
	"MandatoryPrefix2_NoModRM",
	"VectorLength_NoModRM",
	"VectorLength",
	"Ed_V_Ib",
	"Ev_VX",
	"G_VK",
	"Gv_Ev_Gv",
	"Gv_Ev_Ib",
	"Gv_Ev_Id",
	"Gv_GPR_Ib",
	"Gv_Gv_Ev",
	"Gv_RX",
	"Gv_W",
	"GvM_VX_Ib",
	"HRIb",
	"Hv_Ed_Id",
	"Hv_Ev",
	"M",
	"MHV",
	"M_VK",
	"MV",
	"rDI_VX_RX",
	"RdRq",
	"Simple",
	"VHEv",
	"VHEvIb",
	"VHIs4W",
	"VHIs5W",
	"VHM",
	"VHW_2",
	"VHW_3",
	"VHW_4",
	"VHWIb_2",
	"VHWIb_4",
	"VHWIs4",
	"VHWIs5",
	"VK_HK_RK",
	"VK_R",
	"VK_RK",
	"VK_RK_Ib",
	"VK_WK",
	"VM",
	"VW_2",
	"VW_3",
	"VWH",
	"VWIb_2",
	"VWIb_3",
	"VX_Ev",
	"VX_VSIB_HX",
	"WHV",
	"WV",
	"WVIb",
	"VT_SIBMEM",
	"SIBMEM_VT",
	"VT",
	"VT_RT_HT",
	"Group8x64",
	"Bitness",
	"Null",
];
#[cfg(any(not(feature = "no_vex"), not(feature = "no_xop")))]
impl fmt::Debug for VexOpCodeHandlerKind {
	#[inline]
	fn fmt<'a>(&self, f: &mut fmt::Formatter<'a>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_VEX_OP_CODE_HANDLER_KIND[*self as usize])?;
		Ok(())
	}
}
#[cfg(any(not(feature = "no_vex"), not(feature = "no_xop")))]
impl Default for VexOpCodeHandlerKind {
	#[cfg_attr(has_must_use, must_use)]
	#[inline]
	fn default() -> Self {
		VexOpCodeHandlerKind::Invalid
	}
}
// GENERATOR-END: VexOpCodeHandlerKind
