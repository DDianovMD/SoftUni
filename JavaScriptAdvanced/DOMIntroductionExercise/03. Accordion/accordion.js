function toggle() {

    let buttonElement = document.querySelector(".button");
    let extraTextElement = document.getElementById('extra');

    if (buttonElement.innerHTML == 'More') {
        buttonElement.innerHTML = 'Less';
        extraTextElement.style.display = 'block';
    } else {
        buttonElement.innerHTML = 'More';
        extraTextElement.style.display = 'none';
    }
}