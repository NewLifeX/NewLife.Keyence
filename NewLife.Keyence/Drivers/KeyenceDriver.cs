using System.ComponentModel;
using NewLife.IoT.Drivers;

namespace NewLife.Fuji.Drivers;

/// <summary>
/// 基恩士PLC协议封装
/// </summary>
[Driver("KeyencePLC")]
[DisplayName("基恩士PLC")]
public class KeyenceDriver : DriverBase<KeyenceNode, KeyenceParameter>
{
}