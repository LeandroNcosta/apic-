import React from 'react';
import Card from './components/Card';
import styles from './hotel.module.css';

// const hotels = [
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-rio.webp',
//         name: 'Grand Hotel Plaza',
//         starts: 5,
//         assessments: 110,
//         price: '1799',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-londres.webp',
//         name: 'Montanha Lodge',
//         starts: 3,
//         assessments: 65,
//         price: '749',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-dubai.jpg',
//         name: 'Seaside Resort',
//         starts: 4,
//         assessments: 88,
//         price: '1299',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-salvador.jpg',
//         name: 'Chalé do Bosque',
//         starts: 3,
//         assessments: 50,
//         price: '499',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-1.jpg',
//         name: 'Hotel Aconchego',
//         starts: 4,
//         assessments: 92,
//         price: '899',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-2.jpg',
//         name: 'Resort Paradisíaco',
//         starts: 5,
//         assessments: 120,
//         price: '1499',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-3.jpg',
//         name: 'Pousada das Flores',
//         starts: 3,
//         assessments: 60,
//         price: '599',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-4.jpg',
//         name: 'Luxury Suites',
//         starts: 5,
//         assessments: 105,
//         price: '1999',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-5.jpg',
//         name: 'Hostel Viajante',
//         starts: 2,
//         assessments: 30,
//         price: '299',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-6.jpg',
//         name: 'Riverside Lodge',
//         starts: 4,
//         assessments: 80,
//         price: '899',
//     },
//     {
//         imgUrl: 'https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-7.jpg',
//         name: 'Chalé do Bosque',
//         starts: 3,
//         assessments: 50,
//         price: '499',
//     },
// ];

const Hotel = async () => {
    const response = await fetch('http://localhost:5039/api/hotel');
    const hotels = await response.json();

    return (
        <div className="container">
            <h1 className={styles.h1}>✸ Hotéis</h1>
            <div className={styles.cards}>
                {hotels && hotels.map((h) => <Card key={h.name} data={h} />)}
            </div>
        </div>
    );
};

export default Hotel;
