using System;
using Newtonsoft.Json;
using GraphEosStreamer.Other;
using GraphEosStreamer.SHiP.EosTypes;

namespace GraphEosStreamer.SHiP
{
    [Serializable()]
    public class TransactionHeader
    {
        // abi-field-name: expiration ,abi-field-type: time_point_sec
        [SortOrder(1)]
        [JsonProperty("expiration")]
        public uint Expiration;

        // abi-field-name: ref_block_num ,abi-field-type: uint16
        [SortOrder(2)]
        [JsonProperty("ref_block_num")]
        public ushort RefBlockNum;

        // abi-field-name: ref_block_prefix ,abi-field-type: uint32
        [SortOrder(3)]
        [JsonProperty("ref_block_prefix")]
        public uint RefBlockPrefix;

        // abi-field-name: max_net_usage_words ,abi-field-type: varuint32
        [SortOrder(4)]
        [JsonProperty("max_net_usage_words")]
        public VarUint32 MaxNetUsageWords;

        // abi-field-name: max_cpu_usage_ms ,abi-field-type: uint8
        [SortOrder(5)]
        [JsonProperty("max_cpu_usage_ms")]
        public byte MaxCpuUsageMs;

        // abi-field-name: delay_sec ,abi-field-type: varuint32
        [SortOrder(6)]
        [JsonProperty("delay_sec")]
        public VarUint32 DelaySec;

        public TransactionHeader(uint expiration, ushort refBlockNum, uint refBlockPrefix, VarUint32 maxNetUsageWords, byte maxCpuUsageMs, VarUint32 delaySec)
        {
            this.Expiration = expiration;
            this.RefBlockNum = refBlockNum;
            this.RefBlockPrefix = refBlockPrefix;
            this.MaxNetUsageWords = maxNetUsageWords;
            this.MaxCpuUsageMs = maxCpuUsageMs;
            this.DelaySec = delaySec;
        }

        public TransactionHeader()
        {
        }
    }
}