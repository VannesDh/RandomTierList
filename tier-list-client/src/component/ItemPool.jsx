import Item from "./Item";

function ItemPool({items, onDragStart}){
   return(
    <div
        style={{
            border: "1px solid black",
            minHeight: "100px",
            marginTop: "20px"
        }}
        onDragOver={(e)=> e.preventDefault()}
    >
        <strong>Unranked Item</strong>
        <div>
            {items?.map(item => (
                <Item
                    key={item.id}
                    item = {item}
                    onDragStart={onDragStart}
                />
            ))}
        </div>
    </div>
   ) 
}

export default ItemPool;