// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace WeChatAdapter.Schema.Responses;

public interface IResponseMessageBase
{
    string MsgType { get; set; }
}
