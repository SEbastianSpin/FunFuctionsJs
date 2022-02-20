
function PriorityQueue () {
  this.collection = [];
 


  this.enqueue =function (elem){
   if(!this.size()){this.collection.push(elem);}
   else{
     let included=false;
     for(let p=0;p<this.collection.length;p++){
       if(elem[1]<this.collection[p][0]){
         this.collection.splice(p,0,elem);
         included=true;
         break;
       }
     }
     if(!included) this.collection.push(elem);
   }
  };

  this.dequeue =()=>{
    return this.collection.shift();
  };
  
  
};
