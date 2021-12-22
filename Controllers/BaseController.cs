using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registration.Entities;

namespace Registration.Controllers
{
    [Controller]
    public abstract class BaseController : ControllerBase
    {
        // возвращает текущую аутентифицированную учетную запись (нулевая, если не выполнен вход в систему)
        public Account Account => (Account)HttpContext.Items["Account"];
    }
}
