import Background from "./Components/Background";
import Search from "./Components/Search/Index";
import Result from "./Components/Result";

import React , {useState} from "react";
import "./index.css";

function App() {
  const [havaDurumu,belirtHavaDurumu]= useState({});
  return (
   <section className="uygulama">
    <Background arkaplan={havaDurumu.weather && havaDurumu.weather[0].main}/>
   <div id="baslik"> Weather Forecast</div>
   <Search belirtHavaDurumu={belirtHavaDurumu} />
   <Result  hava={havaDurumu}/>
   </section>
  );
}

export default App;
