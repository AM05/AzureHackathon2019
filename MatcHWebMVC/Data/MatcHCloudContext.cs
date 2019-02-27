using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MatcHWebMVC.Models;
using MatcHWebMVCC.Models;

namespace MatcHWebMVC.Data
{
	public class MatcHCloudContext : DbContext
	{
		public MatcHCloudContext(DbContextOptions<MatcHCloudContext> options) : base(options)
		{
		}

		public DbSet<IT_PRODUCTS> IT_PRODUCT { get; set; }

		public DbSet<MatcHWebMVC.Models.DCL3> DCL3 { get; set; }

		public DbSet<MatcHWebMVC.Models.WAVE_PLAN> WAVE_PLAN { get; set; }

		public DbSet<MatcHWebMVCC.Models.IBMBaseline> IBMBaseline { get; set; }

		public DbSet<MatcHWebMVCC.Models.FirstPage> FirstPage { get; set; }

		public DbSet<MatcHWebMVCC.Models.Users> tblUsers { get; set; }

		// public DbSet<MatcHWebMVCC.Models.LoginModel> LoginModel { get; set; }


	}
}
