using Microsoft.EntityFrameworkCore;
using viageMais.Models;

namespace viageMais.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Destination> Destination { get; set; }
        public DbSet<Hotel> Hotel { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //modelBuilder.Entity<Destination>().Property(x => x.Id).ValueGeneratedOnAdd();
            // modelBuilder.Entity<Hotel>().Property(x => x.Id).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destination>().HasData(
            new Destination
            {
                Id = 1,
                City = "foz-do-iguacu",
                MainName = "foz-do-iguaçu",
                Country = "brasil",
                Description = "Localizada na tríplice fronteira entre Brasil, Argentina e Paraguai, Foz do Iguaçu é conhecida pelas impressionantes Cataratas do Iguaçu. O Parque Nacional do Iguaçu abriga uma das maiores e mais espetaculares quedas d'água do mundo, oferecendo uma experiência única em meio à natureza exuberante da região.",
                ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/foziguacu.webp",
            },
          new Destination
          {
              Id = 2,
              City = "caribe",
              MainName = "caribe",
              Country = "caribe",
              Description = "O Caribe é uma região paradisíaca que abrange várias ilhas, como as Bahamas, Jamaica, Porto Rico e muitas outras. Conhecido por suas praias de areia branca, águas cristalinas e uma rica cultura vibrante, o Caribe é um destino popular para turistas em busca de relaxamento, esportes aquáticos e vida noturna animada.",
              ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/caribe.webp",
          },
          new Destination
          {
              Id = 3,
              City = "dubai",
              MainName = "dubai",
              Country = "emirados-árabes-unidos",
              Description = "Dubai é uma metrópole futurista no coração do Oriente Médio, conhecida por suas arquiteturas icônicas, como o Burj Khalifa, o edifício mais alto do mundo. A cidade oferece uma mistura de modernidade e tradição, com shoppings luxuosos, resorts de classe mundial, desertos fascinantes e uma atmosfera cosmopolita.",
              ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/dubai.webp",
          },
          new Destination
          {
              Id = 4,
              City = "maceio",
              MainName = "maceió",
              Country = "brasil",
              Description = "Capital do estado de Alagoas, Maceió é famosa por suas praias deslumbrantes e piscinas naturais formadas por recifes de corais. As águas calmas e cristalinas do litoral atraem visitantes em busca de paisagens tropicais, enquanto a cultura local e a gastronomia regional adicionam um toque especial à experiência.",
              ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/maceio.webp",
          },
          new Destination
          {
              Id = 5,
              City = "londres",
              MainName = "londres",
              Country = "inglaterra",
              Description = "A capital do Reino Unido, Londres, é uma cidade histórica e cosmopolita. Oferece uma rica herança cultural, incluindo ícones como o Palácio de Buckingham, o Parlamento, a Torre de Londres e o Museu Britânico. Além disso, a cidade é conhecida por suas opções de compras, teatros, parques e uma vibrante cena gastronômica.",
              ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/londres.webp",
          },
          new Destination
          {
              Id = 6,
              City = "cancun",
              MainName = "cancún",
              Country = "méxico",
              Description = "Situada na Península de Yucatán, Cancún é um destino de resort popular, conhecido por suas praias de areia branca e águas cristalinas do Caribe. Além de suas atrações naturais, Cancún oferece uma animada vida noturna, restaurantes de alta qualidade e a proximidade das antigas ruínas maias de Chichén Itzá.",
              ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/mexico.webp",
          },
          new Destination
          {
              Id = 7,
              City = "serra-gaucha",
              MainName = "serra-gaúcha",
              Country = "brasil",
              Description = "A Serra Gaúcha, no estado do Rio Grande do Sul, é uma região encantadora com forte influência da colonização italiana. Cidades como Gramado e Canela são famosas por sua arquitetura europeia, culinária deliciosa, chocolates artesanais e festivais de inverno. A região é um destino popular durante o Natal Luz, quando as cidades se iluminam com decorações festivas.",
              ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/serra-gaucha.jpg",
          },
          new Destination
          {
              Id = 8,
              City = "machu-picchu",
              MainName = "machu-picchu",
              Country = "peru",
              Description = "Machu Picchu é uma antiga cidade inca situada nas montanhas dos Andes peruanos. Considerada uma das Sete Maravilhas do Mundo, esta cidade histórica é conhecida por sua arquitetura impressionante, terraços agrícolas e localização espetacular. Uma visita a Machu Picchu proporciona uma experiência única e mística.",
              ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/peru.webp",
          },
          new Destination
          {
              Id = 9,
              City = "paris",
              MainName = "paris",
              Country = "frança",
              Description = "A Cidade Luz, Paris, é famosa por sua arquitetura clássica, museus renomados como o Louvre, a icônica Torre Eiffel e suas avenidas elegantes. Além disso, Paris é conhecida como um centro de moda, arte, gastronomia refinada e romance, tornando-a um destino popular para viajantes de todo o mundo.",
              ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/parisjpg.jpg",
          }
            );



            modelBuilder.Entity<Hotel>().HasData(
      new Hotel
      {
          Id = 1,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-rio.webp",
          Name = "grand-hotel-plaza",
          MainName = "Grand Hotel Plaza",
          Stars = 5,
          Assessments = 110,
          Price = 1799,
      },
      new Hotel
      {
          Id = 2,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-londres.webp",
          Name = "montanha-lodge",
          MainName = "Montanha Lodge",
          Stars = 3,
          Assessments = 65,
          Price = 749,
      },
      new Hotel
      {
          Id = 3,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-dubai.jpg",
          Name = "seaside-resort",
          MainName = "Seaside Resort",
          Stars = 4,
          Assessments = 88,
          Price = 1299,
      },
      new Hotel
      {
          Id = 4,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-salvador.jpg",
          Name = "chale-do-bosque",
          MainName = "Chalé do Bosque",
          Stars = 3,
          Assessments = 50,
          Price = 499,
      },
      new Hotel
      {
          Id = 5,

          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-1.jpg",
          Name = "hotel-aconchego",
          MainName = "Hotel Aconchego",
          Stars = 4,
          Assessments = 92,
          Price = 899,
      },
      new Hotel
      {
          Id = 6,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-2.jpg",
          Name = "resort-paradisiaco",
          MainName = "Resort Paradisíaco",
          Stars = 5,
          Assessments = 120,
          Price = 1499,
      },
      new Hotel
      {
          Id = 7,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-3.jpg",
          Name = "pousada-das-flores",
          MainName = "Pousada das Flores",
          Stars = 3,
          Assessments = 60,
          Price = 599,
      },
      new Hotel
      {
          Id = 8,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-4.jpg",
          Name = "luxury-suite",
          MainName = "Luxury Suites",
          Stars = 5,
          Assessments = 105,
          Price = 1999,
      },
      new Hotel
      {
          Id = 9,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-5.jpg",
          Name = "hostel-viajante",
          MainName = "Hostel Viajante",
          Stars = 2,
          Assessments = 30,
          Price = 299,
      },
      new Hotel
      {
          Id = 10,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-6.jpg",
          Name = "riverside-lodge",
          MainName = "Riverside Lodge",
          Stars = 4,
          Assessments = 80,
          Price = 899,
      },
      new Hotel
      {
          Id = 11,
          ImgUrl = "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-7.jpg",
          Name = "chale-do-bosque",
          MainName = "Chalé do Bosque",
          Stars = 3,
          Assessments = 50,
          Price = 499,
      }
        );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    }

}