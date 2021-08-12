using System;


namespace HospitalSystem.Common
{
    public class ResponseModel
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public ResponseCode Code { get; set; } = ResponseCode.Success;
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public TimeSpan Timestamp { get; set; } = (DateTime.Now - new DateTime(1970, 1, 1, 8, 0, 0));
        /// <summary>
        /// 响应信息
        /// </summary>
        public string Message { get; set; }

        public ResponseModel(){ }

        public ResponseModel(ResponseCode code)
        {
            this.Code = code;
        }
        public ResponseModel(ResponseCode code, string msg)
        {
            this.Code = code;
            this.Message = msg;
        }
        public ResponseModel(ResponseCode code, string msg, object data)
        {
            this.Code = code;
            this.Message = msg;
            this.Data = data;
        }
        /// <summary>
        ///成功
        /// </summary>
        /// <returns></returns>
        public static ResponseModel Success()
        {
            return new ResponseModel();
        }
        public static ResponseModel Error(ResponseCode code = ResponseCode.Error, string msg = "Error")
        {
            return new ResponseModel(code, msg);
        }
    }
    public enum ResponseCode
    {
        Success = 200,
        Error = 400,
        InternalError = 500,
        Warn = 201,
    }
}
