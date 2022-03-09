#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketsApi.DTOs;
using TicketsApi.Models;

namespace TicketsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly TicketsApiContext _context;

        public TicketsController(TicketsApiContext context)
        {
            _context = context;
        }

        // GET: api/Tickets
        [HttpGet]
        public async Task<IEnumerable<TicketDTO>> GetTickets()
        {

            IEnumerable<Ticket> TicketList = (await _context.Tickets
                .ToListAsync());


            foreach (Ticket ticket in TicketList)
            {
                _context.Entry(ticket).Reference(t => t.Status).Load();
                _context.Entry(ticket).Reference(t => t.User).Load();
            }

            var DTOList = MapperConfig.MapperConfiguration.MapperTicket.Map<IEnumerable<TicketDTO>>(TicketList);

            return DTOList;
        }

        // GET: api/Tickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDTO>> GetTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket == null)
            {
                return NotFound();
            }

            _context.Entry(ticket).Reference(t => t.Status).Load();
            _context.Entry(ticket).Reference(t => t.User).Load();

            var DTOTicket = MapperConfig.MapperConfiguration.MapperTicket.Map<TicketDTO>(ticket);

            return DTOTicket;
        }

        // PUT: api/Tickets/5
        [HttpPut]
        public async Task<IActionResult> PutTicket(TicketDTO ticket)
        {
            Ticket DbTicket = _context.Tickets.Where(t => t.IdTicket == ticket.IdTicket).FirstOrDefault();

            if (DbTicket == null)
            {
                return NotFound();
            }

            var FromDTOTicket = MapperConfig.MapperConfiguration.MapperTicket.Map<Ticket>(DbTicket);

            FromDTOTicket.UpdateDate = DateTime.Now;
            FromDTOTicket.UserId = ticket.UserId;
            FromDTOTicket.StatusId = ticket.StatusId;
            FromDTOTicket.Description = ticket.Description;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Tickets
        [HttpPost]
        public async Task<ActionResult<TicketDTO>> PostTicket(TicketDTO ticket)
        {
            ticket.CreationDate = DateTime.Now;
            ticket.UpdateDate = null;
            var FromDTOTicket = MapperConfig.MapperConfiguration.MapperTicket.Map<Ticket>(ticket);

            _context.Tickets.Add(FromDTOTicket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicket", new { id = ticket.IdTicket }, ticket);
        }

        // DELETE: api/Tickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
