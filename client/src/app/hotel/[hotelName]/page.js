import styles from './hotelDetails.module.css';

// export async function getStaticPaths() {
//     const response = await fetch(`http://localhost:5039/api/hotel`);

//     const data = await response.json();
//     // const dataLimit = data.slice(0, 100); // limitandoa 100 para ver o loading para itens acima de 100

//     const paths = data.map((item, index) => {
//         return {
//             params: {
//                 hotelName: `${item.name}`,
//             },
//         };
//     });

//     return {
//         paths,
//         fallback: false,
//         //fallback: true,
//         // fallback: true -> carregamebnto dinamico
//         // por exepmplo, voce pode solityar/limitar api apenas 200 todo para gerar antes pelo pre rendering por motivos de seo, mas deixar o restante como dinamico por conta da perfomance
//     };
// }

const Details = async (context) => {
    const { params } = context;
    const response = await fetch(
        `http:localhost:5039/api/hotel/${params.hotelName}`
    );
    const hotel = await response.json();

    return (
        <div className={styles.hotel}>
            <div className="container">
                <div className={styles.title}>
                    <span>{hotel?.mainName}</span>
                    <h1>Mais sobre essa estadia</h1>
                </div>
                {hotel && (
                    <main className={styles.info}>
                        <img src={hotel.imgUrl || ''} alt="" />
                        <article>
                            <p>
                                Nome: <span> {hotel.mainName} </span>
                            </p>
                            <p>Estrelas: {hotel.stars}</p>
                            <p>
                                Diária:{' '}
                                {hotel.price.toLocaleString('pt-BR', {
                                    style: 'currency',
                                    currency: 'BRL',
                                    minimumFractionDigits: 2,
                                    maximumFractionDigits: 2,
                                })}
                            </p>
                            <p>Avaliações: {hotel.assessments}</p>
                        </article>
                    </main>
                )}
            </div>
        </div>
    );
};

export default Details;
