import React, { useEffect, useState,memo } from 'react'

export default function UseEffectComponent() {

    const suggestions = [
        "maxhub",
        "laptop",
        "bottle",
        "car"
    ];
    const [recomendation,setRecomendation] = useState([]);
    const [search,setSearch]=useState("");
    useEffect(()=>{
         setRecomendation(suggestions.filter((element)=>element.includes(search)));
    },[search]);

  return (
    <div>
        <input value={search} onChange={(e)=>setSearch(e.target.value)}/>
      {
        recomendation.map((rec,index)=>(<ListTile index={index} rec={rec}/>))
      }
    </div>
  )
}

const ListTile = memo(({index,rec}) =>{
    console.log("child rendered",rec)
    return <div key={index}>{index}.{rec}</div>
},(prevProps,newProps)=>{
   return false
})