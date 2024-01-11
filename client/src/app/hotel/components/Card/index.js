import Link from 'next/link';
import styles from './cardHotel.module.css';

const Card = async ({ data }) => {
    return (
        <div className={styles.card}>
            <Link href={`hotel/${data.name}`}>
                <div className={styles.cardImage}>
                    <img src={data.imgUrl} alt="hotel rio" />
                </div>
                <div className={styles.cardContent}>
                    <div className={`${styles.hotelName} hotel-name`}>
                        <h3>{data.mainName}</h3>
                        <span>
                            <img
                                src="https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/star.svg"
                                alt=""
                            />
                            <img
                                src="https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/star.svg"
                                alt=""
                            />
                            <img
                                src="https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/star.svg"
                                alt=""
                            />
                        </span>
                    </div>
                    <div className={styles.avaliacoes}>
                        <span>5,0/5</span>
                        <span>{data.assessments} avaliações</span>
                    </div>
                    <span className={styles.price}>
                        Apartir De{' '}
                        {data.price.toLocaleString('pt-BR', {
                            style: 'currency',
                            currency: 'BRL',
                            minimumFractionDigits: 2,
                            maximumFractionDigits: 2,
                        })}
                    </span>
                </div>
            </Link>
        </div>
    );
};

export default Card;
