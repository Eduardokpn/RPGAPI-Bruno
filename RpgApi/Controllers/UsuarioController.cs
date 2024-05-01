using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;

[ApiController]
[Route("[controller]")]

public class UsuarioController : ControllerBase {
    private readonly DataContext _context;

    public UsuarioController(DataContext _context) {
        
    }
}