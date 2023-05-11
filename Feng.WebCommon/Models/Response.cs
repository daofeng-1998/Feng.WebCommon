using Feng.WebCommon.Enums;

namespace Feng.WebCommon.Models; 

public class Response {
    public ResponseCode Code { get; set; }

    public string? Message { get; set; }

    public object? Data { get; set; }

    public static Response Unknown(
        string? msg = "未知错误",
        object? data = null
    ) {
        return new Response {
            Code = ResponseCode.Unknown,
            Message = msg,
            Data = data,
        };
    }

    public static Response NoLogin(string message = "登录已过期") {
        return new Response {
            Code = ResponseCode.NoLogin,
            Message = message
        };
    }

    public static Response Success(
        string? msg = "成功",
        object? data = null
    ) {
        return new Response {
            Code = ResponseCode.Success,
            Message = msg,
            Data = data,
        };
    }

    public static Response Forbidden(
        string? msg = "无操作权限",
        object? data = null
    ) {
        return new Response {
            Code = ResponseCode.Forbidden,
            Message = msg,
            Data = data,
        };
    }

    public static Response DataError(
        string? msg = "提交的数据无法处理",
        object? data = null
    ) {
        return new Response {
            Code = ResponseCode.DataError,
            Message = msg,
            Data = data,
        };
    }

    public static Response NotFound(
        string? msg = "请求的资源不存在",
        object? data = null
    ) {
        return new Response {
            Code = ResponseCode.NotFound,
            Message = msg,
            Data = data,
        };
    }

    public static Response Error(
        string? msg = "操作失败",
        object? data = null
    ) {
        return new Response {
            Code = ResponseCode.Error,
            Message = msg,
            Data = data
        };
    }
}