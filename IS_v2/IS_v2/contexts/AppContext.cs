using IS_v2.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_v2.contexts
{
    public class AppContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<Component> components { get; set; }
        public DbSet<Delivery> deliveries { get; set; }
        public DbSet<DeliveryComponent> delivery_components { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderService> order_services { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<ServiceComponent> service_components { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=pc_repair_service;Username=postgres;Password=8631");
            }
        }
    }
}
