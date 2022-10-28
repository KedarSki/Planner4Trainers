
using Common.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public class IdentityAppContext : IdentityDbContext
{
    public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
    { }

}