namespace Feng.WebCommon.Enums;

public enum ResultCode {
    /// <summary>
    /// 未知错误
    /// </summary>
    Unknown = -1,

    /// <summary>
    /// 未登录
    /// </summary>
    NoLogin = 100,
    
    /// <summary>
    /// 操作成功
    /// </summary>
    Success = 200,

    /// <summary>
    /// 无操作权限
    /// </summary>
    Forbidden = 500,

    /// <summary>
    /// 提交的数据无法处理
    /// </summary>
    DataError = 501,

    /// <summary>
    /// 请求的资源不存在
    /// </summary>
    NotFound = 502,

    /// <summary>
    /// 操作发生错误
    /// </summary>
    Error = 503
}