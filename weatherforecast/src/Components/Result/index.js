import React from "react";
function index({hava}) {
    
    return(
        <>
            {typeof hava.main!="undefined" && (
                  <div className="result">
                  <div className="city">{hava.name},{hava.sys.country}</div>
                  <div className="detail">
                      <div className="temperature">{Math.round(hava.main.temp)}°C</div>
                      <div className="status">{hava.weather[0].description}</div>
                  </div>
              </div>
            )}
          </>
    );
}
export default index;