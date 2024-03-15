import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlerList() {
  const [foodData, setFoodData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('https://localhost:7142/bowler');
      const f = await rsp.json();
      setFoodData(f);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Best Bowlers Ever</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler First Name</th>
            <th>Bowler Last Name</th>
            <th>Team Name</th>
            <th>Bowler Address</th>
            <th>Bowler City</th>
            <th>Bowler State</th>
            <th>Bowler Zipcode</th>
            <th>Bowler Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {foodData.map((f) => (
            <tr key={f.bowlerId}>
              <td>{f.bowlerFirstName}</td>
              <td>{f.bowlerLastName}</td>
              <td>{f.teamName}</td>
              <td>{f.bowlerAddress}</td>
              <td>{f.bowlerCity}</td>
              <td>{f.bowlerState}</td>
              <td>{f.bowlerZip}</td>
              <td>{f.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
