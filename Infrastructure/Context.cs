using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Domin.Models;

namespace Infrastructure
{
    public class Context : DbContext
    {
        public Context() : base("name=DefaultConnection")

        {


        }

        public DbSet<Address> Address { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<GalleryCategory> GalleryCategory { get; set; }
        public DbSet<Menu> Menu { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<OrderItemDetails> OrderItemDetails { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }

        public DbSet<Post> Post { get; set; }
        public DbSet<PostCategory> PostCategory { get; set; }
        public DbSet<ProducSpecMapping> ProducSpecMapping { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }

        public DbSet<ProductDiscount> ProductDiscount { get; set; }
        public DbSet<ProductSpec> ProductSpec { get; set; }
        public DbSet<ProductSpecCategory> ProductSpecCategory { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserDiscount> UserDiscount { get; set; }


        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Domin.Models.Action> Action { get; set; }
        public DbSet<PermissionRoleMapping> PermissionRoleMapping { get; set; }

    }
}