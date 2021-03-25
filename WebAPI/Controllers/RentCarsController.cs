using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentCarsController : ControllerBase
    {
        IRentCarService _rentCarService;

        public RentCarsController(IRentCarService rentCarService)
        {
            _rentCarService = rentCarService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentCarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getrentcardetails")]
        public IActionResult GetCarsRentalDetail()
        {
            var result = _rentCarService.GetCarsRentalDetail();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _rentCarService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CarRental carRental)
        {
            var result = _rentCarService.Add(carRental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CarRental carRental)
        {
            var result = _rentCarService.Update(carRental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarRental carRental)
        {
            var result = _rentCarService.Delete(carRental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


    }
}
