using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace book.Interface
{
    public class ICustomRespone<T> : IActionResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
