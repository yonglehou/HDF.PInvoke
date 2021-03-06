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
    public unsafe sealed partial class H5E
    {
        static H5DLLImporter m_importer;

        static hid_t? H5E_ERR_CLS_g;

        public static hid_t ERR_CLS 
        {
            get
            {
                if (!H5E_ERR_CLS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_ERR_CLS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_ERR_CLS_g = val;
                    }
                }
                return H5E_ERR_CLS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_DATASET_g;

        public static hid_t DATASET 
        {
            get
            {
                if (!H5E_DATASET_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_DATASET_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_DATASET_g = val;
                    }
                }
                return H5E_DATASET_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_FUNC_g;

        public static hid_t FUNC 
        {
            get
            {
                if (!H5E_FUNC_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_FUNC_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_FUNC_g = val;
                    }
                }
                return H5E_FUNC_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_STORAGE_g;

        public static hid_t STORAGE 
        {
            get
            {
                if (!H5E_STORAGE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_STORAGE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_STORAGE_g = val;
                    }
                }
                return H5E_STORAGE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_FILE_g;

        public static hid_t FILE 
        {
            get
            {
                if (!H5E_FILE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_FILE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_FILE_g = val;
                    }
                }
                return H5E_FILE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_SOHM_g;

        public static hid_t SOHM 
        {
            get
            {
                if (!H5E_SOHM_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_SOHM_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_SOHM_g = val;
                    }
                }
                return H5E_SOHM_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_SYM_g;

        public static hid_t SYM 
        {
            get
            {
                if (!H5E_SYM_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_SYM_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_SYM_g = val;
                    }
                }
                return H5E_SYM_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_PLUGIN_g;

        public static hid_t PLUGIN 
        {
            get
            {
                if (!H5E_PLUGIN_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_PLUGIN_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_PLUGIN_g = val;
                    }
                }
                return H5E_PLUGIN_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_VFL_g;

        public static hid_t VFL 
        {
            get
            {
                if (!H5E_VFL_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_VFL_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_VFL_g = val;
                    }
                }
                return H5E_VFL_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_INTERNAL_g;

        public static hid_t INTERNAL 
        {
            get
            {
                if (!H5E_INTERNAL_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_INTERNAL_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_INTERNAL_g = val;
                    }
                }
                return H5E_INTERNAL_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BTREE_g;

        public static hid_t BTREE 
        {
            get
            {
                if (!H5E_BTREE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BTREE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BTREE_g = val;
                    }
                }
                return H5E_BTREE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_REFERENCE_g;

        public static hid_t REFERENCE 
        {
            get
            {
                if (!H5E_REFERENCE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_REFERENCE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_REFERENCE_g = val;
                    }
                }
                return H5E_REFERENCE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_DATASPACE_g;

        public static hid_t DATASPACE 
        {
            get
            {
                if (!H5E_DATASPACE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_DATASPACE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_DATASPACE_g = val;
                    }
                }
                return H5E_DATASPACE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_RESOURCE_g;

        public static hid_t RESOURCE 
        {
            get
            {
                if (!H5E_RESOURCE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_RESOURCE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_RESOURCE_g = val;
                    }
                }
                return H5E_RESOURCE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_PLIST_g;

        public static hid_t PLIST 
        {
            get
            {
                if (!H5E_PLIST_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_PLIST_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_PLIST_g = val;
                    }
                }
                return H5E_PLIST_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_LINK_g;

        public static hid_t LINK 
        {
            get
            {
                if (!H5E_LINK_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_LINK_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_LINK_g = val;
                    }
                }
                return H5E_LINK_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_DATATYPE_g;

        public static hid_t DATATYPE 
        {
            get
            {
                if (!H5E_DATATYPE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_DATATYPE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_DATATYPE_g = val;
                    }
                }
                return H5E_DATATYPE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_RS_g;

        public static hid_t RS 
        {
            get
            {
                if (!H5E_RS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_RS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_RS_g = val;
                    }
                }
                return H5E_RS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_HEAP_g;

        public static hid_t HEAP 
        {
            get
            {
                if (!H5E_HEAP_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_HEAP_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_HEAP_g = val;
                    }
                }
                return H5E_HEAP_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_OHDR_g;

        public static hid_t OHDR 
        {
            get
            {
                if (!H5E_OHDR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_OHDR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_OHDR_g = val;
                    }
                }
                return H5E_OHDR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_ATOM_g;

        public static hid_t ATOM 
        {
            get
            {
                if (!H5E_ATOM_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_ATOM_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_ATOM_g = val;
                    }
                }
                return H5E_ATOM_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_ATTR_g;

        public static hid_t ATTR 
        {
            get
            {
                if (!H5E_ATTR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_ATTR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_ATTR_g = val;
                    }
                }
                return H5E_ATTR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NONE_MAJOR_g;

        public static hid_t NONE_MAJOR 
        {
            get
            {
                if (!H5E_NONE_MAJOR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NONE_MAJOR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NONE_MAJOR_g = val;
                    }
                }
                return H5E_NONE_MAJOR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_IO_g;

        public static hid_t IO 
        {
            get
            {
                if (!H5E_IO_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_IO_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_IO_g = val;
                    }
                }
                return H5E_IO_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_SLIST_g;

        public static hid_t SLIST 
        {
            get
            {
                if (!H5E_SLIST_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_SLIST_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_SLIST_g = val;
                    }
                }
                return H5E_SLIST_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_EFL_g;

        public static hid_t EFL 
        {
            get
            {
                if (!H5E_EFL_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_EFL_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_EFL_g = val;
                    }
                }
                return H5E_EFL_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_TST_g;

        public static hid_t TST 
        {
            get
            {
                if (!H5E_TST_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_TST_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_TST_g = val;
                    }
                }
                return H5E_TST_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_ARGS_g;

        public static hid_t ARGS 
        {
            get
            {
                if (!H5E_ARGS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_ARGS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_ARGS_g = val;
                    }
                }
                return H5E_ARGS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_ERROR_g;

        public static hid_t ERROR 
        {
            get
            {
                if (!H5E_ERROR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_ERROR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_ERROR_g = val;
                    }
                }
                return H5E_ERROR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_PLINE_g;

        public static hid_t PLINE 
        {
            get
            {
                if (!H5E_PLINE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_PLINE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_PLINE_g = val;
                    }
                }
                return H5E_PLINE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_FSPACE_g;

        public static hid_t FSPACE 
        {
            get
            {
                if (!H5E_FSPACE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_FSPACE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_FSPACE_g = val;
                    }
                }
                return H5E_FSPACE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CACHE_g;

        public static hid_t CACHE 
        {
            get
            {
                if (!H5E_CACHE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CACHE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CACHE_g = val;
                    }
                }
                return H5E_CACHE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_EARRAY_g;

        public static hid_t EARRAY 
        {
            get
            {
                if (!H5E_EARRAY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_EARRAY_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_EARRAY_g = val;
                    }
                }
                return H5E_EARRAY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_FARRAY_g;

        public static hid_t FARRAY 
        {
            get
            {
                if (!H5E_FARRAY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_FARRAY_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_FARRAY_g = val;
                    }
                }
                return H5E_FARRAY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_SEEKERROR_g;

        public static hid_t SEEKERROR 
        {
            get
            {
                if (!H5E_SEEKERROR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_SEEKERROR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_SEEKERROR_g = val;
                    }
                }
                return H5E_SEEKERROR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_READERROR_g;

        public static hid_t READERROR 
        {
            get
            {
                if (!H5E_READERROR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_READERROR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_READERROR_g = val;
                    }
                }
                return H5E_READERROR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_WRITEERROR_g;

        public static hid_t WRITEERROR 
        {
            get
            {
                if (!H5E_WRITEERROR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_WRITEERROR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_WRITEERROR_g = val;
                    }
                }
                return H5E_WRITEERROR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CLOSEERROR_g;

        public static hid_t CLOSEERROR 
        {
            get
            {
                if (!H5E_CLOSEERROR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CLOSEERROR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CLOSEERROR_g = val;
                    }
                }
                return H5E_CLOSEERROR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_OVERFLOW_g;

        public static hid_t OVERFLOW 
        {
            get
            {
                if (!H5E_OVERFLOW_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_OVERFLOW_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_OVERFLOW_g = val;
                    }
                }
                return H5E_OVERFLOW_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_FCNTL_g;

        public static hid_t FCNTL 
        {
            get
            {
                if (!H5E_FCNTL_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_FCNTL_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_FCNTL_g = val;
                    }
                }
                return H5E_FCNTL_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NOSPACE_g;

        public static hid_t NOSPACE 
        {
            get
            {
                if (!H5E_NOSPACE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NOSPACE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NOSPACE_g = val;
                    }
                }
                return H5E_NOSPACE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTALLOC_g;

        public static hid_t CANTALLOC 
        {
            get
            {
                if (!H5E_CANTALLOC_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTALLOC_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTALLOC_g = val;
                    }
                }
                return H5E_CANTALLOC_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCOPY_g;

        public static hid_t CANTCOPY 
        {
            get
            {
                if (!H5E_CANTCOPY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCOPY_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCOPY_g = val;
                    }
                }
                return H5E_CANTCOPY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTFREE_g;

        public static hid_t CANTFREE 
        {
            get
            {
                if (!H5E_CANTFREE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTFREE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTFREE_g = val;
                    }
                }
                return H5E_CANTFREE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_ALREADYEXISTS_g;

        public static hid_t ALREADYEXISTS 
        {
            get
            {
                if (!H5E_ALREADYEXISTS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_ALREADYEXISTS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_ALREADYEXISTS_g = val;
                    }
                }
                return H5E_ALREADYEXISTS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTLOCK_g;

        public static hid_t CANTLOCK 
        {
            get
            {
                if (!H5E_CANTLOCK_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTLOCK_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTLOCK_g = val;
                    }
                }
                return H5E_CANTLOCK_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTUNLOCK_g;

        public static hid_t CANTUNLOCK 
        {
            get
            {
                if (!H5E_CANTUNLOCK_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTUNLOCK_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTUNLOCK_g = val;
                    }
                }
                return H5E_CANTUNLOCK_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTGC_g;

        public static hid_t CANTGC 
        {
            get
            {
                if (!H5E_CANTGC_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTGC_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTGC_g = val;
                    }
                }
                return H5E_CANTGC_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTGETSIZE_g;

        public static hid_t CANTGETSIZE 
        {
            get
            {
                if (!H5E_CANTGETSIZE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTGETSIZE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTGETSIZE_g = val;
                    }
                }
                return H5E_CANTGETSIZE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_OBJOPEN_g;

        public static hid_t OBJOPEN 
        {
            get
            {
                if (!H5E_OBJOPEN_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_OBJOPEN_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_OBJOPEN_g = val;
                    }
                }
                return H5E_OBJOPEN_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTRESTORE_g;

        public static hid_t CANTRESTORE 
        {
            get
            {
                if (!H5E_CANTRESTORE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTRESTORE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTRESTORE_g = val;
                    }
                }
                return H5E_CANTRESTORE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCOMPUTE_g;

        public static hid_t CANTCOMPUTE 
        {
            get
            {
                if (!H5E_CANTCOMPUTE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCOMPUTE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCOMPUTE_g = val;
                    }
                }
                return H5E_CANTCOMPUTE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTEXTEND_g;

        public static hid_t CANTEXTEND 
        {
            get
            {
                if (!H5E_CANTEXTEND_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTEXTEND_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTEXTEND_g = val;
                    }
                }
                return H5E_CANTEXTEND_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTATTACH_g;

        public static hid_t CANTATTACH 
        {
            get
            {
                if (!H5E_CANTATTACH_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTATTACH_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTATTACH_g = val;
                    }
                }
                return H5E_CANTATTACH_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTUPDATE_g;

        public static hid_t CANTUPDATE 
        {
            get
            {
                if (!H5E_CANTUPDATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTUPDATE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTUPDATE_g = val;
                    }
                }
                return H5E_CANTUPDATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTOPERATE_g;

        public static hid_t CANTOPERATE 
        {
            get
            {
                if (!H5E_CANTOPERATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTOPERATE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTOPERATE_g = val;
                    }
                }
                return H5E_CANTOPERATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTINIT_g;

        public static hid_t CANTINIT 
        {
            get
            {
                if (!H5E_CANTINIT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTINIT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTINIT_g = val;
                    }
                }
                return H5E_CANTINIT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_ALREADYINIT_g;

        public static hid_t ALREADYINIT 
        {
            get
            {
                if (!H5E_ALREADYINIT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_ALREADYINIT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_ALREADYINIT_g = val;
                    }
                }
                return H5E_ALREADYINIT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTRELEASE_g;

        public static hid_t CANTRELEASE 
        {
            get
            {
                if (!H5E_CANTRELEASE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTRELEASE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTRELEASE_g = val;
                    }
                }
                return H5E_CANTRELEASE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTGET_g;

        public static hid_t CANTGET 
        {
            get
            {
                if (!H5E_CANTGET_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTGET_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTGET_g = val;
                    }
                }
                return H5E_CANTGET_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTSET_g;

        public static hid_t CANTSET 
        {
            get
            {
                if (!H5E_CANTSET_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTSET_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTSET_g = val;
                    }
                }
                return H5E_CANTSET_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_DUPCLASS_g;

        public static hid_t DUPCLASS 
        {
            get
            {
                if (!H5E_DUPCLASS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_DUPCLASS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_DUPCLASS_g = val;
                    }
                }
                return H5E_DUPCLASS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_SETDISALLOWED_g;

        public static hid_t SETDISALLOWED 
        {
            get
            {
                if (!H5E_SETDISALLOWED_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_SETDISALLOWED_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_SETDISALLOWED_g = val;
                    }
                }
                return H5E_SETDISALLOWED_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTMERGE_g;

        public static hid_t CANTMERGE 
        {
            get
            {
                if (!H5E_CANTMERGE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTMERGE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTMERGE_g = val;
                    }
                }
                return H5E_CANTMERGE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTREVIVE_g;

        public static hid_t CANTREVIVE 
        {
            get
            {
                if (!H5E_CANTREVIVE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTREVIVE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTREVIVE_g = val;
                    }
                }
                return H5E_CANTREVIVE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTSHRINK_g;

        public static hid_t CANTSHRINK 
        {
            get
            {
                if (!H5E_CANTSHRINK_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTSHRINK_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTSHRINK_g = val;
                    }
                }
                return H5E_CANTSHRINK_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_LINKCOUNT_g;

        public static hid_t LINKCOUNT 
        {
            get
            {
                if (!H5E_LINKCOUNT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_LINKCOUNT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_LINKCOUNT_g = val;
                    }
                }
                return H5E_LINKCOUNT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_VERSION_g;

        public static hid_t VERSION 
        {
            get
            {
                if (!H5E_VERSION_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_VERSION_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_VERSION_g = val;
                    }
                }
                return H5E_VERSION_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_ALIGNMENT_g;

        public static hid_t ALIGNMENT 
        {
            get
            {
                if (!H5E_ALIGNMENT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_ALIGNMENT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_ALIGNMENT_g = val;
                    }
                }
                return H5E_ALIGNMENT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADMESG_g;

        public static hid_t BADMESG 
        {
            get
            {
                if (!H5E_BADMESG_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADMESG_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADMESG_g = val;
                    }
                }
                return H5E_BADMESG_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTDELETE_g;

        public static hid_t CANTDELETE 
        {
            get
            {
                if (!H5E_CANTDELETE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTDELETE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTDELETE_g = val;
                    }
                }
                return H5E_CANTDELETE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADITER_g;

        public static hid_t BADITER 
        {
            get
            {
                if (!H5E_BADITER_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADITER_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADITER_g = val;
                    }
                }
                return H5E_BADITER_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTPACK_g;

        public static hid_t CANTPACK 
        {
            get
            {
                if (!H5E_CANTPACK_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTPACK_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTPACK_g = val;
                    }
                }
                return H5E_CANTPACK_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTRESET_g;

        public static hid_t CANTRESET 
        {
            get
            {
                if (!H5E_CANTRESET_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTRESET_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTRESET_g = val;
                    }
                }
                return H5E_CANTRESET_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTRENAME_g;

        public static hid_t CANTRENAME 
        {
            get
            {
                if (!H5E_CANTRENAME_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTRENAME_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTRENAME_g = val;
                    }
                }
                return H5E_CANTRENAME_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_SYSERRSTR_g;

        public static hid_t SYSERRSTR 
        {
            get
            {
                if (!H5E_SYSERRSTR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_SYSERRSTR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_SYSERRSTR_g = val;
                    }
                }
                return H5E_SYSERRSTR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NOFILTER_g;

        public static hid_t NOFILTER 
        {
            get
            {
                if (!H5E_NOFILTER_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NOFILTER_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NOFILTER_g = val;
                    }
                }
                return H5E_NOFILTER_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CALLBACK_g;

        public static hid_t CALLBACK 
        {
            get
            {
                if (!H5E_CALLBACK_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CALLBACK_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CALLBACK_g = val;
                    }
                }
                return H5E_CALLBACK_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANAPPLY_g;

        public static hid_t CANAPPLY 
        {
            get
            {
                if (!H5E_CANAPPLY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANAPPLY_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANAPPLY_g = val;
                    }
                }
                return H5E_CANAPPLY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_SETLOCAL_g;

        public static hid_t SETLOCAL 
        {
            get
            {
                if (!H5E_SETLOCAL_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_SETLOCAL_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_SETLOCAL_g = val;
                    }
                }
                return H5E_SETLOCAL_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NOENCODER_g;

        public static hid_t NOENCODER 
        {
            get
            {
                if (!H5E_NOENCODER_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NOENCODER_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NOENCODER_g = val;
                    }
                }
                return H5E_NOENCODER_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTFILTER_g;

        public static hid_t CANTFILTER 
        {
            get
            {
                if (!H5E_CANTFILTER_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTFILTER_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTFILTER_g = val;
                    }
                }
                return H5E_CANTFILTER_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTOPENOBJ_g;

        public static hid_t CANTOPENOBJ 
        {
            get
            {
                if (!H5E_CANTOPENOBJ_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTOPENOBJ_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTOPENOBJ_g = val;
                    }
                }
                return H5E_CANTOPENOBJ_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCLOSEOBJ_g;

        public static hid_t CANTCLOSEOBJ 
        {
            get
            {
                if (!H5E_CANTCLOSEOBJ_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCLOSEOBJ_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCLOSEOBJ_g = val;
                    }
                }
                return H5E_CANTCLOSEOBJ_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_COMPLEN_g;

        public static hid_t COMPLEN 
        {
            get
            {
                if (!H5E_COMPLEN_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_COMPLEN_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_COMPLEN_g = val;
                    }
                }
                return H5E_COMPLEN_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_PATH_g;

        public static hid_t PATH 
        {
            get
            {
                if (!H5E_PATH_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_PATH_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_PATH_g = val;
                    }
                }
                return H5E_PATH_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NONE_MINOR_g;

        public static hid_t NONE_MINOR 
        {
            get
            {
                if (!H5E_NONE_MINOR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NONE_MINOR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NONE_MINOR_g = val;
                    }
                }
                return H5E_NONE_MINOR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_OPENERROR_g;

        public static hid_t OPENERROR 
        {
            get
            {
                if (!H5E_OPENERROR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_OPENERROR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_OPENERROR_g = val;
                    }
                }
                return H5E_OPENERROR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_FILEEXISTS_g;

        public static hid_t FILEEXISTS 
        {
            get
            {
                if (!H5E_FILEEXISTS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_FILEEXISTS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_FILEEXISTS_g = val;
                    }
                }
                return H5E_FILEEXISTS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_FILEOPEN_g;

        public static hid_t FILEOPEN 
        {
            get
            {
                if (!H5E_FILEOPEN_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_FILEOPEN_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_FILEOPEN_g = val;
                    }
                }
                return H5E_FILEOPEN_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCREATE_g;

        public static hid_t CANTCREATE 
        {
            get
            {
                if (!H5E_CANTCREATE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCREATE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCREATE_g = val;
                    }
                }
                return H5E_CANTCREATE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTOPENFILE_g;

        public static hid_t CANTOPENFILE 
        {
            get
            {
                if (!H5E_CANTOPENFILE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTOPENFILE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTOPENFILE_g = val;
                    }
                }
                return H5E_CANTOPENFILE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCLOSEFILE_g;

        public static hid_t CANTCLOSEFILE 
        {
            get
            {
                if (!H5E_CANTCLOSEFILE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCLOSEFILE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCLOSEFILE_g = val;
                    }
                }
                return H5E_CANTCLOSEFILE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NOTHDF5_g;

        public static hid_t NOTHDF5 
        {
            get
            {
                if (!H5E_NOTHDF5_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NOTHDF5_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NOTHDF5_g = val;
                    }
                }
                return H5E_NOTHDF5_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADFILE_g;

        public static hid_t BADFILE 
        {
            get
            {
                if (!H5E_BADFILE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADFILE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADFILE_g = val;
                    }
                }
                return H5E_BADFILE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_TRUNCATED_g;

        public static hid_t TRUNCATED 
        {
            get
            {
                if (!H5E_TRUNCATED_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_TRUNCATED_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_TRUNCATED_g = val;
                    }
                }
                return H5E_TRUNCATED_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_MOUNT_g;

        public static hid_t MOUNT 
        {
            get
            {
                if (!H5E_MOUNT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_MOUNT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_MOUNT_g = val;
                    }
                }
                return H5E_MOUNT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADATOM_g;

        public static hid_t BADATOM 
        {
            get
            {
                if (!H5E_BADATOM_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADATOM_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADATOM_g = val;
                    }
                }
                return H5E_BADATOM_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADGROUP_g;

        public static hid_t BADGROUP 
        {
            get
            {
                if (!H5E_BADGROUP_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADGROUP_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADGROUP_g = val;
                    }
                }
                return H5E_BADGROUP_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTREGISTER_g;

        public static hid_t CANTREGISTER 
        {
            get
            {
                if (!H5E_CANTREGISTER_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTREGISTER_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTREGISTER_g = val;
                    }
                }
                return H5E_CANTREGISTER_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTINC_g;

        public static hid_t CANTINC 
        {
            get
            {
                if (!H5E_CANTINC_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTINC_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTINC_g = val;
                    }
                }
                return H5E_CANTINC_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTDEC_g;

        public static hid_t CANTDEC 
        {
            get
            {
                if (!H5E_CANTDEC_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTDEC_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTDEC_g = val;
                    }
                }
                return H5E_CANTDEC_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NOIDS_g;

        public static hid_t NOIDS 
        {
            get
            {
                if (!H5E_NOIDS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NOIDS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NOIDS_g = val;
                    }
                }
                return H5E_NOIDS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTFLUSH_g;

        public static hid_t CANTFLUSH 
        {
            get
            {
                if (!H5E_CANTFLUSH_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTFLUSH_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTFLUSH_g = val;
                    }
                }
                return H5E_CANTFLUSH_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTSERIALIZE_g;

        public static hid_t CANTSERIALIZE 
        {
            get
            {
                if (!H5E_CANTSERIALIZE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTSERIALIZE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTSERIALIZE_g = val;
                    }
                }
                return H5E_CANTSERIALIZE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTLOAD_g;

        public static hid_t CANTLOAD 
        {
            get
            {
                if (!H5E_CANTLOAD_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTLOAD_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTLOAD_g = val;
                    }
                }
                return H5E_CANTLOAD_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_PROTECT_g;

        public static hid_t PROTECT 
        {
            get
            {
                if (!H5E_PROTECT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_PROTECT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_PROTECT_g = val;
                    }
                }
                return H5E_PROTECT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NOTCACHED_g;

        public static hid_t NOTCACHED 
        {
            get
            {
                if (!H5E_NOTCACHED_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NOTCACHED_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NOTCACHED_g = val;
                    }
                }
                return H5E_NOTCACHED_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_SYSTEM_g;

        public static hid_t SYSTEM 
        {
            get
            {
                if (!H5E_SYSTEM_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_SYSTEM_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_SYSTEM_g = val;
                    }
                }
                return H5E_SYSTEM_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTINS_g;

        public static hid_t CANTINS 
        {
            get
            {
                if (!H5E_CANTINS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTINS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTINS_g = val;
                    }
                }
                return H5E_CANTINS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTPROTECT_g;

        public static hid_t CANTPROTECT 
        {
            get
            {
                if (!H5E_CANTPROTECT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTPROTECT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTPROTECT_g = val;
                    }
                }
                return H5E_CANTPROTECT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTUNPROTECT_g;

        public static hid_t CANTUNPROTECT 
        {
            get
            {
                if (!H5E_CANTUNPROTECT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTUNPROTECT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTUNPROTECT_g = val;
                    }
                }
                return H5E_CANTUNPROTECT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTPIN_g;

        public static hid_t CANTPIN 
        {
            get
            {
                if (!H5E_CANTPIN_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTPIN_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTPIN_g = val;
                    }
                }
                return H5E_CANTPIN_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTUNPIN_g;

        public static hid_t CANTUNPIN 
        {
            get
            {
                if (!H5E_CANTUNPIN_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTUNPIN_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTUNPIN_g = val;
                    }
                }
                return H5E_CANTUNPIN_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTMARKDIRTY_g;

        public static hid_t CANTMARKDIRTY 
        {
            get
            {
                if (!H5E_CANTMARKDIRTY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTMARKDIRTY_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTMARKDIRTY_g = val;
                    }
                }
                return H5E_CANTMARKDIRTY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTDIRTY_g;

        public static hid_t CANTDIRTY 
        {
            get
            {
                if (!H5E_CANTDIRTY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTDIRTY_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTDIRTY_g = val;
                    }
                }
                return H5E_CANTDIRTY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTEXPUNGE_g;

        public static hid_t CANTEXPUNGE 
        {
            get
            {
                if (!H5E_CANTEXPUNGE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTEXPUNGE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTEXPUNGE_g = val;
                    }
                }
                return H5E_CANTEXPUNGE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTRESIZE_g;

        public static hid_t CANTRESIZE 
        {
            get
            {
                if (!H5E_CANTRESIZE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTRESIZE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTRESIZE_g = val;
                    }
                }
                return H5E_CANTRESIZE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTDEPEND_g;

        public static hid_t CANTDEPEND 
        {
            get
            {
                if (!H5E_CANTDEPEND_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTDEPEND_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTDEPEND_g = val;
                    }
                }
                return H5E_CANTDEPEND_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTUNDEPEND_g;

        public static hid_t CANTUNDEPEND 
        {
            get
            {
                if (!H5E_CANTUNDEPEND_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTUNDEPEND_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTUNDEPEND_g = val;
                    }
                }
                return H5E_CANTUNDEPEND_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTNOTIFY_g;

        public static hid_t CANTNOTIFY 
        {
            get
            {
                if (!H5E_CANTNOTIFY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTNOTIFY_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTNOTIFY_g = val;
                    }
                }
                return H5E_CANTNOTIFY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_LOGFAIL_g;

        public static hid_t LOGFAIL 
        {
            get
            {
                if (!H5E_LOGFAIL_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_LOGFAIL_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_LOGFAIL_g = val;
                    }
                }
                return H5E_LOGFAIL_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCORK_g;

        public static hid_t CANTCORK 
        {
            get
            {
                if (!H5E_CANTCORK_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCORK_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCORK_g = val;
                    }
                }
                return H5E_CANTCORK_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTUNCORK_g;

        public static hid_t CANTUNCORK 
        {
            get
            {
                if (!H5E_CANTUNCORK_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTUNCORK_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTUNCORK_g = val;
                    }
                }
                return H5E_CANTUNCORK_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_TRAVERSE_g;

        public static hid_t TRAVERSE 
        {
            get
            {
                if (!H5E_TRAVERSE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_TRAVERSE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_TRAVERSE_g = val;
                    }
                }
                return H5E_TRAVERSE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NLINKS_g;

        public static hid_t NLINKS 
        {
            get
            {
                if (!H5E_NLINKS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NLINKS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NLINKS_g = val;
                    }
                }
                return H5E_NLINKS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NOTREGISTERED_g;

        public static hid_t NOTREGISTERED 
        {
            get
            {
                if (!H5E_NOTREGISTERED_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NOTREGISTERED_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NOTREGISTERED_g = val;
                    }
                }
                return H5E_NOTREGISTERED_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTMOVE_g;

        public static hid_t CANTMOVE 
        {
            get
            {
                if (!H5E_CANTMOVE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTMOVE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTMOVE_g = val;
                    }
                }
                return H5E_CANTMOVE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTSORT_g;

        public static hid_t CANTSORT 
        {
            get
            {
                if (!H5E_CANTSORT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTSORT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTSORT_g = val;
                    }
                }
                return H5E_CANTSORT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_MPI_g;

        public static hid_t MPI 
        {
            get
            {
                if (!H5E_MPI_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_MPI_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_MPI_g = val;
                    }
                }
                return H5E_MPI_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_MPIERRSTR_g;

        public static hid_t MPIERRSTR 
        {
            get
            {
                if (!H5E_MPIERRSTR_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_MPIERRSTR_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_MPIERRSTR_g = val;
                    }
                }
                return H5E_MPIERRSTR_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTRECV_g;

        public static hid_t CANTRECV 
        {
            get
            {
                if (!H5E_CANTRECV_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTRECV_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTRECV_g = val;
                    }
                }
                return H5E_CANTRECV_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCLIP_g;

        public static hid_t CANTCLIP 
        {
            get
            {
                if (!H5E_CANTCLIP_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCLIP_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCLIP_g = val;
                    }
                }
                return H5E_CANTCLIP_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCOUNT_g;

        public static hid_t CANTCOUNT 
        {
            get
            {
                if (!H5E_CANTCOUNT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCOUNT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCOUNT_g = val;
                    }
                }
                return H5E_CANTCOUNT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTSELECT_g;

        public static hid_t CANTSELECT 
        {
            get
            {
                if (!H5E_CANTSELECT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTSELECT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTSELECT_g = val;
                    }
                }
                return H5E_CANTSELECT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTNEXT_g;

        public static hid_t CANTNEXT 
        {
            get
            {
                if (!H5E_CANTNEXT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTNEXT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTNEXT_g = val;
                    }
                }
                return H5E_CANTNEXT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADSELECT_g;

        public static hid_t BADSELECT 
        {
            get
            {
                if (!H5E_BADSELECT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADSELECT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADSELECT_g = val;
                    }
                }
                return H5E_BADSELECT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCOMPARE_g;

        public static hid_t CANTCOMPARE 
        {
            get
            {
                if (!H5E_CANTCOMPARE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCOMPARE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCOMPARE_g = val;
                    }
                }
                return H5E_CANTCOMPARE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTAPPEND_g;

        public static hid_t CANTAPPEND 
        {
            get
            {
                if (!H5E_CANTAPPEND_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTAPPEND_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTAPPEND_g = val;
                    }
                }
                return H5E_CANTAPPEND_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_UNINITIALIZED_g;

        public static hid_t UNINITIALIZED 
        {
            get
            {
                if (!H5E_UNINITIALIZED_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_UNINITIALIZED_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_UNINITIALIZED_g = val;
                    }
                }
                return H5E_UNINITIALIZED_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_UNSUPPORTED_g;

        public static hid_t UNSUPPORTED 
        {
            get
            {
                if (!H5E_UNSUPPORTED_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_UNSUPPORTED_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_UNSUPPORTED_g = val;
                    }
                }
                return H5E_UNSUPPORTED_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADTYPE_g;

        public static hid_t BADTYPE 
        {
            get
            {
                if (!H5E_BADTYPE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADTYPE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADTYPE_g = val;
                    }
                }
                return H5E_BADTYPE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADRANGE_g;

        public static hid_t BADRANGE 
        {
            get
            {
                if (!H5E_BADRANGE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADRANGE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADRANGE_g = val;
                    }
                }
                return H5E_BADRANGE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADVALUE_g;

        public static hid_t BADVALUE 
        {
            get
            {
                if (!H5E_BADVALUE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADVALUE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADVALUE_g = val;
                    }
                }
                return H5E_BADVALUE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_NOTFOUND_g;

        public static hid_t NOTFOUND 
        {
            get
            {
                if (!H5E_NOTFOUND_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_NOTFOUND_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_NOTFOUND_g = val;
                    }
                }
                return H5E_NOTFOUND_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_EXISTS_g;

        public static hid_t EXISTS 
        {
            get
            {
                if (!H5E_EXISTS_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_EXISTS_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_EXISTS_g = val;
                    }
                }
                return H5E_EXISTS_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTENCODE_g;

        public static hid_t CANTENCODE 
        {
            get
            {
                if (!H5E_CANTENCODE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTENCODE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTENCODE_g = val;
                    }
                }
                return H5E_CANTENCODE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTDECODE_g;

        public static hid_t CANTDECODE 
        {
            get
            {
                if (!H5E_CANTDECODE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTDECODE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTDECODE_g = val;
                    }
                }
                return H5E_CANTDECODE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTSPLIT_g;

        public static hid_t CANTSPLIT 
        {
            get
            {
                if (!H5E_CANTSPLIT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTSPLIT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTSPLIT_g = val;
                    }
                }
                return H5E_CANTSPLIT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTREDISTRIBUTE_g;

        public static hid_t CANTREDISTRIBUTE 
        {
            get
            {
                if (!H5E_CANTREDISTRIBUTE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTREDISTRIBUTE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTREDISTRIBUTE_g = val;
                    }
                }
                return H5E_CANTREDISTRIBUTE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTSWAP_g;

        public static hid_t CANTSWAP 
        {
            get
            {
                if (!H5E_CANTSWAP_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTSWAP_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTSWAP_g = val;
                    }
                }
                return H5E_CANTSWAP_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTINSERT_g;

        public static hid_t CANTINSERT 
        {
            get
            {
                if (!H5E_CANTINSERT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTINSERT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTINSERT_g = val;
                    }
                }
                return H5E_CANTINSERT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTLIST_g;

        public static hid_t CANTLIST 
        {
            get
            {
                if (!H5E_CANTLIST_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTLIST_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTLIST_g = val;
                    }
                }
                return H5E_CANTLIST_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTMODIFY_g;

        public static hid_t CANTMODIFY 
        {
            get
            {
                if (!H5E_CANTMODIFY_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTMODIFY_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTMODIFY_g = val;
                    }
                }
                return H5E_CANTMODIFY_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTREMOVE_g;

        public static hid_t CANTREMOVE 
        {
            get
            {
                if (!H5E_CANTREMOVE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTREMOVE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTREMOVE_g = val;
                    }
                }
                return H5E_CANTREMOVE_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_CANTCONVERT_g;

        public static hid_t CANTCONVERT 
        {
            get
            {
                if (!H5E_CANTCONVERT_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_CANTCONVERT_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_CANTCONVERT_g = val;
                    }
                }
                return H5E_CANTCONVERT_g.GetValueOrDefault();
            }
        }

        static hid_t? H5E_BADSIZE_g;

        public static hid_t BADSIZE 
        {
            get
            {
                if (!H5E_BADSIZE_g.HasValue)
                {
                    hid_t val = -1;
                    if (m_importer.GetValue<hid_t>(Constants.DLLFileName,
                        "H5E_BADSIZE_g", ref val,
#if HDF5_VER1_10
                        Marshal.ReadInt64
#else
                        Marshal.ReadInt32
#endif
                        ))
                    {
                        H5E_BADSIZE_g = val;
                    }
                }
                return H5E_BADSIZE_g.GetValueOrDefault();
            }
        }
    }
}
