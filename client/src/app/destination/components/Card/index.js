import Link from 'next/link';
import styles from './card.module.css';

const Card = ({ data }) => {
    return (
        <li className={styles.card}>
            <Link href={`destination/${data.city}`}>
                <figure>
                    <img src={data.imgUrl} alt={data.city} />
                    <div className={styles.info}>
                        <span>{data.mainName.split('-').join(' ')}</span>
                        <span>{data.country.split('-').join(' ')}</span>
                    </div>
                </figure>
            </Link>
        </li>
    );
};

export default Card;
