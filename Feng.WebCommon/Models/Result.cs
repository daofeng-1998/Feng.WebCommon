using Feng.WebCommon.Enums;

namespace Feng.WebCommon.Models; 

public class Result {
    public ResultCode Code { get; set; }

    public string? Message { get; set; }

    public object? Data { get; set; }

    public static Result Unknown(
        string? msg = "未知错误",
        object? data = null
    ) {
        return new Result {
            Code = ResultCode.Unknown,
            Message = msg,
            Data = data,
        };
    }

    public static Result NoLogin(string message = "登录已过期") {
        return new Result {
            Code = ResultCode.NoLogin,
            Message = message
        };
    }

    public static Result Success(
        string? msg = "成功",
        object? data = null
    ) {
        return new Result {
            Code = ResultCode.Success,
            Message = msg,
            Data = data,
        };
    }

    public static Result Forbidden(
        string? msg = "无操作权限",
        object? data = null
    ) {
        return new Result {
            Code = ResultCode.Forbidden,
            Message = msg,
            Data = data,
        };
    }

    public static Result DataError(
        string? msg = "提交的数据无法处理",
        object? data = null
    ) {
        return new Result {
            Code = ResultCode.DataError,
            Message = msg,
            Data = data,
        };
    }

    public static Result NotFound(
        string? msg = "请求的资源不存在",
        object? data = null
    ) {
        return new Result {
            Code = ResultCode.NotFound,
            Message = msg,
            Data = data,
        };
    }

    public static Result Error(
        string? msg = "操作失败",
        object? data = null
    ) {
        return new Result {
            Code = ResultCode.Error,
            Message = msg,
            Data = data
        };
    }
}