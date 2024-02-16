function superDigit(n, k) {
    n=n+"";
    
    if(n.length==1)return n;
    
    return superDigit(
        [...n].map(n=>Number(n)*k
    ).reduce((a,b)=>a+b)
    ,1)
    

}
