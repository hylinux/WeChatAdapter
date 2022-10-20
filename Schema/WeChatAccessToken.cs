// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Bot.Builder;
using System;

namespace WeChatAdapter.Schema;

public class WeChatAccessToken : IStoreItem
{
    public WeChatAccessToken()
    {
        ExpireTime = DateTimeOffset.MinValue;
    }

    public string? AppId { get; set; }

    public string? Token { get; set; }

    public string? Secret { get; set; }

    public DateTimeOffset ExpireTime { get; set; }

    public string? ETag { get; set; }
}
