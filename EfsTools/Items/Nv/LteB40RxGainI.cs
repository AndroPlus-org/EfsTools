using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6652)]
    [Attributes(9)]
    public sealed class LteB40RxGain
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}