import { useEffect, useState } from "react";
function App() {

  const[Products,setProducts]=useState([
    {name:"Product 1",price:200.00},
    {name:"Product 2",price:100.00}
  ]);

  useEffect(()=>{
    fetch("http://localhost:5000/api/Products")
    .then(response => response.json())
    .then(data=> {setProducts(data)
      console.log(data)
    })
  },[])
  

  function AddProducts(){
    setProducts(prevState => [...prevState,{name:"Product "+(prevState.length +1),price:(prevState.length+1)*100}]);
  }
  return (
    <div>
      <h1>Shopify</h1>
      <ul>
        {Products.map((item,index) =>
        <li key={index} >{index} - {item.name} - {item.price}</li> 
        )}
      </ul>
      <button onClick={AddProducts}>Add Product</button>
    </div>
  );
}

export default App;
