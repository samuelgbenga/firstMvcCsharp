// Controllers/UserInputController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleMvcApp.Data;
using SimpleMvcApp.Models;
using System.Threading.Tasks;

public class UserInputController : Controller
{
    private readonly AppDbContext _context;

    public UserInputController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(UserInput userInput)
    {
        if (ModelState.IsValid)
        {
            _context.UserInputs.Add(userInput);
            await _context.SaveChangesAsync();
            ViewBag.Message = "Input saved successfully!";
        }
        return View(userInput);
    }

    public async Task<IActionResult> List()
    {
        var inputs = await _context.UserInputs.ToListAsync();
        return View(inputs);
    }
}
