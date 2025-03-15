import React from 'react';

const Heading: React.FC = () => {
    return (
        <header>
            <h1>Bowling League Management</h1>
            <p>
                This web application allows you to manage and view bowlers and their teams within a bowling league.
                You can view the list of bowlers along with their personal details and the team they belong to. 
                The data is fetched from a backend API which serves information about bowlers and teams.
            </p>
        </header>
    );
};

export default Heading;
