import { useEffect, useState } from "react";
import axios from "axios";
const App = () => {
  const [user, setUser] = useState({});
  const [task, setTask] = useState({});
  useEffect(() => {
    axios.get("/api/users").then((res) => {
      console.log(res.data);
      setUser(res.data);
    });
  }, []);

  return (
    <div>
      ima cool cat! {JSON.stringify(user)}
      <b />
    </div>
  );
};

export default App;
