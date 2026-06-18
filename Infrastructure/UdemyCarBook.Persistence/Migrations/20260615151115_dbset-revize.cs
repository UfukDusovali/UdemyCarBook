using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dbsetrevize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_AppRole_AppRoleId",
                table: "AppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Author_AuthorID",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Category_CategoryID",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Brand_BrandID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_CarDescription_Car_CarID",
                table: "CarDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeature_Car_CarID",
                table: "CarFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeature_Feature_FeatureID",
                table: "CarFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricing_Car_CarID",
                table: "CarPricing");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricing_Pricing_PricingID",
                table: "CarPricing");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Blog_BlogID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACar_Car_CarID",
                table: "RentACar");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACar_Location_LocationID",
                table: "RentACar");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Car_CarID",
                table: "RentACarProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Car_CarID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Location_DropOffLocationID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Location_PickUpLocationID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Car_CarID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_TagCloud_Blog_BlogID",
                table: "TagCloud");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonial",
                table: "Testimonial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagCloud",
                table: "TagCloud");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialMedia",
                table: "SocialMedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACar",
                table: "RentACar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pricing",
                table: "Pricing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FooterAddress",
                table: "FooterAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feature",
                table: "Feature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarPricing",
                table: "CarPricing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarFeature",
                table: "CarFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarDescription",
                table: "CarDescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Banner",
                table: "Banner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole");

            migrationBuilder.RenameTable(
                name: "Testimonial",
                newName: "Testimonials");

            migrationBuilder.RenameTable(
                name: "TagCloud",
                newName: "TagClouds");

            migrationBuilder.RenameTable(
                name: "SocialMedia",
                newName: "SocialMedias");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "Services");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameTable(
                name: "RentACar",
                newName: "RentACars");

            migrationBuilder.RenameTable(
                name: "Pricing",
                newName: "Pricings");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "FooterAddress",
                newName: "FooterAddresses");

            migrationBuilder.RenameTable(
                name: "Feature",
                newName: "Features");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "CarPricing",
                newName: "CarPricings");

            migrationBuilder.RenameTable(
                name: "CarFeature",
                newName: "CarFeatures");

            migrationBuilder.RenameTable(
                name: "CarDescription",
                newName: "CarDescriptions");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Cars");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "Brands");

            migrationBuilder.RenameTable(
                name: "Blog",
                newName: "Blogs");

            migrationBuilder.RenameTable(
                name: "Banner",
                newName: "Banners");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "AppUsers");

            migrationBuilder.RenameTable(
                name: "AppRole",
                newName: "AppRoles");

            migrationBuilder.RenameIndex(
                name: "IX_TagCloud_BlogID",
                table: "TagClouds",
                newName: "IX_TagClouds_BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_Review_CarID",
                table: "Reviews",
                newName: "IX_Reviews_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_PickUpLocationID",
                table: "Reservations",
                newName: "IX_Reservations_PickUpLocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_DropOffLocationID",
                table: "Reservations",
                newName: "IX_Reservations_DropOffLocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_CarID",
                table: "Reservations",
                newName: "IX_Reservations_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACar_LocationID",
                table: "RentACars",
                newName: "IX_RentACars_LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACar_CarID",
                table: "RentACars",
                newName: "IX_RentACars_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_BlogID",
                table: "Comments",
                newName: "IX_Comments_BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricing_PricingID",
                table: "CarPricings",
                newName: "IX_CarPricings_PricingID");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricing_CarID",
                table: "CarPricings",
                newName: "IX_CarPricings_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeature_FeatureID",
                table: "CarFeatures",
                newName: "IX_CarFeatures_FeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeature_CarID",
                table: "CarFeatures",
                newName: "IX_CarFeatures_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescription_CarID",
                table: "CarDescriptions",
                newName: "IX_CarDescriptions_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_Car_BrandID",
                table: "Cars",
                newName: "IX_Cars_BrandID");

            migrationBuilder.RenameIndex(
                name: "IX_Blog_CategoryID",
                table: "Blogs",
                newName: "IX_Blogs_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Blog_AuthorID",
                table: "Blogs",
                newName: "IX_Blogs_AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_AppUser_AppRoleId",
                table: "AppUsers",
                newName: "IX_AppUsers_AppRoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "TestimonialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagClouds",
                table: "TagClouds",
                column: "TagCloudID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialMedias",
                table: "SocialMedias",
                column: "SocialMediaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "ServiceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "ReservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACars",
                table: "RentACars",
                column: "RentACarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pricings",
                table: "Pricings",
                column: "PricingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FooterAddresses",
                table: "FooterAddresses",
                column: "FooterAddressID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Features",
                table: "Features",
                column: "FeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ContactID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "CommentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarPricings",
                table: "CarPricings",
                column: "CarPricingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarFeatures",
                table: "CarFeatures",
                column: "CarFeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarDescriptions",
                table: "CarDescriptions",
                column: "CarDescriptionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "BrandID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "BlogID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Banners",
                table: "Banners",
                column: "BannerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "AuthorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles",
                column: "AppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleId",
                table: "AppUsers",
                column: "AppRoleId",
                principalTable: "AppRoles",
                principalColumn: "AppRoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Authors_AuthorID",
                table: "Blogs",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Features_FeatureID",
                table: "CarFeatures",
                column: "FeatureID",
                principalTable: "Features",
                principalColumn: "FeatureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Cars_CarID",
                table: "CarPricings",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Pricings_PricingID",
                table: "CarPricings",
                column: "PricingID",
                principalTable: "Pricings",
                principalColumn: "PricingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandID",
                table: "Cars",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Cars_CarID",
                table: "RentACarProcess",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_Cars_CarID",
                table: "RentACars",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_Locations_LocationID",
                table: "RentACars",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Cars_CarID",
                table: "Reservations",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Locations_DropOffLocationID",
                table: "Reservations",
                column: "DropOffLocationID",
                principalTable: "Locations",
                principalColumn: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Locations_PickUpLocationID",
                table: "Reservations",
                column: "PickUpLocationID",
                principalTable: "Locations",
                principalColumn: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Cars_CarID",
                table: "Reviews",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagClouds_Blogs_BlogID",
                table: "TagClouds",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Authors_AuthorID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Features_FeatureID",
                table: "CarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Cars_CarID",
                table: "CarPricings");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Pricings_PricingID",
                table: "CarPricings");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Cars_CarID",
                table: "RentACarProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_Cars_CarID",
                table: "RentACars");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_Locations_LocationID",
                table: "RentACars");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Cars_CarID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Locations_DropOffLocationID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Locations_PickUpLocationID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Cars_CarID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_TagClouds_Blogs_BlogID",
                table: "TagClouds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagClouds",
                table: "TagClouds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialMedias",
                table: "SocialMedias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACars",
                table: "RentACars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pricings",
                table: "Pricings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FooterAddresses",
                table: "FooterAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Features",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarPricings",
                table: "CarPricings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarFeatures",
                table: "CarFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarDescriptions",
                table: "CarDescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Banners",
                table: "Banners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles");

            migrationBuilder.RenameTable(
                name: "Testimonials",
                newName: "Testimonial");

            migrationBuilder.RenameTable(
                name: "TagClouds",
                newName: "TagCloud");

            migrationBuilder.RenameTable(
                name: "SocialMedias",
                newName: "SocialMedia");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Service");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameTable(
                name: "RentACars",
                newName: "RentACar");

            migrationBuilder.RenameTable(
                name: "Pricings",
                newName: "Pricing");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "FooterAddresses",
                newName: "FooterAddress");

            migrationBuilder.RenameTable(
                name: "Features",
                newName: "Feature");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Car");

            migrationBuilder.RenameTable(
                name: "CarPricings",
                newName: "CarPricing");

            migrationBuilder.RenameTable(
                name: "CarFeatures",
                newName: "CarFeature");

            migrationBuilder.RenameTable(
                name: "CarDescriptions",
                newName: "CarDescription");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "Brand");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blog");

            migrationBuilder.RenameTable(
                name: "Banners",
                newName: "Banner");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "AppUser");

            migrationBuilder.RenameTable(
                name: "AppRoles",
                newName: "AppRole");

            migrationBuilder.RenameIndex(
                name: "IX_TagClouds_BlogID",
                table: "TagCloud",
                newName: "IX_TagCloud_BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_CarID",
                table: "Review",
                newName: "IX_Review_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_PickUpLocationID",
                table: "Reservation",
                newName: "IX_Reservation_PickUpLocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_DropOffLocationID",
                table: "Reservation",
                newName: "IX_Reservation_DropOffLocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_CarID",
                table: "Reservation",
                newName: "IX_Reservation_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACars_LocationID",
                table: "RentACar",
                newName: "IX_RentACar_LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACars_CarID",
                table: "RentACar",
                newName: "IX_RentACar_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogID",
                table: "Comment",
                newName: "IX_Comment_BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandID",
                table: "Car",
                newName: "IX_Car_BrandID");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_PricingID",
                table: "CarPricing",
                newName: "IX_CarPricing_PricingID");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_CarID",
                table: "CarPricing",
                newName: "IX_CarPricing_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeatures_FeatureID",
                table: "CarFeature",
                newName: "IX_CarFeature_FeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeatures_CarID",
                table: "CarFeature",
                newName: "IX_CarFeature_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescriptions_CarID",
                table: "CarDescription",
                newName: "IX_CarDescription_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blog",
                newName: "IX_Blog_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_AuthorID",
                table: "Blog",
                newName: "IX_Blog_AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_AppUsers_AppRoleId",
                table: "AppUser",
                newName: "IX_AppUser_AppRoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonial",
                table: "Testimonial",
                column: "TestimonialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagCloud",
                table: "TagCloud",
                column: "TagCloudID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialMedia",
                table: "SocialMedia",
                column: "SocialMediaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "ServiceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "ReservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACar",
                table: "RentACar",
                column: "RentACarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pricing",
                table: "Pricing",
                column: "PricingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FooterAddress",
                table: "FooterAddress",
                column: "FooterAddressID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feature",
                table: "Feature",
                column: "FeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "ContactID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "CommentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarPricing",
                table: "CarPricing",
                column: "CarPricingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarFeature",
                table: "CarFeature",
                column: "CarFeatureID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarDescription",
                table: "CarDescription",
                column: "CarDescriptionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "BrandID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "BlogID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Banner",
                table: "Banner",
                column: "BannerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "AuthorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole",
                column: "AppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_AppRole_AppRoleId",
                table: "AppUser",
                column: "AppRoleId",
                principalTable: "AppRole",
                principalColumn: "AppRoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Author_AuthorID",
                table: "Blog",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Category_CategoryID",
                table: "Blog",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Brand_BrandID",
                table: "Car",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescription_Car_CarID",
                table: "CarDescription",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeature_Car_CarID",
                table: "CarFeature",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeature_Feature_FeatureID",
                table: "CarFeature",
                column: "FeatureID",
                principalTable: "Feature",
                principalColumn: "FeatureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricing_Car_CarID",
                table: "CarPricing",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricing_Pricing_PricingID",
                table: "CarPricing",
                column: "PricingID",
                principalTable: "Pricing",
                principalColumn: "PricingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Blog_BlogID",
                table: "Comment",
                column: "BlogID",
                principalTable: "Blog",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACar_Car_CarID",
                table: "RentACar",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACar_Location_LocationID",
                table: "RentACar",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Car_CarID",
                table: "RentACarProcess",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Car_CarID",
                table: "Reservation",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Location_DropOffLocationID",
                table: "Reservation",
                column: "DropOffLocationID",
                principalTable: "Location",
                principalColumn: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Location_PickUpLocationID",
                table: "Reservation",
                column: "PickUpLocationID",
                principalTable: "Location",
                principalColumn: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Car_CarID",
                table: "Review",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagCloud_Blog_BlogID",
                table: "TagCloud",
                column: "BlogID",
                principalTable: "Blog",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
