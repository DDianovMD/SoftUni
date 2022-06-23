function solve(steps, footprintSize, speed){

    // distance in kilometers
    let distance = (steps * footprintSize) / 1000;
    // needed time to travel the distance in seconds
    let seconds = Math.ceil((distance * 3600) / speed);
    // calculate extra time for rest (60 seconds per every 0.5 km walked)
    let extraTimeForRestInSeconds = Math.floor(distance / 0.5) * 60;
    // add extra time
    seconds += extraTimeForRestInSeconds;
    
    let date = new Date(null);
    date.setSeconds(seconds)
    console.log(date.toISOString().substr(11, 8));
}