import { use } from "react";

    export default function useEffectComponent(){
const{recommendations, setRecommendations} = useState([]);
useEffect(() => {
    setRecommendations(suggestions);
}, []);

    const [user,setUser] = useState([]);
    useEffect(() => {
        //fetch("https://jsonplaceholder.typicode.com/users")
        fetch("https://learn.future-proof.app/courses/68ac3785af48f8dd36f92d2f")
        .then((response) => response.json())
        .then((data) => setUser(data));
    }, []);
}

const suggestions = [
    apple,
    banana,
    mango,
    grapes
]

const[search, setSearch] = useState("");

return(
    <div>
        <input value={(search)} onChange={(e) => setSearch(e.target.value)}/>
        
        
        {recommendations.map((suggestions) => (
            <div key={suggestions}>{suggestions}</div>
        ))}
    </div>
)