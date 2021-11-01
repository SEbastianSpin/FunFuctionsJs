function palindrome(str) {
  let word=str.split("");
  let newword=""
  for(let c=0;c<str.length;c++){

    if(/[A-Za-z0-9]/.test(word[c])){
        newword+=word[c]; 
    } 

  }
  
let myraex1=new RegExp(newword.slice(0,Math.floor(newword.length/2)),'i');
let myraex2=newword.slice(Math.ceil(newword.length/2),newword.lenght);
myraex2=myraex2.split("").reverse().join("");



console.log(myraex1);
console.log(myraex2+"\n");

return myraex1.test(myraex2)?true:false
}
