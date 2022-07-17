function solve(sequenceLength, previousElementsCount) {

    let numbersSequence = [];

    if (sequenceLength > 0) {
        numbersSequence.push(1);
    }

    for (let i = 1; i < sequenceLength; i++) {
        let nextNumber = 0;
        let index = i - previousElementsCount;

        if (index < 0) {
            index = 0;
        }

        for (let j = index; j < i; j++) {
            nextNumber += numbersSequence[j];
        }

        numbersSequence.push(nextNumber);
    }

    return numbersSequence;

}