import { useState } from "react";

export default function TextToList() {
  const [input, setInput] = useState("");
  const [items, setItems] = useState([]);

  const handleBlur = () => {
    if (input.trim() !== "") {
      setItems(oldItems => [...oldItems, input.trim()]);
      setInput(""); // Optionally clear after adding
    }
  };

  return (
    <div>
        <br></br>
        <h3> Enter Text Data below</h3>
      <input
        type="text"
        value={input}
        onChange={e => setInput(e.target.value)}
        onBlur={handleBlur}
    
        placeholder="Enter item of list "
      />
      <button onClick={handleBlur}> Click Me </button>
      <ol>
        {items.map((item, idx) => (
          <li key={idx}>{item}</li>
        ))}
      </ol>
    </div>
  );
}


