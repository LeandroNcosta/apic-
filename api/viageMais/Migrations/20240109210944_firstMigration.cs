using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace viageMais.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "destination",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_destination", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hotel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stars = table.Column<int>(type: "int", nullable: false),
                    assessments = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotel", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "destination",
                columns: new[] { "id", "city", "country", "description", "imgUrl", "mainName" },
                values: new object[,]
                {
                    { 1, "foz-do-iguacu", "brasil", "Localizada na tríplice fronteira entre Brasil, Argentina e Paraguai, Foz do Iguaçu é conhecida pelas impressionantes Cataratas do Iguaçu. O Parque Nacional do Iguaçu abriga uma das maiores e mais espetaculares quedas d'água do mundo, oferecendo uma experiência única em meio à natureza exuberante da região.", "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/foziguacu.webp", "foz-do-iguaçu" },
                    { 2, "caribe", "caribe", "O Caribe é uma região paradisíaca que abrange várias ilhas, como as Bahamas, Jamaica, Porto Rico e muitas outras. Conhecido por suas praias de areia branca, águas cristalinas e uma rica cultura vibrante, o Caribe é um destino popular para turistas em busca de relaxamento, esportes aquáticos e vida noturna animada.", "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/caribe.webp", "caribe" },
                    { 3, "dubai", "emirados-árabes-unidos", "Dubai é uma metrópole futurista no coração do Oriente Médio, conhecida por suas arquiteturas icônicas, como o Burj Khalifa, o edifício mais alto do mundo. A cidade oferece uma mistura de modernidade e tradição, com shoppings luxuosos, resorts de classe mundial, desertos fascinantes e uma atmosfera cosmopolita.", "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/dubai.webp", "dubai" },
                    { 4, "maceio", "brasil", "Capital do estado de Alagoas, Maceió é famosa por suas praias deslumbrantes e piscinas naturais formadas por recifes de corais. As águas calmas e cristalinas do litoral atraem visitantes em busca de paisagens tropicais, enquanto a cultura local e a gastronomia regional adicionam um toque especial à experiência.", "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/maceio.webp", "maceió" },
                    { 5, "londres", "inglaterra", "A capital do Reino Unido, Londres, é uma cidade histórica e cosmopolita. Oferece uma rica herança cultural, incluindo ícones como o Palácio de Buckingham, o Parlamento, a Torre de Londres e o Museu Britânico. Além disso, a cidade é conhecida por suas opções de compras, teatros, parques e uma vibrante cena gastronômica.", "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/londres.webp", "londres" },
                    { 6, "cancun", "méxico", "Situada na Península de Yucatán, Cancún é um destino de resort popular, conhecido por suas praias de areia branca e águas cristalinas do Caribe. Além de suas atrações naturais, Cancún oferece uma animada vida noturna, restaurantes de alta qualidade e a proximidade das antigas ruínas maias de Chichén Itzá.", "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/mexico.webp", "cancún" },
                    { 7, "serra-gaucha", "brasil", "A Serra Gaúcha, no estado do Rio Grande do Sul, é uma região encantadora com forte influência da colonização italiana. Cidades como Gramado e Canela são famosas por sua arquitetura europeia, culinária deliciosa, chocolates artesanais e festivais de inverno. A região é um destino popular durante o Natal Luz, quando as cidades se iluminam com decorações festivas.", "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/serra-gaucha.jpg", "serra-gaúcha" },
                    { 8, "machu-picchu", "peru", "Machu Picchu é uma antiga cidade inca situada nas montanhas dos Andes peruanos. Considerada uma das Sete Maravilhas do Mundo, esta cidade histórica é conhecida por sua arquitetura impressionante, terraços agrícolas e localização espetacular. Uma visita a Machu Picchu proporciona uma experiência única e mística.", "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/peru.webp", "machu-picchu" },
                    { 9, "paris", "frança", "A Cidade Luz, Paris, é famosa por sua arquitetura clássica, museus renomados como o Louvre, a icônica Torre Eiffel e suas avenidas elegantes. Além disso, Paris é conhecida como um centro de moda, arte, gastronomia refinada e romance, tornando-a um destino popular para viajantes de todo o mundo.", "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/parisjpg.jpg", "paris" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "destination");

            migrationBuilder.DropTable(
                name: "hotel");
        }
    }
}
