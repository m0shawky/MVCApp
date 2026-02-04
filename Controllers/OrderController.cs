using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCApp.Data;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class OrderController : Controller
    {
        

        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        //Get : Orders
        public async Task<IActionResult> Index(){

            var results =await _context.Orders.ToListAsync();

             return View( results);


        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details (int? id){
            if (id==null){
                return NotFound();
            }
            var order = await _context.Orders.FindAsync(id);
            if (order == null){
                return NotFound();
            }
            return View(order);
        }

        // GET: Orders/Create

        public IActionResult Create(){

            return View ();
        }

         // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,UserId,Orderstatus,OrderDate")] Order order){
            if (!ModelState.IsValid)
            {
                return View(order);
            }

            _context.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        public async Task<IActionResult> Edit(int? id)
        {
            
            if(id == null){return NotFound();}
            var result = await _context.Orders.FindAsync(id);
            if (result == null) {return NotFound();}
            return View (result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("OrderId,UserId,Orderstatus,OrderDate")] Order order )
        {
            if (!ModelState.IsValid){return View(order);}
            try{
            _context.Update(order);
            await _context.SaveChangesAsync();

            }
            catch
            {
                
               throw; 
            }
            return RedirectToAction(nameof(Index));

        }


        public async Task<IActionResult> Delet(int? id)
        {
            if (id == null ){return NotFound();}
            var result= await _context.Orders.FindAsync(id);
            if (result == null ){return NotFound();}
            return View (result);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletSelected(int? id )
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null ){return NotFound();}
            _context.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
