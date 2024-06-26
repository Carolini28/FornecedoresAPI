using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FornecedoresAPI.Data;
using FornecedoresAPI.Models;

namespace FornecedoresAPI.Controllers {

	[Route("api/[controller]")]
	[ApiController]
	public class FornecedoresController : ControllerBase {

		private readonly FornecedoresContext _context;

		public FornecedoresController(FornecedoresContext context)
		{
			_context = context;
		}

		// GET: api/fornecedores
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Fornecedor>>> GetFornecedores()
		{
			return await _context.Fornecedores.ToListAsync();
		}

		// GET: api/fornecedores/{id}
		[HttpGet("{id}")]
		public async Task<ActionResult<Fornecedor>> GetFornecedor(int id)
		{
			var fornecedor = await _context.Fornecedores.FindAsync(id);

			if (fornecedor == null)
			{
				return NotFound();
			}

			return fornecedor;
		}

		// POST: api/fornecedores
		[HttpPost]
		public async Task<ActionResult<Fornecedor>> PostFornecedor(Fornecedor fornecedor)
		{
			_context.Fornecedores.Add(fornecedor);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetFornecedor), new { id = fornecedor.Id }, fornecedor);
		}

		// PUT: api/fornecedores/{id}
		[HttpPut("{id}")]
		public async Task<IActionResult> PutFornecedor(int id, Fornecedor fornecedor)
		{
			if (id != fornecedor.Id)
			{
				return BadRequest();
			}

			_context.Entry(fornecedor).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!FornecedorExists(id))
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

		// DELETE: api/fornecedores/{id}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteFornecedor(int id)
		{
			var fornecedor = await _context.Fornecedores.FindAsync(id);
			if (fornecedor == null)
			{
				return NotFound();
			}

			_context.Fornecedores.Remove(fornecedor);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool FornecedorExists(int id)
		{
			return _context.Fornecedores.Any(e => e.Id == id);
		}
	}
}