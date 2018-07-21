using Microsoft.AspNetCore.Mvc.ModelBinding;
using Dummy3D.Models.Response;
using System.Collections;
using System.Collections.Generic;
namespace Dummy3D.Models.Response {
    public class Error {
        public Response.Status Status { set; get;} 
        public object Errors { set; get;} 
    }
}
