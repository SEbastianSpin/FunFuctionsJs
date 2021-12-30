function isPresent(item,arr){ // return true if present
  let answer=false;
  for(let t=0;t<arr.length;t++){
    if(item===arr[t]) answer=true;
  }
  return answer;
}

function wherePresent(item,arr){// returns index
 
  for(let t=0;t<arr.length;t++){
    if(item===arr[t]) return t;
  }
  
}

function sym(args) {
  let result=[];
 for(const arr in arguments){
  
   let array=[...new Set(arguments[arr])];
   
    for(let c=0;c<array.length;c++){
        if(!isPresent(array[c],result)){
         
          result.push(array[c]);
        }
        else{
        
        let pos=wherePresent(array[c],result);
        
        result.splice(pos,1);
       
        }
    }
 }
 console.log(result);
 return result;
}
