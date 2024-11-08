﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Boilerplate.Repository;

public class BoilerplateDbContext(DbContextOptions options) : IdentityDbContext(options)
{
    
}
