function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      // Select DOM elements
      let trElements = document.querySelectorAll('tbody tr');
      let searchedTextElement = document.getElementById('searchField');

      // Remove all previously selected cells if any have been selected already
      for (const element of trElements) {
         element.classList.remove('select')
      }

      // Select cells that contains searched text
      for (const element of trElements) {
         if (element.innerHTML.toLowerCase().includes(searchedTextElement.value.toLowerCase())) {
            element.classList.add('select');
         }
      }

      // Remove inputed text in the search field
      searchedTextElement.value = '';
   }
}