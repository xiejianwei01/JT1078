﻿using JT809.Protocol.Attributes;
using JT809.Protocol.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT809.Protocol.Extensions.JT1078.MessageBody
{
    /// <summary>
    /// 从链路远程录像回放交互消息
    /// </summary>
    [JT809Formatter(typeof(JT809BodiesFormatter<JT809_JT1078_0x9A00>))]
    public class JT809_JT1078_0x9A00 : JT809ExchangeMessageBodies
    {

    }
}
