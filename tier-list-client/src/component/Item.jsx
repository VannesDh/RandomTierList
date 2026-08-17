function Item({item, onDragStart}){
    return(
        <span style={{ margin: "10px" }} 
        draggable = {true}
        onDragStart={() => onDragStart(item)}>
            {item.name}
        </span>
    )
}

export default Item;