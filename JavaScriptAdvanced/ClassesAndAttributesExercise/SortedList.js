class List{
    constructor(){
        this.internalList = [];
        this.size = this.internalList.length;
    }

    add(element){
        this.internalList.push(element);
        this.size = this.internalList.length;
        this.internalList.sort((x, y) => x - y);
    }

    remove(index){
        if (index < 0 || index > this.internalList.length - 1){
        } else {
            this.internalList.splice(index, 1);
            this.size = this.internalList.length;
            this.internalList.sort((x,y) => x - y);
        }
    }

    get(index){
        if (index < 0 || index > this.internalList.length - 1) {
        } else {
            return this.internalList[Number.parseInt(index)];
        }
    }
}