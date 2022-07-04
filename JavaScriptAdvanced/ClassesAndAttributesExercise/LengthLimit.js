class Stringer{
    newLength;

    constructor(innerString, innerLength){
        this.innerString = String(innerString);
        this.innerLength = Number.parseInt(innerLength);
    }

    toString(){
        if (this.innerLength > 0) {
            return this.innerString.substring(0, this.innerLength) + '...';
        } else if (this.innerLength <= 0){
            return '...';
        } else if (this.innerString.length > this.innerLength) {
            return this.innerString.substring(0, this.innerLength) + '...';
        }
    }

    increase(intValue){
        this.innerLength += intValue;
    }

    decrease(intValue){
        if (this.innerLength - intValue < 0) {
            this.innerLength = 0;
        } else {
            this.innerLength -= intValue;
        }
    }
}
