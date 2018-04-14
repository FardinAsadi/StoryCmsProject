namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PermissionId = c.Int(nullable: false),
                        ActionName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ControllerName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PermissionRoleMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PermissionId = c.Int(nullable: false),
                        AspNetRolesId = c.String(maxLength: 128),
                        AspNetUsersId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUsersId)
                .ForeignKey("dbo.AspNetRoles", t => t.AspNetRolesId)
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .Index(t => t.PermissionId)
                .Index(t => t.AspNetRolesId)
                .Index(t => t.AspNetUsersId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        AspNetUsers_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUsers_Id)
                .Index(t => t.AspNetUsers_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        AspNetUsers_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUsers_Id)
                .Index(t => t.AspNetUsers_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Company = c.String(),
                        Address1Fa = c.String(),
                        Address2 = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        Address1En = c.String(),
                        RegionsId = c.Int(),
                        NeighborhoodsId = c.Int(),
                        CustomersId = c.Int(),
                        ProvinceId = c.Int(),
                        CityId = c.Int(),
                        CountryId = c.Int(),
                        IsDefault = c.Boolean(),
                        PostalCode = c.String(),
                        MobileNumber = c.String(),
                        NationalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Provinces", t => t.ProvinceId)
                .Index(t => t.ProvinceId)
                .Index(t => t.CityId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Show = c.Boolean(nullable: false),
                        ProvincesId = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        MapPath = c.String(),
                        Coords = c.String(),
                        CreatorCode = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ThreeLetterIsoCode = c.String(),
                        DisplayOrder = c.Int(nullable: false),
                        MapPath = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(),
                        DisplayOrder = c.Int(nullable: false),
                        Show = c.Boolean(nullable: false),
                        EntitiesId = c.Int(nullable: false),
                        MapPath = c.String(),
                        Coords = c.String(),
                        CreatorCode = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GalleryCategoryId = c.Int(nullable: false),
                        Path = c.String(),
                        Size = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Avalible = c.Int(nullable: false),
                        Deleted = c.Boolean(),
                        CostDownload = c.Decimal(precision: 18, scale: 2),
                        Title = c.String(),
                        Desc = c.String(),
                        Product_Id = c.Int(),
                        ProductCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GalleryCategories", t => t.GalleryCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategory_Id)
                .Index(t => t.GalleryCategoryId)
                .Index(t => t.Product_Id)
                .Index(t => t.ProductCategory_Id);
            
            CreateTable(
                "dbo.GalleryCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(),
                        GalleryType = c.Int(nullable: false),
                        PortfolioAndNewDecorationId = c.Int(),
                        SuggestionsId = c.Int(),
                        EntitiesId = c.Int(nullable: false),
                        RestaurantsId = c.Int(),
                        EatingsId = c.Int(),
                        CreatorCode = c.String(),
                        GalleriesCategoriesId = c.Int(),
                        PartnersId = c.Int(),
                        CustomersId = c.Int(),
                        Title = c.String(),
                        UrlCategory1 = c.String(),
                        UrlCategory2 = c.String(),
                        UrlCategory3 = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsShipEnabled = c.Boolean(nullable: false),
                        StockQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SpecialPrice = c.Decimal(precision: 18, scale: 2),
                        Deleted = c.Boolean(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        ProductCategoryId = c.Int(nullable: false),
                        Image = c.String(),
                        Status = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        AdminRating = c.Double(),
                        Code = c.String(),
                        Special = c.Boolean(nullable: false),
                        CreatorCode = c.String(),
                        CustomersId = c.Int(),
                        Publish = c.Boolean(nullable: false),
                        ShowOnHomePage = c.Boolean(nullable: false),
                        ComingSoon = c.Boolean(nullable: false),
                        StockQuantityAlert = c.Int(),
                        PurchaseAmountLimit = c.Int(),
                        New = c.Boolean(nullable: false),
                        ValueRatio = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryId, cascadeDelete: true)
                .Index(t => t.ProductCategoryId);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShowOnHomePage = c.Boolean(nullable: false),
                        HasDiscountsApplied = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Image = c.String(),
                        ProductsCategoriesId = c.Int(),
                        DisplayOrder = c.Int(nullable: false),
                        Type = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        EntitiesId = c.Int(),
                        CreatorCode = c.String(),
                        BackgroundColor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductSpecCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ProductCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategory_Id)
                .Index(t => t.ProductCategory_Id);
            
            CreateTable(
                "dbo.ProductSpecs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductSpecCategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Count = c.Int(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductSpecCategories", t => t.ProductSpecCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.ProductSpecCategoryId)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.ProductDiscounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        DiscountPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Link = c.String(),
                        Link1 = c.String(),
                        Link2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menu1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuId = c.Int(nullable: false),
                        Name = c.String(),
                        Link = c.String(),
                        Link1 = c.String(),
                        Link2 = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        InvoicNumber = c.String(),
                        CustomerId = c.Int(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                        PaymentStatus = c.Int(nullable: false),
                        PaymentMethodSystemName = c.String(),
                        CustomerIp = c.String(),
                        PurchaseOrderNumber = c.String(),
                        MoneyReceptionDate = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        OrderType = c.Int(nullable: false),
                        RestaurantsId = c.Int(),
                        CreatorCode = c.String(),
                        AddressDetails = c.String(),
                        DiscountAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Desc = c.String(),
                        RecipientMobilNumber = c.String(),
                        RecipientPhoneNumber = c.String(),
                        RecipientName = c.String(),
                        PostalCode = c.String(),
                        RequiredInvoice = c.Boolean(nullable: false),
                        AdditionalCharges = c.Decimal(precision: 18, scale: 2),
                        OrderNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.OrderDiscounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        DiscountPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OriginalProductCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Desc = c.String(),
                        CountUnitSymbol = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.OrderItemDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderItemId = c.Int(nullable: false),
                        OptionKey = c.String(),
                        Value = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderItems", t => t.OrderItemId, cascadeDelete: true)
                .Index(t => t.OrderItemId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Phone = c.String(),
                        MobilePhone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        BirthDay = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserDiscounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        DiscountPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountsId = c.Int(),
                        OrderNumber = c.Long(nullable: false),
                        LastFourDigit = c.String(),
                        RequestDateTime = c.DateTime(nullable: false),
                        PaymentDateTime = c.DateTime(),
                        ApprovalDateTime = c.DateTime(),
                        Ip = c.String(),
                        Amount = c.String(),
                        Status = c.Int(nullable: false),
                        BankName = c.String(),
                        TrackingNumber = c.String(),
                        AccountOwner = c.String(),
                        Desc = c.String(),
                        Exp = c.String(),
                        OrdersId = c.Int(),
                        BankOrderNumber = c.Long(),
                        ExtraParam1 = c.String(),
                        ExtraParam2 = c.String(),
                        CreatorCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        EntitiesId = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        UsePercentage = c.Boolean(),
                        Wage = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        DefaultImage = c.String(),
                        DisplayOrder = c.Int(nullable: false),
                        CreatorCode = c.String(),
                        PostsCategoriesId = c.Int(),
                        Special = c.Boolean(nullable: false),
                        Publish = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        Title = c.String(),
                        Source = c.String(),
                        Keywords = c.String(),
                        Abstract = c.String(),
                        Desc = c.String(),
                        UrlCategory1 = c.String(),
                        UrlCategory2 = c.String(),
                        UrlKeywords = c.String(),
                        Tags = c.String(),
                        PostCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostCategories", t => t.PostCategory_Id)
                .Index(t => t.PostCategory_Id);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostsCategoriesId = c.Int(),
                        EntitiesId = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                        UpdateDateTime = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        Color = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        LanguagesId = c.Int(nullable: false),
                        MetaKeywords = c.String(),
                        MetaDescription = c.String(),
                        UrlCategory1 = c.String(),
                        UrlCategory2 = c.String(),
                        UrlCategory3 = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProducSpecMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ProductSpecId = c.Int(nullable: false),
                        Value = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.ProductSpecs", t => t.ProductSpecId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ProductSpecId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        AspNetUsers_Id = c.String(nullable: false, maxLength: 128),
                        AspNetRoles_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.AspNetUsers_Id, t.AspNetRoles_Id })
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUsers_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.AspNetRoles_Id, cascadeDelete: true)
                .Index(t => t.AspNetUsers_Id)
                .Index(t => t.AspNetRoles_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProducSpecMappings", "ProductSpecId", "dbo.ProductSpecs");
            DropForeignKey("dbo.ProducSpecMappings", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Posts", "PostCategory_Id", "dbo.PostCategories");
            DropForeignKey("dbo.UserDiscounts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropForeignKey("dbo.OrderItemDetails", "OrderItemId", "dbo.OrderItems");
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDiscounts", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Menu1", "MenuId", "dbo.Menus");
            DropForeignKey("dbo.ProductSpecs", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductDiscounts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductSpecCategories", "ProductCategory_Id", "dbo.ProductCategories");
            DropForeignKey("dbo.ProductSpecs", "ProductSpecCategoryId", "dbo.ProductSpecCategories");
            DropForeignKey("dbo.Products", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.Galleries", "ProductCategory_Id", "dbo.ProductCategories");
            DropForeignKey("dbo.GalleryCategories", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Galleries", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Galleries", "GalleryCategoryId", "dbo.GalleryCategories");
            DropForeignKey("dbo.Addresses", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Addresses", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropForeignKey("dbo.PermissionRoleMappings", "PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.PermissionRoleMappings", "AspNetRolesId", "dbo.AspNetRoles");
            DropForeignKey("dbo.PermissionRoleMappings", "AspNetUsersId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "AspNetUsers_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "AspNetUsers_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsersAspNetRoles", "AspNetRoles_Id", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUsersAspNetRoles", "AspNetUsers_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Actions", "PermissionId", "dbo.Permissions");
            DropIndex("dbo.AspNetUsersAspNetRoles", new[] { "AspNetRoles_Id" });
            DropIndex("dbo.AspNetUsersAspNetRoles", new[] { "AspNetUsers_Id" });
            DropIndex("dbo.ProducSpecMappings", new[] { "ProductSpecId" });
            DropIndex("dbo.ProducSpecMappings", new[] { "ProductId" });
            DropIndex("dbo.Posts", new[] { "PostCategory_Id" });
            DropIndex("dbo.UserDiscounts", new[] { "UserId" });
            DropIndex("dbo.OrderItemDetails", new[] { "OrderItemId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.OrderDiscounts", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Menu1", new[] { "MenuId" });
            DropIndex("dbo.ProductDiscounts", new[] { "ProductID" });
            DropIndex("dbo.ProductSpecs", new[] { "Product_Id" });
            DropIndex("dbo.ProductSpecs", new[] { "ProductSpecCategoryId" });
            DropIndex("dbo.ProductSpecCategories", new[] { "ProductCategory_Id" });
            DropIndex("dbo.Products", new[] { "ProductCategoryId" });
            DropIndex("dbo.GalleryCategories", new[] { "ProductId" });
            DropIndex("dbo.Galleries", new[] { "ProductCategory_Id" });
            DropIndex("dbo.Galleries", new[] { "Product_Id" });
            DropIndex("dbo.Galleries", new[] { "GalleryCategoryId" });
            DropIndex("dbo.Addresses", new[] { "CountryId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropIndex("dbo.Addresses", new[] { "ProvinceId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "AspNetUsers_Id" });
            DropIndex("dbo.AspNetUserClaims", new[] { "AspNetUsers_Id" });
            DropIndex("dbo.PermissionRoleMappings", new[] { "AspNetUsersId" });
            DropIndex("dbo.PermissionRoleMappings", new[] { "AspNetRolesId" });
            DropIndex("dbo.PermissionRoleMappings", new[] { "PermissionId" });
            DropIndex("dbo.Actions", new[] { "PermissionId" });
            DropTable("dbo.AspNetUsersAspNetRoles");
            DropTable("dbo.ProducSpecMappings");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Posts");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Payments");
            DropTable("dbo.UserDiscounts");
            DropTable("dbo.Users");
            DropTable("dbo.OrderItemDetails");
            DropTable("dbo.OrderItems");
            DropTable("dbo.OrderDiscounts");
            DropTable("dbo.Orders");
            DropTable("dbo.Menu1");
            DropTable("dbo.Menus");
            DropTable("dbo.ProductDiscounts");
            DropTable("dbo.ProductSpecs");
            DropTable("dbo.ProductSpecCategories");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.GalleryCategories");
            DropTable("dbo.Galleries");
            DropTable("dbo.Discounts");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Provinces");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PermissionRoleMappings");
            DropTable("dbo.Permissions");
            DropTable("dbo.Actions");
        }
    }
}
