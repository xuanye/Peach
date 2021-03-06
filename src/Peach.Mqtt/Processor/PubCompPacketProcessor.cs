// Copyright (c) Xuanye. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Peach.Mqtt.Processor
{
    using System.Threading.Tasks;
    using DotNetty.Codecs.Mqtt.Packets;

    public class PubCompPacketProcessor:IPacketProcessor
    {
        public PacketType PacketType => PacketType.PUBCOMP;

        public Task<MqttMessage> ProcessAsync(MqttClientSession clientSession,Packet packet)
        {
            throw new System.NotImplementedException();
        }
    }
}