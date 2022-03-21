// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#ifndef __PAL_LOONGARCH64_ASMCONSTANTS_H__
#define __PAL_LOONGARCH64_ASMCONSTANTS_H__

//Please refence "src/pal/inc/pal.h"
#define CONTEXT_LOONGARCH64   0x00800000

#define CONTEXT_CONTROL_BIT (0)
#define CONTEXT_INTEGER_BIT (1)
#define CONTEXT_FLOATING_POINT_BIT (2)
#define CONTEXT_DEBUG_REGISTERS_BIT (3)

#define CONTEXT_CONTROL (CONTEXT_LOONGARCH64 | (1 << CONTEXT_CONTROL_BIT))
#define CONTEXT_INTEGER (CONTEXT_LOONGARCH64 | (1 << CONTEXT_INTEGER_BIT))
#define CONTEXT_FLOATING_POINT  (CONTEXT_LOONGARCH64 | (1 << CONTEXT_FLOATING_POINT_BIT))
#define CONTEXT_DEBUG_REGISTERS (CONTEXT_LOONGARCH64 | (1 << CONTEXT_DEBUG_REGISTERS_BIT))

#define CONTEXT_FULL (CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_FLOATING_POINT)

#define SIZEOF_LOONGARCH_GPR 8
#define SIZEOF_LOONGARCH_FPR 8

#define CONTEXT_ContextFlags 0
//Note: Here CONTEXT_ContextFlags+8 for memory algin.
#define CONTEXT_R0          CONTEXT_ContextFlags+SIZEOF_LOONGARCH_GPR
#define CONTEXT_Ra          CONTEXT_R0+SIZEOF_LOONGARCH_GPR
#define CONTEXT_Tp          CONTEXT_Ra+SIZEOF_LOONGARCH_GPR
#define CONTEXT_Sp          CONTEXT_Tp+SIZEOF_LOONGARCH_GPR
#define CONTEXT_A0          CONTEXT_Sp+SIZEOF_LOONGARCH_GPR
#define CONTEXT_A1          CONTEXT_A0+SIZEOF_LOONGARCH_GPR
#define CONTEXT_A2          CONTEXT_A1+SIZEOF_LOONGARCH_GPR
#define CONTEXT_A3          CONTEXT_A2+SIZEOF_LOONGARCH_GPR
#define CONTEXT_A4          CONTEXT_A3+SIZEOF_LOONGARCH_GPR
#define CONTEXT_A5          CONTEXT_A4+SIZEOF_LOONGARCH_GPR
#define CONTEXT_A6          CONTEXT_A5+SIZEOF_LOONGARCH_GPR
#define CONTEXT_A7          CONTEXT_A6+SIZEOF_LOONGARCH_GPR
#define CONTEXT_T0          CONTEXT_A7+SIZEOF_LOONGARCH_GPR
#define CONTEXT_T1          CONTEXT_T0+SIZEOF_LOONGARCH_GPR
#define CONTEXT_T2          CONTEXT_T1+SIZEOF_LOONGARCH_GPR
#define CONTEXT_T3          CONTEXT_T2+SIZEOF_LOONGARCH_GPR
#define CONTEXT_T4          CONTEXT_T3+SIZEOF_LOONGARCH_GPR
#define CONTEXT_T5          CONTEXT_T4+SIZEOF_LOONGARCH_GPR
#define CONTEXT_T6          CONTEXT_T5+SIZEOF_LOONGARCH_GPR
#define CONTEXT_T7          CONTEXT_T6+SIZEOF_LOONGARCH_GPR
#define CONTEXT_T8          CONTEXT_T7+SIZEOF_LOONGARCH_GPR
#define CONTEXT_X0          CONTEXT_T8+SIZEOF_LOONGARCH_GPR
#define CONTEXT_Fp          CONTEXT_X0+SIZEOF_LOONGARCH_GPR
#define CONTEXT_S0          CONTEXT_Fp+SIZEOF_LOONGARCH_GPR
#define CONTEXT_S1          CONTEXT_S0+SIZEOF_LOONGARCH_GPR
#define CONTEXT_S2          CONTEXT_S1+SIZEOF_LOONGARCH_GPR
#define CONTEXT_S3          CONTEXT_S2+SIZEOF_LOONGARCH_GPR
#define CONTEXT_S4          CONTEXT_S3+SIZEOF_LOONGARCH_GPR
#define CONTEXT_S5          CONTEXT_S4+SIZEOF_LOONGARCH_GPR
#define CONTEXT_S6          CONTEXT_S5+SIZEOF_LOONGARCH_GPR
#define CONTEXT_S7          CONTEXT_S6+SIZEOF_LOONGARCH_GPR
#define CONTEXT_S8          CONTEXT_S7+SIZEOF_LOONGARCH_GPR
#define CONTEXT_Pc          CONTEXT_S8+SIZEOF_LOONGARCH_GPR
#define CONTEXT_FPU_OFFSET  CONTEXT_Pc+SIZEOF_LOONGARCH_GPR

#define CONTEXT_F0           0
#define CONTEXT_F1           CONTEXT_F0+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F2           CONTEXT_F1+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F3           CONTEXT_F2+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F4           CONTEXT_F3+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F5           CONTEXT_F4+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F6           CONTEXT_F5+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F7           CONTEXT_F6+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F8           CONTEXT_F7+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F9           CONTEXT_F8+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F10          CONTEXT_F9+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F11          CONTEXT_F10+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F12          CONTEXT_F11+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F13          CONTEXT_F12+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F14          CONTEXT_F13+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F15          CONTEXT_F14+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F16          CONTEXT_F15+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F17          CONTEXT_F16+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F18          CONTEXT_F17+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F19          CONTEXT_F18+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F20          CONTEXT_F19+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F21          CONTEXT_F20+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F22          CONTEXT_F21+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F23          CONTEXT_F22+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F24          CONTEXT_F23+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F25          CONTEXT_F24+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F26          CONTEXT_F25+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F27          CONTEXT_F26+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F28          CONTEXT_F27+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F29          CONTEXT_F28+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F30          CONTEXT_F29+SIZEOF_LOONGARCH_FPR
#define CONTEXT_F31          CONTEXT_F30+SIZEOF_LOONGARCH_FPR
#define CONTEXT_FLOAT_CONTROL_OFFSET  CONTEXT_F31+SIZEOF_LOONGARCH_FPR
#define CONTEXT_Size         ((CONTEXT_FPU_OFFSET + 8 + 8 + 0xf) & ~0xf)

#endif
