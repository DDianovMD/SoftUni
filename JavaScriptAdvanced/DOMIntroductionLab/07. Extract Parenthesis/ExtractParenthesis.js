function extract(content) {
    // Get element to manipulate
    let contentElement = document.getElementById(content);

    // RegEx
    let pattern = /\(([\w\s]+)\)/g;
    let matches = contentElement.textContent.matchAll(pattern);

    // Array of matches
    let matchesArray = [];

    // Fill the array
    for (const match of matches) {
        matchesArray.push(match[1]);
    }

    return matchesArray.join('; ');
}