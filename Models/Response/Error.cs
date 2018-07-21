using Microsoft.AspNetCore.Mvc.ModelBinding;
using Dummy3D.Models.Response;
namespace Dummy3D.Models.Response {
    public class Error {
        public Response.Status Status { set; get;} 
        public ModelStateDictionary Errors { set; get;} 
    }
}
