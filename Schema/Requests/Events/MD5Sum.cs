// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Xml.Serialization;

namespace WeChatAdapter.Schema.Requests.Events;

public class MD5Sum
{
    [XmlElement(ElementName = "PicMd5Sum")]
    public string? PicMD5Sum { get; set; }
}
