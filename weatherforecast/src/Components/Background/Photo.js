import rain from "../../Photo/rainy2.jpg";
import cloud from "../../Photo/clouds_from_above.jfif";
import fog from "../../Photo/foggy.jfif";
import rainbow from "../../Photo/rainbow.jfif";
import snow from "../../Photo/snowy.jfif";
import sun from "../../Photo/sunny.jfif";
import storm from "../../Photo/storm.jpg";
function Photo({durum}){
    switch(durum){
        case "Rain":
            return <img className="backgroundimage" src={rain} alt="rain" />
        case "Drizzle":
            return <img className="backgroundimage" src={rain} alt="rain" />
        case "Clear":
            return <img className="backgroundimage" src={sun} alt="sun" />
        case "Mist":
            return <img className="backgroundimage" src={fog} alt="fog" />
        case "Snow":
            return <img className="backgroundimage" src={snow} alt="snow" />
        case "Thunderstorm":
            return <img className="backgroundimage" src={storm} alt="storm" />
        case "Clouds":
            return <img className="backgroundimage" src={cloud} alt="cloud" />
        default:
            return <img className="backgroundimage" src={rainbow} alt="rainbow" />
    }
}
export default Photo;