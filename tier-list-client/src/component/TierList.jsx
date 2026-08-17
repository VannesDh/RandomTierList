import { useEffect, useState } from "react";

import TierRow from "../component/TierRow"
import ItemPool from "../component/ItemPool";


function TierList(){
    const [tiersContainer, setTiersContainer] = useState([])
    const [draggedItem, setDraggedItem] = useState(null)
    
    useEffect(()=>{
        fetch("http://localhost:5087/api/TierContainer/1")
        .then(response => response.json())
        .then(data => {
            console.log(data)
            setTiersContainer(data)
        });

    }, []);

    function handleItemDrag(item) {
        setDraggedItem(item);
        console.log(item);
    }

    function handleDropItem(targetTierId){
    setTiersContainer(currentTiers => ({
        ...currentTiers,
        items: currentTiers.items.map(item => 
            item.id === draggedItem.id
                ? { ...item, tierId: targetTierId }
                : item
        )
    }))
}
    return(
        <div>
            {tiersContainer?.tiers?.map(tier => (
                <TierRow
                    key={tier.id}
                    id = {tier.id}
                    level={tier.level}
                    items={tiersContainer?.items?.filter(item => item.tierId === tier.id) ?? []}
                    onDragStart = {handleItemDrag}
                    onDrop = {handleDropItem}
                />
            ))}

             <ItemPool
                
                items={tiersContainer?.items?.filter(item => item.tierId == null) ?? []}
                onDragStart={handleItemDrag}
            />
            
        </div>
    )
}

export default TierList;