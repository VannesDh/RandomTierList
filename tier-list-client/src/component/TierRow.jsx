import Item from "./Item";

function TierRow({id, level, items, onDragStart, onDrop}){


    return (
        <div style={{ display: "flex", flexDirection:"column", border: "1px solid black" }}
            onDragOver = {(e) => e.preventDefault()}
            onDrop = {() => onDrop(id)}
            >
            <strong style={{ width: "50px" }}>
                {level}
            </strong>
            <div>
                {items?.map(item =>(
                   <Item key = {item.id} 
                   item = {item}
                   onDragStart = {onDragStart}/>
                ))}
            </div>
        </div>
    )
}

export default TierRow;