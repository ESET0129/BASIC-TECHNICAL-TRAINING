import react, { useEffect, useState } from 'react';
export default function UseStateComponent(){
    const [count, setCount] = useState(0);
    const onButtonClickHandler = () => {
        setCount(count + 1);

    }
    return(
        <div>
            <h1>Count: {count}</h1>
            <button onClick={onButtonClickHandler}>Increment</button>
        </div>
    )
}

//function user(){
//     export default function useEffectComponent(){
//     const [user,setUser] = useState([]);
//     useEffect(() => {
//         //fetch("https://jsonplaceholder.typicode.com/users")
//         fetch("https://learn.future-proof.app/courses/68ac3785af48f8dd36f92d2f")
//         .then((response) => response.json())
//         .then((data) => setUser(data));
//     }, []);
// }
