// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Xml.Serialization;

namespace WeChatAdapter.Schema.Requests.Events;

[XmlRoot("xml")]
public class CameraEvent : RequestEventWithEventKey
{
    public override string EventType => EventTypes.Camera;

    [XmlElement(ElementName = "SendPicsInfo")]
    public SendPicsInfo? SendPicsInfo { get; set; }
}
