using Microsoft.Bot.Builder;
using Newtonsoft.Json;

namespace WeChatAdapter.Schema.JsonResults;

public class UploadMediaResult : WeChatJsonResult, IStoreItem
{
    [JsonProperty("media_id")]
    public string? MediaId { get; set; }

    public string? ETag { get; set; }

    public virtual bool Expired() => false;
}
