function solve() {
  let textElement = document.getElementById('text');
  let namingConventionElemenent = document.getElementById('naming-convention');
  let resultElement = document.getElementById('result')

  let firstLetter = '';
  let resultString = '';

  textElementArray = String(textElement.value).split(' ');

  if (namingConventionElemenent.value === 'Camel Case') {
    for (let i = 0; i < textElementArray.length; i++) {
      for (let j = 0; j < textElementArray[i].length; j++) {
        let currentLetter = textElementArray[i][j];
        if (i === 0) {
          resultString += String(currentLetter).toLowerCase();
        } else {
          if (j === 0) {
            resultString += String(currentLetter).toUpperCase();
          } else {
            resultString += String(currentLetter).toLowerCase();
          }
        }
      }
    }
  } else if (namingConventionElemenent.value === 'Pascal Case') {
    for (let i = 0; i < textElementArray.length; i++) {
      for (let j = 0; j < textElementArray[i].length; j++) {
        let currentLetter = textElementArray[i][j];
        if (j === 0) {
          resultString += String(currentLetter).toUpperCase();
        } else {
          resultString += String(currentLetter).toLowerCase();
        }
      }
    }
  } else {
    resultString = 'Error!';
  }

  resultElement.innerText = resultString;
}