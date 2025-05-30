import './HolidaysComponent.css'

import { useQuery } from '@tanstack/react-query';

function HolidaysComponent() {
    const { data, isPending, error } = useQuery({
        queryKey: ['cities'],
        queryFn: () =>
            fetch('https://localhost:7117/summer-city')
                .then(res => {
                    if (!res.ok) throw new Error('Network response was not ok');
                    return res.json();
                }),
    });

    if (isPending) return <div>Loading...</div>;
    if (error) return <div>Error: {error.message}</div>;

    return (
        <div>
            <h1>Summer cities</h1>
            <pre>{JSON.stringify(data, null, 2)}</pre>
        </div>
    );
}

export default HolidaysComponent;
