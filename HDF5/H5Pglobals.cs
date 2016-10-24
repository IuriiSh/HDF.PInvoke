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
    public unsafe sealed partial class H5P
    {

        static readonly hid_t H5P_CLS_ROOT_g = H5DLLImporter.Instance.GetHid("H5P_CLS_ROOT_ID_g");

        public static hid_t ROOT => H5P_CLS_ROOT_g;

        static readonly hid_t H5P_CLS_OBJECT_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_CLS_OBJECT_CREATE_ID_g");

        public static hid_t OBJECT_CREATE => H5P_CLS_OBJECT_CREATE_g;

        static readonly hid_t H5P_CLS_FILE_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_CLS_FILE_CREATE_ID_g");

        public static hid_t FILE_CREATE => H5P_CLS_FILE_CREATE_g;

        static readonly hid_t H5P_CLS_FILE_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_CLS_FILE_ACCESS_ID_g");

        public static hid_t FILE_ACCESS => H5P_CLS_FILE_ACCESS_g;

        static readonly hid_t H5P_CLS_DATASET_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_CLS_DATASET_CREATE_ID_g");

        public static hid_t DATASET_CREATE => H5P_CLS_DATASET_CREATE_g;

        static readonly hid_t H5P_CLS_DATASET_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_CLS_DATASET_ACCESS_ID_g");

        public static hid_t DATASET_ACCESS => H5P_CLS_DATASET_ACCESS_g;

        static readonly hid_t H5P_CLS_DATASET_XFER_g = H5DLLImporter.Instance.GetHid("H5P_CLS_DATASET_XFER_ID_g");

        public static hid_t DATASET_XFER => H5P_CLS_DATASET_XFER_g;

        static readonly hid_t H5P_CLS_FILE_MOUNT_g = H5DLLImporter.Instance.GetHid("H5P_CLS_FILE_MOUNT_ID_g");

        public static hid_t FILE_MOUNT => H5P_CLS_FILE_MOUNT_g;

        static readonly hid_t H5P_CLS_GROUP_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_CLS_GROUP_CREATE_ID_g");

        public static hid_t GROUP_CREATE => H5P_CLS_GROUP_CREATE_g;

        static readonly hid_t H5P_CLS_GROUP_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_CLS_GROUP_ACCESS_ID_g");

        public static hid_t GROUP_ACCESS => H5P_CLS_GROUP_ACCESS_g;

        static readonly hid_t H5P_CLS_DATATYPE_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_CLS_DATATYPE_CREATE_ID_g");

        public static hid_t DATATYPE_CREATE => H5P_CLS_DATATYPE_CREATE_g;

        static readonly hid_t H5P_CLS_DATATYPE_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_CLS_DATATYPE_ACCESS_ID_g");

        public static hid_t DATATYPE_ACCESS => H5P_CLS_DATATYPE_ACCESS_g;

        static readonly hid_t H5P_CLS_STRING_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_CLS_STRING_CREATE_ID_g");

        public static hid_t STRING_CREATE => H5P_CLS_STRING_CREATE_g;

        static readonly hid_t H5P_CLS_ATTRIBUTE_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_CLS_ATTRIBUTE_CREATE_ID_g");

        public static hid_t ATTRIBUTE_CREATE => H5P_CLS_ATTRIBUTE_CREATE_g;

        static readonly hid_t H5P_CLS_OBJECT_COPY_g = H5DLLImporter.Instance.GetHid("H5P_CLS_OBJECT_COPY_ID_g");

        public static hid_t OBJECT_COPY => H5P_CLS_OBJECT_COPY_g;

        static readonly hid_t H5P_CLS_LINK_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_CLS_LINK_CREATE_ID_g");

        public static hid_t LINK_CREATE => H5P_CLS_LINK_CREATE_g;

        static readonly hid_t H5P_CLS_LINK_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_CLS_LINK_ACCESS_ID_g");

        public static hid_t LINK_ACCESS => H5P_CLS_LINK_ACCESS_g;

        static readonly hid_t H5P_LST_FILE_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_LST_FILE_CREATE_ID_g");

        public static hid_t LST_FILE_CREATE => H5P_LST_FILE_CREATE_g;

        static readonly hid_t H5P_LST_FILE_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_LST_FILE_ACCESS_ID_g");

        public static hid_t LST_FILE_ACCESS => H5P_LST_FILE_ACCESS_g;

        static readonly hid_t H5P_LST_DATASET_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_LST_DATASET_CREATE_ID_g");

        public static hid_t LST_DATASET_CREATE => H5P_LST_DATASET_CREATE_g;

        static readonly hid_t H5P_LST_DATASET_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_LST_DATASET_ACCESS_ID_g");

        public static hid_t LST_DATASET_ACCESS => H5P_LST_DATASET_ACCESS_g;

        static readonly hid_t H5P_LST_DATASET_XFER_g = H5DLLImporter.Instance.GetHid("H5P_LST_DATASET_XFER_ID_g");

        public static hid_t LST_DATASET_XFER => H5P_LST_DATASET_XFER_g;

        static readonly hid_t H5P_LST_FILE_MOUNT_g = H5DLLImporter.Instance.GetHid("H5P_LST_FILE_MOUNT_ID_g");

        public static hid_t LST_FILE_MOUNT => H5P_LST_FILE_MOUNT_g;

        static readonly hid_t H5P_LST_GROUP_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_LST_GROUP_CREATE_ID_g");

        public static hid_t LST_GROUP_CREATE => H5P_LST_GROUP_CREATE_g;

        static readonly hid_t H5P_LST_GROUP_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_LST_GROUP_ACCESS_ID_g");

        public static hid_t LST_GROUP_ACCESS => H5P_LST_GROUP_ACCESS_g;

        static readonly hid_t H5P_LST_DATATYPE_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_LST_DATATYPE_CREATE_ID_g");

        public static hid_t LST_DATATYPE_CREATE => H5P_LST_DATATYPE_CREATE_g;

        static readonly hid_t H5P_LST_DATATYPE_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_LST_DATATYPE_ACCESS_ID_g");

        public static hid_t LST_DATATYPE_ACCESS => H5P_LST_DATATYPE_ACCESS_g;

        static readonly hid_t H5P_LST_ATTRIBUTE_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_LST_ATTRIBUTE_CREATE_ID_g");

        public static hid_t LST_ATTRIBUTE_CREATE => H5P_LST_ATTRIBUTE_CREATE_g;

        static readonly hid_t H5P_LST_OBJECT_COPY_g = H5DLLImporter.Instance.GetHid("H5P_LST_OBJECT_COPY_ID_g");

        public static hid_t LST_OBJECT_COPY => H5P_LST_OBJECT_COPY_g;

        static readonly hid_t H5P_LST_LINK_CREATE_g = H5DLLImporter.Instance.GetHid("H5P_LST_LINK_CREATE_ID_g");

        public static hid_t LST_LINK_CREATE => H5P_LST_LINK_CREATE_g;

        static readonly hid_t H5P_LST_LINK_ACCESS_g = H5DLLImporter.Instance.GetHid("H5P_LST_LINK_ACCESS_ID_g");

        public static hid_t LST_LINK_ACCESS => H5P_LST_LINK_ACCESS_g;
    }
}
