using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionGrayOnlineModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionGrayOnlineModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序灰度策略值，支持p10，p30，p50，其中p10代表10%的用户，p30代表30%的用户，p50代表50%的用户
        /// </summary>
        [JsonProperty("gray_strategy")]
        public string GrayStrategy { get; set; }
    }
}
