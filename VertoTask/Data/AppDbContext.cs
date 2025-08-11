using Microsoft.EntityFrameworkCore;
using VertoTask.Models;

namespace VertoTask.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        private byte[] GetImageBytesFromPath(string path)
        {
            var imageData = File.ReadAllBytes(path);
            return imageData;
        }


        public DbSet<HomepageContent> HomepageContents { get; set; }
        public DbSet<GlobalContent> GlobalContents { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HomepageContent>().HasData(
                 new HomepageContent
                 {
                     Id = 1,
                     Section1_Image1Path = "images/image4.png",
                     Section1_TextOverCarousel = "Creating Exceptional Workspaces",
                     Section2_Image1Path = "images/circle-icons.png",
                     Section2_Title = "Custom built design & furniture solutions",
                     Section2_SubTitle = "Specialists in transforming commercial spaces into agile, functional and empowering environments.",
                     Section2_ButtonText = "WHAT WE DO",
                     Section3_FloatingText = "Explore our latest work...",
                     Section4_Image1Path = "images/image2.png",
                     Section4_GlobalText = "VIEW MORE->",
                     Section4_Image1Title = "Case Study Name Here",
                     Section4_Image1Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam.",
                     Section4_Image2Title = "Case Study Name Here",
                     Section4_Image3Title = "Case Study Name Here",
                     Section5_Title = "Discover more about iOTA",
                     Section5_SubTitle = "Find out who we are, why we do it and why we love what we do.",
                     Section5_Image1Text = "WATCH THE VIDEO",
                     Section5_Image2Text = "ABOUT iOTA",
                     }
                 );

            modelBuilder.Entity<GlobalContent>().HasData(
                 new GlobalContent
            {
               Id = 1,
               LogoImagePath = "images/logo.png",
               QuestionBoxPath = "images/Rectangle 121.png",
               HeaderLinks = new string[]
               {
                  "Home", "Services", "Sustainability", "Our work", "Resources", "About IOTA", "Contact us"
               },
               CoopyRightext = "© iOTA Interiors Limited T/A iOTA Office Furniture",
               TermsConditions = "Terms and conditions",
               WebsiteMakerText = "Site by Verto",
               AdressName = "Head Office",
               AdressLine1 = "The Crabtree, Quinton Green Park,",
               AdressLine2 = "Quinton, Northampton, NN7 2EG",
               interactionText1 = "Connect with us",
               interactionText2 = "Like us",
               phoneNumber = "+44(0) 1604289630",
               ContactEmail = "hello@iotaofficefurniture.co.uk"
                 }
             );
        }



    }
}
