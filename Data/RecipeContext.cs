using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeBox.Components.Pages;

namespace RecipeBox.Data
{
    internal partial class RecipeContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }  
    }
}
