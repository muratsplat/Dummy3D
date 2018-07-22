using Microsoft.AspNetCore.Mvc.ModelBinding;
using App.Models.Response;
using System.Collections;
using System.Collections.Generic;
namespace App.Models.Response {
    public class Error {
        public Response.Status Status { set; get;} 
        public object Errors { set; get;} 
    }
}
