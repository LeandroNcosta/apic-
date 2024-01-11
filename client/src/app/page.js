import styles from './page.module.css';
import Card from '@/app/destination/components/Card';

export default async function Home() {
    const response = await fetch('http://localhost:5039/api/destination');
    const destinations = await response.json();

    return (
        <div className={styles.destination}>
            <div className="container">
                <h1>✈ Destinos</h1>
                <ul className={styles.cardsContainer}>
                    {destinations &&
                        destinations.map((d) => <Card key={d.id} data={d} />)}
                </ul>
            </div>
        </div>
    );
}
