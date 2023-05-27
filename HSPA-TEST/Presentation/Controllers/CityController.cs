using HSPA_TEST.BLL.DTOs;
using HSPA_TEST.DAL;
using HSPA_TEST.DAL.Models;
using HSPA_TEST.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HSPA_TEST.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {

        private readonly DataContext dbContext; //This line declares a private field named dbContext of type DataContext.It is used to access the data in the database.
        private readonly ICityRepository cityRepository;

        public CityController(DataContext dbContext, ICityRepository cityRepository) //This is the constructor for the CityController class.
                                                                                     //It takes a parameter of type DataContext and assigns it to the dbContext field.
                                                                                     //This is known as dependency injection, where the DataContext is provided to the controller when it is created.

        {
            this.dbContext = dbContext;
            this.cityRepository = cityRepository;
        }

        //GET ALL Cities
        //https://localhost:portno/api/City
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //Get Data from Database - Domain Model file
            //var citiesDomain = await dbContext.Cities.ToListAsync();  // No need of this already called in Repository pttern
            var citiesDomain = await cityRepository.GetAllAsync();

            //Map Domain Models to Dtos
            var citiesDtos = new List<CityDto>();  //comes from DTO folder
            foreach (var cityDomain in citiesDomain)
            {
                citiesDtos.Add(new CityDto()
                {
                    Id = cityDomain.Id,
                    Name = cityDomain.Name,
                    Country = cityDomain.Country,
                });

            }
            //Return Dtos
            return Ok(citiesDtos); //citiesDomain
        }


        //GET Single CITY (by ID)
        //https://localhost:port/api/City/id
        [HttpGet]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id)
        {
            //Get city domain moel from DB
            //var city = dbContext.Cities.Find(Id);
            //M-2 : 
            //var cityDomain = await dbContext.Cities.FirstOrDefaultAsync(x => x.Id == Id);
            var cityDomain = await cityRepository.GetByIdAsync(Id);
            if (cityDomain == null)
            {
                return NotFound();
            }

            //Mapping/Convert City Domain Model to City DTOs
            var cityDto = new CityDto
            {
                Id = cityDomain.Id,
                Name = cityDomain.Name,
                Country = cityDomain.Country,
            };

            //Return Dtos
            return Ok(cityDto);
        }


        //Post to create new City
        //https://localhost:port/api/City/
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CityChangesRequestDto addCityRequestDto)
        {
            // Reverse >> Map DTO to domain model
            var cityDomainModel = new City
            {
                Name = addCityRequestDto.Name,
                Country = addCityRequestDto.Country
            };

            // Save the city to the database or perform any necessary operations
            cityDomainModel = await cityRepository.CreateAsync(cityDomainModel);

            //Remapping domain model to Dtos

            var CityDtoRemapped = new CityDto
            {
                Id = cityDomainModel.Id,
                Name = cityDomainModel.Name,
                Country = cityDomainModel.Country
            };

            // Return a successful response with the created city
            return CreatedAtAction(nameof(GetById), new { Id = cityDomainModel.Id }, CityDtoRemapped);
        }


        //  Update an existing city in the Cities table.
        //PUT : https://localhost:port/api/city/{id}
        [HttpPut]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> Update(Guid Id, [FromBody] CityChangesRequestDto updateCityRequestDto)
        {

            var cityDomainModel = new City
            {
                Name = updateCityRequestDto.Name,
                Country = updateCityRequestDto.Country
            };

            cityDomainModel = await cityRepository.UpdateAsync(Id, cityDomainModel);

            if (cityDomainModel == null)
            {
                return NotFound();
            }


            //Convert Domain Model to DTo
            var cityDto = new CityDto
            {
                Id = cityDomainModel.Id,
                Name = cityDomainModel.Name,
                Country = cityDomainModel.Country
            };

            return Ok(cityDto);
        }


        //Delete - Delete a city from the Cities table.
        //abc
        [HttpDelete]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            var cityDomainModel = await cityRepository.DeleteAsync(Id);

            if (cityDomainModel == null)
            {
                return NotFound();
            }

                //return deleted City back
                //map Domain Model to Dto

                var cityDto = new CityDto
                {
                    Id = cityDomainModel.Id,
                    Name = cityDomainModel.Name,
                    Country = cityDomainModel.Country
                };
                return Ok(cityDto);
            }

        }
    }













/* Manual Injection values via hardcoded list for testing api
           [HttpGet]
           public IActionResult GetAllCities()
           {
           var cities = new List<City>
           {
           new City
           {
           Id = Guid.NewGuid(),
           Name = "Nashik",
           Country = "India",
           },

           new City
           {
           Id = Guid.NewGuid(),
           Name = "Mumbai",
           Country = "India",
           },
           new City
           {
           Id = Guid.NewGuid(),
           Name = "Bangalore",
           Country = "India",
           },
           };
           return Ok(cities);
           }*/