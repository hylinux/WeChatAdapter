// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Xml.Serialization;

namespace WeChatAdapter.Schema.Requests.Events;

[XmlRoot("xml")]
public class WaitScanPushEvent : RequestEventWithEventKey
{
    public override string EventType => EventTypes.WaitScanPush;

    [XmlElement(ElementName = "ScanCodeInfo")]
    public ScanCodeInfo? ScanCodeInfo { get; set; }
}
