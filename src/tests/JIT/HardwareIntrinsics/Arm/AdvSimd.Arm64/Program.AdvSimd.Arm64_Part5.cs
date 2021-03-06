// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.Arm
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["StorePairScalarNonTemporal.Vector64.UInt32"] = StorePairScalarNonTemporal_Vector64_UInt32,
                ["StorePairNonTemporal.Vector64.Byte"] = StorePairNonTemporal_Vector64_Byte,
                ["StorePairNonTemporal.Vector64.Double"] = StorePairNonTemporal_Vector64_Double,
                ["StorePairNonTemporal.Vector64.Int16"] = StorePairNonTemporal_Vector64_Int16,
                ["StorePairNonTemporal.Vector64.Int32"] = StorePairNonTemporal_Vector64_Int32,
                ["StorePairNonTemporal.Vector64.Int64"] = StorePairNonTemporal_Vector64_Int64,
                ["StorePairNonTemporal.Vector64.SByte"] = StorePairNonTemporal_Vector64_SByte,
                ["StorePairNonTemporal.Vector64.Single"] = StorePairNonTemporal_Vector64_Single,
                ["StorePairNonTemporal.Vector64.UInt16"] = StorePairNonTemporal_Vector64_UInt16,
                ["StorePairNonTemporal.Vector64.UInt32"] = StorePairNonTemporal_Vector64_UInt32,
                ["StorePairNonTemporal.Vector64.UInt64"] = StorePairNonTemporal_Vector64_UInt64,
                ["StorePairNonTemporal.Vector128.Byte"] = StorePairNonTemporal_Vector128_Byte,
                ["StorePairNonTemporal.Vector128.Double"] = StorePairNonTemporal_Vector128_Double,
                ["StorePairNonTemporal.Vector128.Int16"] = StorePairNonTemporal_Vector128_Int16,
                ["StorePairNonTemporal.Vector128.Int32"] = StorePairNonTemporal_Vector128_Int32,
                ["StorePairNonTemporal.Vector128.Int64"] = StorePairNonTemporal_Vector128_Int64,
                ["StorePairNonTemporal.Vector128.SByte"] = StorePairNonTemporal_Vector128_SByte,
                ["StorePairNonTemporal.Vector128.Single"] = StorePairNonTemporal_Vector128_Single,
                ["StorePairNonTemporal.Vector128.UInt16"] = StorePairNonTemporal_Vector128_UInt16,
                ["StorePairNonTemporal.Vector128.UInt32"] = StorePairNonTemporal_Vector128_UInt32,
                ["StorePairNonTemporal.Vector128.UInt64"] = StorePairNonTemporal_Vector128_UInt64,
                ["Subtract.Vector128.Double"] = Subtract_Vector128_Double,
                ["SubtractSaturateScalar.Vector64.Byte"] = SubtractSaturateScalar_Vector64_Byte,
                ["SubtractSaturateScalar.Vector64.Int16"] = SubtractSaturateScalar_Vector64_Int16,
                ["SubtractSaturateScalar.Vector64.Int32"] = SubtractSaturateScalar_Vector64_Int32,
                ["SubtractSaturateScalar.Vector64.SByte"] = SubtractSaturateScalar_Vector64_SByte,
                ["SubtractSaturateScalar.Vector64.UInt16"] = SubtractSaturateScalar_Vector64_UInt16,
                ["SubtractSaturateScalar.Vector64.UInt32"] = SubtractSaturateScalar_Vector64_UInt32,
                ["TransposeEven.Vector64.Byte"] = TransposeEven_Vector64_Byte,
                ["TransposeEven.Vector64.Int16"] = TransposeEven_Vector64_Int16,
                ["TransposeEven.Vector64.Int32"] = TransposeEven_Vector64_Int32,
                ["TransposeEven.Vector64.SByte"] = TransposeEven_Vector64_SByte,
                ["TransposeEven.Vector64.Single"] = TransposeEven_Vector64_Single,
                ["TransposeEven.Vector64.UInt16"] = TransposeEven_Vector64_UInt16,
                ["TransposeEven.Vector64.UInt32"] = TransposeEven_Vector64_UInt32,
                ["TransposeEven.Vector128.Byte"] = TransposeEven_Vector128_Byte,
                ["TransposeEven.Vector128.Double"] = TransposeEven_Vector128_Double,
                ["TransposeEven.Vector128.Int16"] = TransposeEven_Vector128_Int16,
                ["TransposeEven.Vector128.Int32"] = TransposeEven_Vector128_Int32,
                ["TransposeEven.Vector128.Int64"] = TransposeEven_Vector128_Int64,
                ["TransposeEven.Vector128.SByte"] = TransposeEven_Vector128_SByte,
                ["TransposeEven.Vector128.Single"] = TransposeEven_Vector128_Single,
                ["TransposeEven.Vector128.UInt16"] = TransposeEven_Vector128_UInt16,
                ["TransposeEven.Vector128.UInt32"] = TransposeEven_Vector128_UInt32,
                ["TransposeEven.Vector128.UInt64"] = TransposeEven_Vector128_UInt64,
                ["TransposeOdd.Vector64.Byte"] = TransposeOdd_Vector64_Byte,
                ["TransposeOdd.Vector64.Int16"] = TransposeOdd_Vector64_Int16,
                ["TransposeOdd.Vector64.Int32"] = TransposeOdd_Vector64_Int32,
                ["TransposeOdd.Vector64.SByte"] = TransposeOdd_Vector64_SByte,
                ["TransposeOdd.Vector64.Single"] = TransposeOdd_Vector64_Single,
                ["TransposeOdd.Vector64.UInt16"] = TransposeOdd_Vector64_UInt16,
                ["TransposeOdd.Vector64.UInt32"] = TransposeOdd_Vector64_UInt32,
                ["TransposeOdd.Vector128.Byte"] = TransposeOdd_Vector128_Byte,
                ["TransposeOdd.Vector128.Double"] = TransposeOdd_Vector128_Double,
                ["TransposeOdd.Vector128.Int16"] = TransposeOdd_Vector128_Int16,
                ["TransposeOdd.Vector128.Int32"] = TransposeOdd_Vector128_Int32,
                ["TransposeOdd.Vector128.Int64"] = TransposeOdd_Vector128_Int64,
                ["TransposeOdd.Vector128.SByte"] = TransposeOdd_Vector128_SByte,
                ["TransposeOdd.Vector128.Single"] = TransposeOdd_Vector128_Single,
                ["TransposeOdd.Vector128.UInt16"] = TransposeOdd_Vector128_UInt16,
                ["TransposeOdd.Vector128.UInt32"] = TransposeOdd_Vector128_UInt32,
                ["TransposeOdd.Vector128.UInt64"] = TransposeOdd_Vector128_UInt64,
                ["VectorTableLookup.Vector128.Byte"] = VectorTableLookup_Vector128_Byte,
                ["VectorTableLookup.Vector128.SByte"] = VectorTableLookup_Vector128_SByte,
                ["VectorTableLookupExtension.Vector128.Byte"] = VectorTableLookupExtension_Vector128_Byte,
                ["VectorTableLookupExtension.Vector128.SByte"] = VectorTableLookupExtension_Vector128_SByte,
                ["UnzipEven.Vector64.Byte"] = UnzipEven_Vector64_Byte,
                ["UnzipEven.Vector64.Int16"] = UnzipEven_Vector64_Int16,
                ["UnzipEven.Vector64.Int32"] = UnzipEven_Vector64_Int32,
                ["UnzipEven.Vector64.SByte"] = UnzipEven_Vector64_SByte,
                ["UnzipEven.Vector64.Single"] = UnzipEven_Vector64_Single,
                ["UnzipEven.Vector64.UInt16"] = UnzipEven_Vector64_UInt16,
                ["UnzipEven.Vector64.UInt32"] = UnzipEven_Vector64_UInt32,
                ["UnzipEven.Vector128.Byte"] = UnzipEven_Vector128_Byte,
                ["UnzipEven.Vector128.Double"] = UnzipEven_Vector128_Double,
                ["UnzipEven.Vector128.Int16"] = UnzipEven_Vector128_Int16,
                ["UnzipEven.Vector128.Int32"] = UnzipEven_Vector128_Int32,
                ["UnzipEven.Vector128.Int64"] = UnzipEven_Vector128_Int64,
                ["UnzipEven.Vector128.SByte"] = UnzipEven_Vector128_SByte,
                ["UnzipEven.Vector128.Single"] = UnzipEven_Vector128_Single,
                ["UnzipEven.Vector128.UInt16"] = UnzipEven_Vector128_UInt16,
                ["UnzipEven.Vector128.UInt32"] = UnzipEven_Vector128_UInt32,
                ["UnzipEven.Vector128.UInt64"] = UnzipEven_Vector128_UInt64,
                ["UnzipOdd.Vector64.Byte"] = UnzipOdd_Vector64_Byte,
                ["UnzipOdd.Vector64.Int16"] = UnzipOdd_Vector64_Int16,
                ["UnzipOdd.Vector64.Int32"] = UnzipOdd_Vector64_Int32,
                ["UnzipOdd.Vector64.SByte"] = UnzipOdd_Vector64_SByte,
                ["UnzipOdd.Vector64.Single"] = UnzipOdd_Vector64_Single,
                ["UnzipOdd.Vector64.UInt16"] = UnzipOdd_Vector64_UInt16,
                ["UnzipOdd.Vector64.UInt32"] = UnzipOdd_Vector64_UInt32,
                ["UnzipOdd.Vector128.Byte"] = UnzipOdd_Vector128_Byte,
                ["UnzipOdd.Vector128.Double"] = UnzipOdd_Vector128_Double,
                ["UnzipOdd.Vector128.Int16"] = UnzipOdd_Vector128_Int16,
                ["UnzipOdd.Vector128.Int32"] = UnzipOdd_Vector128_Int32,
                ["UnzipOdd.Vector128.Int64"] = UnzipOdd_Vector128_Int64,
                ["UnzipOdd.Vector128.SByte"] = UnzipOdd_Vector128_SByte,
                ["UnzipOdd.Vector128.Single"] = UnzipOdd_Vector128_Single,
                ["UnzipOdd.Vector128.UInt16"] = UnzipOdd_Vector128_UInt16,
                ["UnzipOdd.Vector128.UInt32"] = UnzipOdd_Vector128_UInt32,
                ["UnzipOdd.Vector128.UInt64"] = UnzipOdd_Vector128_UInt64,
            };
        }
    }
}
