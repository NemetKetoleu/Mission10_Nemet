import { useEffect, useState } from "react";
import { bowler } from "./types/bowler";

function BowlerList() {
    const [bowlers, setBowlers] = useState<bowler[]>([]);

    useEffect(() => {
        const fetchBowler = async () => {
            const response = await fetch("https://localhost:5000/Bowler"); // Change the endpoint to match the Bowler API
            const data = await response.json();
            setBowlers(data);
        };
        fetchBowler();
    }, []);

    return (
        <>
            <h1>Marlins or Sharks Teams</h1>
            <table>
                <thead>
                    <tr>
                        <th>Bowler Name</th>
                        <th>Bowler Address</th>
                        <th>Bowler City</th>
                        <th>Bowler State</th>
                        <th>Bowler Zip</th>
                        <th>Bowler Phone</th>
                        <th>Team Name</th>
                    </tr>
                </thead>
                <tbody>
                    {bowlers.map((b) => (
                        <tr key={b.bowlerId}>
                            <td>{`${b.bowlerFirstName} ${b.bowlerMiddleInit} ${b.bowlerLastName}`}</td>
                            <td>{b.bowlerAddress}</td>
                            <td>{b.bowlerCity}</td>
                            <td>{b.bowlerState}</td>
                            <td>{b.bowlerZip}</td>
                            <td>{b.bowlerPhoneNumber}</td>
                            <td>{b.team.teamName}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </>
    );
}

export default BowlerList;