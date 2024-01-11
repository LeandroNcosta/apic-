import styles from './destinationDetails.module.css';

const Details = async (context) => {
    const { params } = context;

    const response = await fetch(
        `http://localhost:5039/api/destination/${params.destinationName}`
    );
    const destination = await response.json();

    return (
        <div className={styles.destination}>
            <div className="container">
                <div className={styles.title}>
                    <span>{destination?.mainName}</span>
                    <h1>Escolha o seu destino</h1>
                </div>
                {destination && (
                    <main className={styles.info}>
                        <img src={destination.imgUrl || ''} alt="" />
                        <article>
                            <p>Local: {destination.mainName}</p>
                            <p>País: {destination.country}</p>
                            {destination.description}
                        </article>
                    </main>
                )}
            </div>
        </div>
    );
};

export default Details;
