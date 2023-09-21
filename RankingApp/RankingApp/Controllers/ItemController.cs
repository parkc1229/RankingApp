﻿using System;
using Microsoft.AspNetCore.Mvc;
using RankingApp.Models;
using System.Linq;
using System.Threading.Tasks;
using RankingApp.Data;
using Microsoft.EntityFrameworkCore;

namespace RankingApp.Controllers
{
    [Route("api/Item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly DataContext _context;

        public ItemController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<ItemModel>>> AddItem(ItemModel item)
        {
            /*
            _context.ItemModels.Add(item);
            await _context.SaveChangesAsync();

            return Ok(await _context.ItemModels.ToListAsync());
            */

            _context.ItemModels.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        [HttpGet]
        public async Task<ActionResult<List<ItemModel>>> GetAllItems()
        {
            //return Ok(await _context.ItemModels.ToListAsync());

            if(_context.ItemModels == null)
            {
                return NotFound();
            }

            return await _context.ItemModels.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemModel>> GetItem(int id)
        {
            /*
            var item = await _context.ItemModels.FindAsync(id);
            if(item == null)
            {
                return BadRequest("Item not found.");
            }
            return Ok(item);
            */

            if(_context.ItemModels == null)
            {
                return NotFound();
            }
            var itemModel = await _context.ItemModels.FindAsync(id);

            if(itemModel == null)
            {
                return NotFound();
            }

            return itemModel;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, ItemModel itemModel)
        {
            if (id != itemModel.Id)
            {
                return BadRequest();
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!ItemModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            if(_context.ItemModels == null)
            {
                return NotFound();
            }
            var itemModel = await _context.ItemModels.FindAsync(id);
            if(itemModel == null)
            {
                return NotFound();
            }

            _context.ItemModels.Remove(itemModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool ItemModelExists(int id)
        {
            return (_context.ItemModels?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        /*
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id =1, Title = "The Godfather", ImageId=1, Ranking=0,ItemType=1 },
            new ItemModel{Id =2, Title = "Highlander", ImageId=2, Ranking=0,ItemType=1 },
            new ItemModel{Id =3, Title = "Highlander II", ImageId=3, Ranking=0,ItemType=1 },
            new ItemModel{Id =4, Title = "The Last of the Mohicans", ImageId=4, Ranking=0,ItemType=1 },
            new ItemModel{Id =5, Title = "Police Academy 6", ImageId=5, Ranking=0,ItemType=1 },
            new ItemModel{Id =6, Title = "Rear Window", ImageId=6, Ranking=0,ItemType=1 },
            new ItemModel{Id =7, Title = "Road House", ImageId=7, Ranking=0,ItemType=1 },
            new ItemModel{Id =8, Title = "The Shawshank Redemption", ImageId=8, Ranking=0,ItemType=1 },
            new ItemModel{Id =9, Title = "Star Treck IV", ImageId=9, Ranking=0,ItemType=1 },
            new ItemModel{Id =10, Title = "Superman 4", ImageId=10, Ranking=0,ItemType=1 },
            new ItemModel{Id = 11, Title = "Abbey Road", ImageId=11, Ranking=0,ItemType=2 },
            new ItemModel{Id = 12, Title = "Adrenalize", ImageId=12, Ranking=0,ItemType=2 },
            new ItemModel{Id = 13, Title = "Back in Black", ImageId=13, Ranking=0,ItemType=2 },
            new ItemModel{Id = 14, Title = "Enjoy the Silence", ImageId=14, Ranking=0,ItemType=2 },
            new ItemModel{Id = 15, Title = "Parachutes", ImageId=15, Ranking=0,ItemType=2 },
            new ItemModel{Id = 16, Title = "Ride the Lightning", ImageId=16, Ranking=0,ItemType=2 },
            new ItemModel{Id = 17, Title = "Rock or Bust", ImageId=17, Ranking=0,ItemType=2 },
            new ItemModel{Id = 18, Title = "Rust in Peace", ImageId=18, Ranking=0,ItemType=2 },
            new ItemModel{Id = 19, Title = "St. Anger", ImageId=19, Ranking=0,ItemType=2 },
            new ItemModel{Id = 20, Title = "The Final Countdown", ImageId=20, Ranking=0,ItemType=2 }

        };
        */

        /*
        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            return items;
        }
        */
        

        
        
    }
}

