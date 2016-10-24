/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Copyright by The HDF Group.                                               *
 * Copyright by the Board of Trustees of the University of Illinois.         *
 * All rights reserved.                                                      *
 *                                                                           *
 * This file is part of HDF5.  The full HDF5 copyright notice, including     *
 * terms governing use, modification, and redistribution, is contained in    *
 * the files COPYING and Copyright.html.  COPYING can be found at the root   *
 * of the source code distribution tree; Copyright.html can be found at the  *
 * root level of an installed copy of the electronic HDF5 document set and   *
 * is linked from the top-level documents page.  It can also be found at     *
 * http://hdfgroup.org/HDF5/doc/Copyright.html.  If you do not have          *
 * access to either file, you may request a copy from help@hdfgroup.org.     *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using hbool_t = System.Int32;
using herr_t = System.Int32;
using hsize_t = System.UInt64;
using htri_t = System.Int32;
using size_t = System.IntPtr;

#if HDF5_VER1_10
using hid_t = System.Int64;
#else
using hid_t = System.Int32;
#endif

namespace HDF.PInvoke
{
    public unsafe sealed partial class H5T
    {

        static readonly hid_t H5T_IEEE_F32BE_g = H5DLLImporter.Instance.GetHid("H5T_IEEE_F32BE_g");

        public static hid_t IEEE_F32BE => H5T_IEEE_F32BE_g;

        static readonly hid_t H5T_IEEE_F32LE_g = H5DLLImporter.Instance.GetHid("H5T_IEEE_F32LE_g");

        public static hid_t IEEE_F32LE => H5T_IEEE_F32LE_g;

        static readonly hid_t H5T_IEEE_F64BE_g = H5DLLImporter.Instance.GetHid("H5T_IEEE_F64BE_g");

        public static hid_t IEEE_F64BE => H5T_IEEE_F64BE_g;

        static readonly hid_t H5T_IEEE_F64LE_g = H5DLLImporter.Instance.GetHid("H5T_IEEE_F64LE_g");

        public static hid_t IEEE_F64LE => H5T_IEEE_F64LE_g;

        static readonly hid_t H5T_STD_I8BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_I8BE_g");

        public static hid_t STD_I8BE => H5T_STD_I8BE_g;

        static readonly hid_t H5T_STD_I8LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_I8LE_g");

        public static hid_t STD_I8LE => H5T_STD_I8LE_g;

        static readonly hid_t H5T_STD_I16BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_I16BE_g");

        public static hid_t STD_I16BE => H5T_STD_I16BE_g;

        static readonly hid_t H5T_STD_I16LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_I16LE_g");

        public static hid_t STD_I16LE => H5T_STD_I16LE_g;

        static readonly hid_t H5T_STD_I32BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_I32BE_g");

        public static hid_t STD_I32BE => H5T_STD_I32BE_g;

        static readonly hid_t H5T_STD_I32LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_I32LE_g");

        public static hid_t STD_I32LE => H5T_STD_I32LE_g;

        static readonly hid_t H5T_STD_I64BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_I64BE_g");

        public static hid_t STD_I64BE => H5T_STD_I64BE_g;

        static readonly hid_t H5T_STD_I64LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_I64LE_g");

        public static hid_t STD_I64LE => H5T_STD_I64LE_g;

        static readonly hid_t H5T_STD_U8BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_U8BE_g");

        public static hid_t STD_U8BE => H5T_STD_U8BE_g;

        static readonly hid_t H5T_STD_U8LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_U8LE_g");

        public static hid_t STD_U8LE => H5T_STD_U8LE_g;

        static readonly hid_t H5T_STD_U16BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_U16BE_g");

        public static hid_t STD_U16BE => H5T_STD_U16BE_g;

        static readonly hid_t H5T_STD_U16LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_U16LE_g");

        public static hid_t STD_U16LE => H5T_STD_U16LE_g;

        static readonly hid_t H5T_STD_U32BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_U32BE_g");

        public static hid_t STD_U32BE => H5T_STD_U32BE_g;

        static readonly hid_t H5T_STD_U32LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_U32LE_g");

        public static hid_t STD_U32LE => H5T_STD_U32LE_g;

        static readonly hid_t H5T_STD_U64BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_U64BE_g");

        public static hid_t STD_U64BE => H5T_STD_U64BE_g;

        static readonly hid_t H5T_STD_U64LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_U64LE_g");

        public static hid_t STD_U64LE => H5T_STD_U64LE_g;

        static readonly hid_t H5T_STD_B8BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_B8BE_g");

        public static hid_t STD_B8BE => H5T_STD_B8BE_g;

        static readonly hid_t H5T_STD_B8LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_B8LE_g");

        public static hid_t STD_B8LE => H5T_STD_B8LE_g;

        static readonly hid_t H5T_STD_B16BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_B16BE_g");

        public static hid_t STD_B16BE => H5T_STD_B16BE_g;

        static readonly hid_t H5T_STD_B16LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_B16LE_g");

        public static hid_t STD_B16LE => H5T_STD_B16LE_g;

        static readonly hid_t H5T_STD_B32BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_B32BE_g");

        public static hid_t STD_B32BE => H5T_STD_B32BE_g;

        static readonly hid_t H5T_STD_B32LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_B32LE_g");

        public static hid_t STD_B32LE => H5T_STD_B32LE_g;

        static readonly hid_t H5T_STD_B64BE_g = H5DLLImporter.Instance.GetHid("H5T_STD_B64BE_g");

        public static hid_t STD_B64BE => H5T_STD_B64BE_g;

        static readonly hid_t H5T_STD_B64LE_g = H5DLLImporter.Instance.GetHid("H5T_STD_B64LE_g");

        public static hid_t STD_B64LE => H5T_STD_B64LE_g;

        static readonly hid_t H5T_STD_REF_OBJ_g = H5DLLImporter.Instance.GetHid("H5T_STD_REF_OBJ_g");

        public static hid_t STD_REF_OBJ => H5T_STD_REF_OBJ_g;

        static readonly hid_t H5T_STD_REF_DSETREG_g = H5DLLImporter.Instance.GetHid("H5T_STD_REF_DSETREG_g");

        public static hid_t STD_REF_DSETREG => H5T_STD_REF_DSETREG_g;

        static readonly hid_t H5T_UNIX_D32BE_g = H5DLLImporter.Instance.GetHid("H5T_UNIX_D32BE_g");

        public static hid_t UNIX_D32BE => H5T_UNIX_D32BE_g;

        static readonly hid_t H5T_UNIX_D32LE_g = H5DLLImporter.Instance.GetHid("H5T_UNIX_D32LE_g");

        public static hid_t UNIX_D32LE => H5T_UNIX_D32LE_g;

        static readonly hid_t H5T_UNIX_D64BE_g = H5DLLImporter.Instance.GetHid("H5T_UNIX_D64BE_g");

        public static hid_t UNIX_D64BE => H5T_UNIX_D64BE_g;

        static readonly hid_t H5T_UNIX_D64LE_g = H5DLLImporter.Instance.GetHid("H5T_UNIX_D64LE_g");

        public static hid_t UNIX_D64LE => H5T_UNIX_D64LE_g;

        static readonly hid_t H5T_C_S1_g = H5DLLImporter.Instance.GetHid("H5T_C_S1_g");

        public static hid_t C_S1 => H5T_C_S1_g;

        static readonly hid_t H5T_FORTRAN_S1_g = H5DLLImporter.Instance.GetHid("H5T_FORTRAN_S1_g");

        public static hid_t FORTRAN_S1 => H5T_FORTRAN_S1_g;

        static readonly hid_t H5T_VAX_F32_g = H5DLLImporter.Instance.GetHid("H5T_VAX_F32_g");

        public static hid_t VAX_F32 => H5T_VAX_F32_g;

        static readonly hid_t H5T_VAX_F64_g = H5DLLImporter.Instance.GetHid("H5T_VAX_F64_g");

        public static hid_t VAX_F64 => H5T_VAX_F64_g;

        static readonly hid_t H5T_NATIVE_SCHAR_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_SCHAR_g");

        public static hid_t NATIVE_SCHAR => H5T_NATIVE_SCHAR_g;

        static readonly hid_t H5T_NATIVE_UCHAR_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UCHAR_g");

        public static hid_t NATIVE_UCHAR => H5T_NATIVE_UCHAR_g;

        static readonly hid_t H5T_NATIVE_SHORT_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_SHORT_g");

        public static hid_t NATIVE_SHORT => H5T_NATIVE_SHORT_g;

        static readonly hid_t H5T_NATIVE_USHORT_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_USHORT_g");

        public static hid_t NATIVE_USHORT => H5T_NATIVE_USHORT_g;

        static readonly hid_t H5T_NATIVE_INT_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT_g");

        public static hid_t NATIVE_INT => H5T_NATIVE_INT_g;

        static readonly hid_t H5T_NATIVE_UINT_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT_g");

        public static hid_t NATIVE_UINT => H5T_NATIVE_UINT_g;

        static readonly hid_t H5T_NATIVE_LONG_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_LONG_g");

        public static hid_t NATIVE_LONG => H5T_NATIVE_LONG_g;

        static readonly hid_t H5T_NATIVE_ULONG_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_ULONG_g");

        public static hid_t NATIVE_ULONG => H5T_NATIVE_ULONG_g;

        static readonly hid_t H5T_NATIVE_LLONG_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_LLONG_g");

        public static hid_t NATIVE_LLONG => H5T_NATIVE_LLONG_g;

        static readonly hid_t H5T_NATIVE_ULLONG_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_ULLONG_g");

        public static hid_t NATIVE_ULLONG => H5T_NATIVE_ULLONG_g;

        static readonly hid_t H5T_NATIVE_FLOAT_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_FLOAT_g");

        public static hid_t NATIVE_FLOAT => H5T_NATIVE_FLOAT_g;

        static readonly hid_t H5T_NATIVE_DOUBLE_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_DOUBLE_g");

        public static hid_t NATIVE_DOUBLE => H5T_NATIVE_DOUBLE_g;

        static readonly hid_t H5T_NATIVE_LDOUBLE_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_LDOUBLE_g");

        public static hid_t NATIVE_LDOUBLE => H5T_NATIVE_LDOUBLE_g;

        static readonly hid_t H5T_NATIVE_B8_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_B8_g");

        public static hid_t NATIVE_B8 => H5T_NATIVE_B8_g;

        static readonly hid_t H5T_NATIVE_B16_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_B16_g");

        public static hid_t NATIVE_B16 => H5T_NATIVE_B16_g;

        static readonly hid_t H5T_NATIVE_B32_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_B32_g");

        public static hid_t NATIVE_B32 => H5T_NATIVE_B32_g;

        static readonly hid_t H5T_NATIVE_B64_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_B64_g");

        public static hid_t NATIVE_B64 => H5T_NATIVE_B64_g;

        static readonly hid_t H5T_NATIVE_OPAQUE_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_OPAQUE_g");

        public static hid_t NATIVE_OPAQUE => H5T_NATIVE_OPAQUE_g;

        static readonly hid_t H5T_NATIVE_HADDR_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_HADDR_g");

        public static hid_t NATIVE_HADDR => H5T_NATIVE_HADDR_g;

        static readonly hid_t H5T_NATIVE_HSIZE_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_HSIZE_g");

        public static hid_t NATIVE_HSIZE => H5T_NATIVE_HSIZE_g;

        static readonly hid_t H5T_NATIVE_HSSIZE_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_HSSIZE_g");

        public static hid_t NATIVE_HSSIZE => H5T_NATIVE_HSSIZE_g;

        static readonly hid_t H5T_NATIVE_HERR_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_HERR_g");

        public static hid_t NATIVE_HERR => H5T_NATIVE_HERR_g;

        static readonly hid_t H5T_NATIVE_HBOOL_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_HBOOL_g");

        public static hid_t NATIVE_HBOOL => H5T_NATIVE_HBOOL_g;

        static readonly hid_t H5T_NATIVE_INT8_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT8_g");

        public static hid_t NATIVE_INT8 => H5T_NATIVE_INT8_g;

        static readonly hid_t H5T_NATIVE_UINT8_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT8_g");

        public static hid_t NATIVE_UINT8 => H5T_NATIVE_UINT8_g;

        static readonly hid_t H5T_NATIVE_INT_LEAST8_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT_LEAST8_g");

        public static hid_t NATIVE_INT_LEAST8 => H5T_NATIVE_INT_LEAST8_g;

        static readonly hid_t H5T_NATIVE_UINT_LEAST8_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT_LEAST8_g");

        public static hid_t NATIVE_UINT_LEAST8 => H5T_NATIVE_UINT_LEAST8_g;

        static readonly hid_t H5T_NATIVE_INT_FAST8_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT_FAST8_g");

        public static hid_t NATIVE_INT_FAST8 => H5T_NATIVE_INT_FAST8_g;

        static readonly hid_t H5T_NATIVE_UINT_FAST8_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT_FAST8_g");

        public static hid_t NATIVE_UINT_FAST8 => H5T_NATIVE_UINT_FAST8_g;

        static readonly hid_t H5T_NATIVE_INT16_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT16_g");

        public static hid_t NATIVE_INT16 => H5T_NATIVE_INT16_g;

        static readonly hid_t H5T_NATIVE_UINT16_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT16_g");

        public static hid_t NATIVE_UINT16 => H5T_NATIVE_UINT16_g;

        static readonly hid_t H5T_NATIVE_INT_LEAST16_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT_LEAST16_g");

        public static hid_t NATIVE_INT_LEAST16 => H5T_NATIVE_INT_LEAST16_g;

        static readonly hid_t H5T_NATIVE_UINT_LEAST16_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT_LEAST16_g");

        public static hid_t NATIVE_UINT_LEAST16 => H5T_NATIVE_UINT_LEAST16_g;

        static readonly hid_t H5T_NATIVE_INT_FAST16_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT_FAST16_g");

        public static hid_t NATIVE_INT_FAST16 => H5T_NATIVE_INT_FAST16_g;

        static readonly hid_t H5T_NATIVE_UINT_FAST16_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT_FAST16_g");

        public static hid_t NATIVE_UINT_FAST16 => H5T_NATIVE_UINT_FAST16_g;

        static readonly hid_t H5T_NATIVE_INT32_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT32_g");

        public static hid_t NATIVE_INT32 => H5T_NATIVE_INT32_g;

        static readonly hid_t H5T_NATIVE_UINT32_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT32_g");

        public static hid_t NATIVE_UINT32 => H5T_NATIVE_UINT32_g;

        static readonly hid_t H5T_NATIVE_INT_LEAST32_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT_LEAST32_g");

        public static hid_t NATIVE_INT_LEAST32 => H5T_NATIVE_INT_LEAST32_g;

        static readonly hid_t H5T_NATIVE_UINT_LEAST32_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT_LEAST32_g");

        public static hid_t NATIVE_UINT_LEAST32 => H5T_NATIVE_UINT_LEAST32_g;

        static readonly hid_t H5T_NATIVE_INT_FAST32_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT_FAST32_g");

        public static hid_t NATIVE_INT_FAST32 => H5T_NATIVE_INT_FAST32_g;

        static readonly hid_t H5T_NATIVE_UINT_FAST32_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT_FAST32_g");

        public static hid_t NATIVE_UINT_FAST32 => H5T_NATIVE_UINT_FAST32_g;

        static readonly hid_t H5T_NATIVE_INT64_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT64_g");

        public static hid_t NATIVE_INT64 => H5T_NATIVE_INT64_g;

        static readonly hid_t H5T_NATIVE_UINT64_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT64_g");

        public static hid_t NATIVE_UINT64 => H5T_NATIVE_UINT64_g;

        static readonly hid_t H5T_NATIVE_INT_LEAST64_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT_LEAST64_g");

        public static hid_t NATIVE_INT_LEAST64 => H5T_NATIVE_INT_LEAST64_g;

        static readonly hid_t H5T_NATIVE_UINT_LEAST64_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT_LEAST64_g");

        public static hid_t NATIVE_UINT_LEAST64 => H5T_NATIVE_UINT_LEAST64_g;

        static readonly hid_t H5T_NATIVE_INT_FAST64_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_INT_FAST64_g");

        public static hid_t NATIVE_INT_FAST64 => H5T_NATIVE_INT_FAST64_g;

        static readonly hid_t H5T_NATIVE_UINT_FAST64_g = H5DLLImporter.Instance.GetHid("H5T_NATIVE_UINT_FAST64_g");

        public static hid_t NATIVE_UINT_FAST64 => H5T_NATIVE_UINT_FAST64_g;

        public static hid_t INTEL_I8 => H5T_STD_I8LE_g;

        public static hid_t INTEL_I16 => H5T_STD_I16LE_g;

        public static hid_t INTEL_I32 => H5T_STD_I32LE_g;

        public static hid_t INTEL_I64 => H5T_STD_I64LE_g;

        public static hid_t INTEL_U8 => H5T_STD_U8LE_g;

        public static hid_t INTEL_U16 => H5T_STD_U16LE_g;

        public static hid_t INTEL_U32 => H5T_STD_U32LE_g;

        public static hid_t INTEL_U64 => H5T_STD_U64LE_g;

        public static hid_t INTEL_B8 => H5T_STD_B8LE_g;

        public static hid_t INTEL_B16 => H5T_STD_B16LE_g;

        public static hid_t INTEL_B32 => H5T_STD_B32LE_g;

        public static hid_t INTEL_B64 => H5T_STD_B64LE_g;

        public static hid_t INTEL_F32 => H5T_IEEE_F32LE_g;

        public static hid_t INTEL_F64 => H5T_IEEE_F64LE_g;

        public static hid_t ALPHA_I8 => H5T_STD_I8LE_g;

        public static hid_t ALPHA_I16 => H5T_STD_I16LE_g;

        public static hid_t ALPHA_I32 => H5T_STD_I32LE_g;

        public static hid_t ALPHA_I64 => H5T_STD_I64LE_g;

        public static hid_t ALPHA_U8 => H5T_STD_U8LE_g;

        public static hid_t ALPHA_U16 => H5T_STD_U16LE_g;

        public static hid_t ALPHA_U32 => H5T_STD_U32LE_g;

        public static hid_t ALPHA_U64 => H5T_STD_U64LE_g;

        public static hid_t ALPHA_B8 => H5T_STD_B8LE_g;

        public static hid_t ALPHA_B16 => H5T_STD_B16LE_g;

        public static hid_t ALPHA_B32 => H5T_STD_B32LE_g;

        public static hid_t ALPHA_B64 => H5T_STD_B64LE_g;

        public static hid_t ALPHA_F32 => H5T_IEEE_F32LE_g;

        public static hid_t ALPHA_F64 => H5T_IEEE_F64LE_g;

        public static hid_t MIPS_I8 => H5T_STD_I8BE_g;

        public static hid_t MIPS_I16 => H5T_STD_I16BE_g;

        public static hid_t MIPS_I32 => H5T_STD_I32BE_g;

        public static hid_t MIPS_I64 => H5T_STD_I64BE_g;

        public static hid_t MIPS_U8 => H5T_STD_U8BE_g;

        public static hid_t MIPS_U16 => H5T_STD_U16BE_g;

        public static hid_t MIPS_U32 => H5T_STD_U32BE_g;

        public static hid_t MIPS_U64 => H5T_STD_U64BE_g;

        public static hid_t MIPS_B8 => H5T_STD_B8BE_g;

        public static hid_t MIPS_B16 => H5T_STD_B16BE_g;

        public static hid_t MIPS_B32 => H5T_STD_B32BE_g;

        public static hid_t MIPS_B64 => H5T_STD_B64BE_g;

        public static hid_t MIPS_F32 => H5T_IEEE_F32BE_g;

        public static hid_t MIPS_F64 => H5T_IEEE_F64BE_g;

        public static hid_t NATIVE_CHAR => H5T_NATIVE_SCHAR_g;
    }
}
