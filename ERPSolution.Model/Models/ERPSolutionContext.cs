using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERPSolution.Model.Models
{
    public class ERPSolutionContext : DbContext
    {
        public ERPSolutionContext() { }

        public ERPSolutionContext(DbContextOptions<ERPSolutionContext> options)
            : base(options) { }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DeliveryTicket> DeliveryTicket { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Designes> Designes { get; set; }
        public virtual DbSet<DesignFileAttach> DesignFileAttach { get; set; }
        public virtual DbSet<EmployeeRoles> EmployeeRoles { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmployeeStatusMaster> EmployeeStatusMaster { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobMaster> JobMaster { get; set; }
        public virtual DbSet<Machines> Machines { get; set; }
        public virtual DbSet<MachineTypeMaster> MachineTypeMaster { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Parts> Parts { get; set; }
        public virtual DbSet<ProductionOrder> ProductionOrder { get; set; }
        public virtual DbSet<ProductionStatusMaster> ProductionStatusMaster { get; set; }
        public virtual DbSet<ProductMaster> ProductMaster { get; set; }
        public virtual DbSet<RequireTicket> RequireTicket { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<TaskContentMaster> TaskContentMaster { get; set; }
        public virtual DbSet<TaskImplement> TaskImplement { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<UnitMaster> UnitMaster { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserusersEmployeeRolesroles> UserusersEmployeeRolesroles { get; set; }
        public virtual DbSet<WareHouses> WareHouses { get; set; }
        public virtual DbSet<XpobjectType> XpobjectType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Customer");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DeliveryTicket>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_DeliveryTicket");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.DepartmentHead)
                    .HasName("idepartmentHead_Departments");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Departments");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.DepartmentHead).HasColumnName("departmentHead");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);

                entity.HasOne(d => d.DepartmentHeadNavigation)
                    .WithMany(p => p.DepartmentsNavigation)
                    .HasForeignKey(d => d.DepartmentHead)
                    .HasConstraintName("FK_Departments_departmentHead");
            });

            modelBuilder.Entity<Designes>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CreateUser)
                    .HasName("icreateUser_Designes");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Designes");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.Designes)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_Designes_createUser");
            });

            modelBuilder.Entity<DesignFileAttach>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Design)
                    .HasName("idesign_DesignFileAttach");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_DesignFileAttach");

                entity.HasIndex(e => e.Part)
                    .HasName("ipart_DesignFileAttach");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Design).HasColumnName("design");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);

                entity.Property(e => e.Part).HasColumnName("part");

                entity.HasOne(d => d.DesignNavigation)
                    .WithMany(p => p.DesignFileAttach)
                    .HasForeignKey(d => d.Design)
                    .HasConstraintName("FK_DesignFileAttach_design");

                entity.HasOne(d => d.PartNavigation)
                    .WithMany(p => p.DesignFileAttach)
                    .HasForeignKey(d => d.Part)
                    .HasConstraintName("FK_DesignFileAttach_part");
            });

            modelBuilder.Entity<EmployeeRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EmployeeRoles");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Departments)
                    .HasName("idepartments_Employees");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Employees");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("dateOfBirth")
                    .HasColumnType("datetime");

                entity.Property(e => e.Departments).HasColumnName("departments");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Departments1)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Departments)
                    .HasConstraintName("FK_Employees_departments");
            });

            modelBuilder.Entity<EmployeeStatusMaster>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CreateUser)
                    .HasName("icreateUser_EmployeeStatusMaster");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EmployeeStatusMaster");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.EmployeeStatusMaster)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_EmployeeStatusMaster_createUser");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Groups");

                entity.HasIndex(e => e.GroupManager)
                    .HasName("igroupManager_Groups");

                entity.HasIndex(e => e.GroupViceManager)
                    .HasName("igroupViceManager_Groups");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.GroupManager).HasColumnName("groupManager");

                entity.Property(e => e.GroupViceManager).HasColumnName("groupViceManager");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.GroupManagerNavigation)
                    .WithMany(p => p.GroupsGroupManagerNavigation)
                    .HasForeignKey(d => d.GroupManager)
                    .HasConstraintName("FK_Groups_groupManager");

                entity.HasOne(d => d.GroupViceManagerNavigation)
                    .WithMany(p => p.GroupsGroupViceManagerNavigation)
                    .HasForeignKey(d => d.GroupViceManager)
                    .HasConstraintName("FK_Groups_groupViceManager");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Job");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnName("endTime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnName("startTime");
            });

            modelBuilder.Entity<JobMaster>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CreateUser)
                    .HasName("icreateUser_JobMaster");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_JobMaster");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.JobMaster)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_JobMaster_createUser");
            });

            modelBuilder.Entity<Machines>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Machines");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MachineTypeMaster>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_MachineTypeMaster");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CreateUser)
                    .HasName("icreateUser_Material");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Material");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_Material_createUser");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Notifications");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Customer)
                    .HasName("i_customer_Orders");

                entity.HasIndex(e => e.Customer1)
                    .HasName("icustomer_Orders");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Orders");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(100);

                entity.Property(e => e.Customer).HasColumnName("_customer");

                entity.Property(e => e.Customer1).HasColumnName("customer");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.OrdersCustomerNavigation)
                    .HasForeignKey(d => d.Customer)
                    .HasConstraintName("FK_Orders__customer");

                entity.HasOne(d => d.Customer1Navigation)
                    .WithMany(p => p.OrdersCustomer1Navigation)
                    .HasForeignKey(d => d.Customer1)
                    .HasConstraintName("FK_Orders_customer");
            });

            modelBuilder.Entity<Parts>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Parts");

                entity.HasIndex(e => e.Material)
                    .HasName("imaterial_Parts");

                entity.HasIndex(e => e.ProductionOrder)
                    .HasName("iproductionOrder_Parts");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Material).HasColumnName("material");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductionOrder).HasColumnName("productionOrder");

                entity.Property(e => e.RoughSize)
                    .HasColumnName("roughSize")
                    .HasMaxLength(100);

                entity.Property(e => e.Shape)
                    .HasColumnName("shape")
                    .HasMaxLength(100);

                entity.Property(e => e.StandardSize)
                    .HasColumnName("standardSize")
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.Material)
                    .HasConstraintName("FK_Parts_material");

                entity.HasOne(d => d.ProductionOrderNavigation)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.ProductionOrder)
                    .HasConstraintName("FK_Parts_productionOrder");
            });

            modelBuilder.Entity<ProductionOrder>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ProductionOrder");

                entity.HasIndex(e => e.Supervisor)
                    .HasName("isupervisor_ProductionOrder");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Deadline)
                    .HasColumnName("deadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.InputDate)
                    .HasColumnName("inputDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Supervisor).HasColumnName("supervisor");

                entity.HasOne(d => d.SupervisorNavigation)
                    .WithMany(p => p.ProductionOrder)
                    .HasForeignKey(d => d.Supervisor)
                    .HasConstraintName("FK_ProductionOrder_supervisor");
            });

            modelBuilder.Entity<ProductionStatusMaster>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CreateUser)
                    .HasName("icreateUser_ProductionStatusMaster");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ProductionStatusMaster");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.ProductionStatusMaster)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_ProductionStatusMaster_createUser");
            });

            modelBuilder.Entity<ProductMaster>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CreateUser)
                    .HasName("icreateUser_ProductMaster");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ProductMaster");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.ProductMaster)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_ProductMaster_createUser");
            });

            modelBuilder.Entity<RequireTicket>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_RequireTicket");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Suppliers");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TaskContentMaster>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CreateUser)
                    .HasName("icreateUser_TaskContentMaster");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_TaskContentMaster");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.IsOutSite).HasColumnName("isOutSite");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.TaskContentMaster)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_TaskContentMaster_createUser");
            });

            modelBuilder.Entity<TaskImplement>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_TaskImplement");

                entity.HasIndex(e => e.Task)
                    .HasName("itask_TaskImplement");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Task).HasColumnName("task");

                entity.HasOne(d => d.TaskNavigation)
                    .WithMany(p => p.TaskImplement)
                    .HasForeignKey(d => d.Task)
                    .HasConstraintName("FK_TaskImplement_task");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Tasks");

                entity.HasIndex(e => e.Part)
                    .HasName("ipart_Tasks");

                entity.HasIndex(e => e.TaskContent)
                    .HasName("itaskContent_Tasks");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.Deadline)
                    .HasColumnName("deadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpectedStartDate)
                    .HasColumnName("expectedStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinishedAmount).HasColumnName("finishedAmount");

                entity.Property(e => e.FinishedDate)
                    .HasColumnName("finishedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Part).HasColumnName("part");

                entity.Property(e => e.RequiredAmount).HasColumnName("requiredAmount");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.TaskContent).HasColumnName("taskContent");

                entity.HasOne(d => d.PartNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.Part)
                    .HasConstraintName("FK_Tasks_part");

                entity.HasOne(d => d.TaskContentNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.TaskContent)
                    .HasConstraintName("FK_Tasks_taskContent");
            });

            modelBuilder.Entity<UnitMaster>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CreateUser)
                    .HasName("icreateUser_UnitMaster");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UnitMaster");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.UnitMaster)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_UnitMaster_createUser");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_User");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserusersEmployeeRolesroles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Userusers_EmployeeRolesroles");

                entity.HasIndex(e => e.Roles)
                    .HasName("iroles_Userusers_EmployeeRolesroles");

                entity.HasIndex(e => e.Users)
                    .HasName("iusers_Userusers_EmployeeRolesroles");

                entity.HasIndex(e => new { e.Roles, e.Users })
                    .HasName("irolesusers_Userusers_EmployeeRolesroles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Roles).HasColumnName("roles");

                entity.Property(e => e.Users).HasColumnName("users");

                entity.HasOne(d => d.RolesNavigation)
                    .WithMany(p => p.UserusersEmployeeRolesroles)
                    .HasForeignKey(d => d.Roles)
                    .HasConstraintName("FK_Userusers_EmployeeRolesroles_roles");

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.UserusersEmployeeRolesroles)
                    .HasForeignKey(d => d.Users)
                    .HasConstraintName("FK_Userusers_EmployeeRolesroles_users");
            });

            modelBuilder.Entity<WareHouses>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CreateUser)
                    .HasName("icreateUser_WareHouses");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_WareHouses");

                entity.HasIndex(e => e.Manager)
                    .HasName("imanager_WareHouses");

                entity.HasIndex(e => e.Supporter)
                    .HasName("isupporter_WareHouses");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasColumnName("createUser");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Manager).HasColumnName("manager");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Supporter).HasColumnName("supporter");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreateUserNavigation)
                    .WithMany(p => p.WareHouses)
                    .HasForeignKey(d => d.CreateUser)
                    .HasConstraintName("FK_WareHouses_createUser");

                entity.HasOne(d => d.ManagerNavigation)
                    .WithMany(p => p.WareHousesManagerNavigation)
                    .HasForeignKey(d => d.Manager)
                    .HasConstraintName("FK_WareHouses_manager");

                entity.HasOne(d => d.SupporterNavigation)
                    .WithMany(p => p.WareHousesSupporterNavigation)
                    .HasForeignKey(d => d.Supporter)
                    .HasConstraintName("FK_WareHouses_supporter");
            });

            modelBuilder.Entity<XpobjectType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XPObjectType");

                entity.HasIndex(e => e.TypeName)
                    .HasName("iTypeName_XPObjectType")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.AssemblyName).HasMaxLength(254);

                entity.Property(e => e.TypeName).HasMaxLength(254);
            });
        }
    }
}
