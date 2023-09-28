using BackendApp.Data;
using BackendApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace BackendApp.Controllers
{
    [Route("api/order")]
    public class OrderController: ControllerBase
    {
        private readonly IOrderRepo _orderRepo;

        public OrderController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        [HttpGet]
        public ActionResult<Order> GetOrderByUserId(int id)
        {
            return Ok(id);
        }
    }
}
