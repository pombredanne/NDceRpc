﻿using System;
using System.Runtime.InteropServices;

namespace NAlpc
{
    ///<summary>Define header for Port Message</summary>
    public struct PORT_MESSAGE
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct s1_struct
        {
            /// <summary>
            /// Length of data following the header (bytes)
            /// </summary>
            public ushort DataLength;
            /// <summary>
            ///  Length of data + sizeof(PORT_MESSAGE)
            /// </summary>
            public ushort TotalLength;         
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct u1_union
        {
            [FieldOffset(0)]
            public s1_struct s1;

            [FieldOffset(0)]
            public ulong Length;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct u2_union
        {
            [FieldOffset(0)]
            public s2_struct s2;

            [FieldOffset(0)]
            public ulong ZeroInit;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct s2_struct
        {
            public ushort Type;
            public ushort DataInfoOffset;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct u3_union
        {
            [FieldOffset(0)]
            public CLIENT_ID ClientId;

            [FieldOffset(0)]
            public double DoNotUseThisField;// Force quadword alignment
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct u4_union
        {
            [FieldOffset(0)]
            public IntPtr ClientViewSize;// Size of section created by the sender (in bytes)

            [FieldOffset(0)]
            public ulong CallbackId;
        }

      

        /// <summary>
        /// Macro for initializing the message header
        /// </summary>
        /// <param name="ph"></param>
        /// <param name="l"></param>
        /// <param name="t"></param>
        public static void InitializeMessageHeader(PORT_MESSAGE ph, ushort l, ushort t)
        {
            (ph).u1.s1.TotalLength = (ushort)(l);
            unsafe
            {
                (ph).u1.s1.DataLength = (ushort)(l - sizeof(PORT_MESSAGE));
            }
            (ph).u2.s2.Type = (ushort)(t);
            (ph).u2.s2.DataInfoOffset = 0;


        }


        public u1_union u1;

        public u2_union u2;

        public u3_union u3;

        public ulong MessageId;                   // Identifier of the particular message instance

        public u4_union u4;

    }
}