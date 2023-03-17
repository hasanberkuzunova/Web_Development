import React,{useState} from "react";
function Index({belirtHavaDurumu}){
    const api = {
        key:"d692b69ba4067efe0289d0b175fb17b6",
        base:"https://api.openweathermap.org/data/2.5/weather",
    };
    const [search,parameter] = useState("");
    const srch = (e)=>{
        if(e.key === "Enter")
            {
                fetch(`${api.base}?q=${search}&units=metric&appid=${api.key}`) 
                .then((veri)=> veri.json())
                .then((sonuc)=>{
                    parameter("");
                    belirtHavaDurumu(sonuc);
                    
                });
            }   
 };
    return(
        <div className="search">
            <input className="search-input" type="text" placeholder="City"
            onChange={(e)=>parameter(e.target.value)}
            value={search}
            onKeyDown={(e) => e.key === 'Enter' && srch(e)}
            />
        </div>
    );
}
export default Index;

