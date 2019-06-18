using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {

        public ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/rentals
        public IHttpActionResult GetRentals()
        {
            throw new NotImplementedException();
        }

        //GET /api/rentals/1
        public IHttpActionResult GetMovies(int id)
        {
            throw new NotImplementedException();
        }
        
        //POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateRentals(RentalDto rentalDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = _context.Customers.Single(c => c.Id == rentalDto.CustomerId);
            var movies = _context.Movies.Where(m => rentalDto.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if(movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now   
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();

        }

        //PUT /api/rentals/1
        [HttpPut]
        public IHttpActionResult EditMovies(int id)
        {
            throw new NotImplementedException();
        }

        //DELETE /api/rentals
        public IHttpActionResult GetMovies()
        {
            throw new NotImplementedException();
        }

        
    }
}
