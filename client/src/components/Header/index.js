import Link from 'next/link';
import styles from './header.module.css';

const Header = () => {
    return (
        <header className={styles.header}>
            <div className={`${styles.div} container`}>
                <div className={styles.wrapperLogo}>
                    <img
                        src="https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/airplane.svg"
                        alt=""
                    />
                    <span>ViageMais</span>
                </div>
                <nav>
                    <ul>
                        <li>
                            <Link href={'/'} className={''}>
                                Destinos
                            </Link>
                            <span />
                        </li>
                        <li>
                            <Link href={'/hotel'}>Hotéis</Link>
                            <span />
                        </li>
                    </ul>
                </nav>
            </div>
        </header>
    );
};

export default Header;
