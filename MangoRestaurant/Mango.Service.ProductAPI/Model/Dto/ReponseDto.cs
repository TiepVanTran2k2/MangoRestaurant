using System.Collections.Generic;

namespace Mango.Service.ProductAPI.Model.Dto
{
    public class ReponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<string> ErrorMessage { get; set; }
    }
}
