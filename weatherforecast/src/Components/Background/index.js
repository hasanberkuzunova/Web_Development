import rain from "../../Photo/rainy2.jpg";
import Photo from "./Photo";
function index({arkaplan}){
    return (
        <div className="background">
            <div className="overlay">
               <Photo durum={arkaplan} />
            </div>
        </div>
    )
}
export default index;