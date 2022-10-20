// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Xml.Serialization;

namespace WeChatAdapter.Schema.Requests.Events;

[XmlRoot("xml")]
public class SelectLocationEvent : RequestEventWithEventKey
{
    public override string EventType => EventTypes.SelectLocation;

    [XmlElement(ElementName = "SendLocationInfo")]
    public SendLocationInfo? SendLocationInfo { get; set; }
}
