function search() {
   let townsElements = document.querySelectorAll('#towns li');
   let searchedText = document.getElementById('searchText');
   let resultElement = document.getElementById('result');
   let matchesCounter = 0;

   for (let element of townsElements) {
      if (element.innerHTML.includes(searchedText.value)) {
         element.style.textDecoration = 'underline';
         element.style.fontWeight = 'bold';
         matchesCounter += 1;
      }
   }

   resultElement.innerText = `${matchesCounter} matches found`;
}