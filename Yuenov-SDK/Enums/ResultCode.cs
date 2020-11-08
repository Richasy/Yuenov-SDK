namespace Yuenov.SDK.Enums
{
    public enum ResultCode
    {
        /// <summary>
        /// 返回数据正确
        /// </summary>
        Success = 0,
        /// <summary>
        /// 新用户创建成功
        /// </summary>
        NewUserCreateSuccess = 101,
        /// <summary>
        /// 未查询到数据
        /// </summary>
        NotFound = 102,
        /// <summary>
        /// 参数校验出错
        /// </summary>
        InvalidArgument = 1001,
        /// <summary>
        /// 返回值异常
        /// </summary>
        InvalidReturnValue = 1002,
        /// <summary>
        /// 非法请求
        /// </summary>
        InvalidRequest = 1003,
        /// <summary>
        /// 权限验证异常
        /// </summary>
        InvalidPermission = 1005,
        /// <summary>
        /// 远程调用服务超时
        /// </summary>
        Timeout = 1007,
        /// <summary>
        /// 系统出错
        /// </summary>
        SystemError = 9999
    }
}
