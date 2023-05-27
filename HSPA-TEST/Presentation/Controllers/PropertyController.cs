using HSPA_TEST.BLL.DTOs;
using HSPA_TEST.DAL.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSPA_TEST.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly DataContext dbContext; //This line declares a private field named dbContext of type DataContext.It is used to access the data in the database.
        public PropertyController(DataContext dbContext) //This is the constructor for the CityController class.
                                                         //It takes a parameter of type DataContext and assigns it to the dbContext field.
                                                         //This is known as dependency injection, where the DataContext is provided to the controller when it is created.

        {
            this.dbContext = dbContext;
        }

        //property/list/1
        [HttpGet]
        [Route("{list/sellRent}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPropertyList(int sellRent)
        {
            var properties = await uow.PropertyRepository.GetPropertiesAsync(sellRent);
            var propertyListDTO = mapper.Map<IEnumerable<PropertyListDto>>(properties);
            return Ok(propertyListDTO);
        }

    }
}
