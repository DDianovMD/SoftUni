function solve(a, b){
    // Everything divides 0
    if (a == 0){
        return b;
    }
    
    if (b == 0){
        return a;
    }    
 
    // base case
    if (a == b){
        return a;
    }        
 
    // a is greater
    if (a > b){
        return solve(a-b, b);
    } else{
        return solve(a, b-a);
    }
}