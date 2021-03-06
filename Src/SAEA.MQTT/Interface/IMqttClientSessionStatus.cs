﻿/****************************************************************************
*项目名称：SAEA.MQTT.Interface
*CLR 版本：4.0.30319.42000
*机器名称：WENLI-PC
*命名空间：SAEA.MQTT.Interface
*类 名 称：IMqttClientSessionStatus
*版 本 号： v4.1.2.5
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2019/1/15 10:28:14
*描述：
*=====================================================================
*修改时间：2019/1/15 10:28:14
*修 改 人： yswenli
*版 本 号： v4.1.2.5
*描    述：
*****************************************************************************/
using SAEA.MQTT.Core.Protocol;
using System;
using System.Threading.Tasks;

namespace SAEA.MQTT.Interface
{
    public interface IMqttClientSessionStatus
    {
        string ClientId { get; }

        string Endpoint { get; }

        bool IsConnected { get; }

        MqttProtocolVersion? ProtocolVersion { get; }

        TimeSpan LastPacketReceived { get; }

        TimeSpan LastNonKeepAlivePacketReceived { get; }

        int PendingApplicationMessagesCount { get; }

        Task DisconnectAsync();

        Task DeleteSessionAsync();

        Task ClearPendingApplicationMessagesAsync();
    }
}
