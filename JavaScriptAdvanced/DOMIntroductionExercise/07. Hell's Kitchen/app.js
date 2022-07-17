function solve() {
    document.querySelector('#btnSend').addEventListener('click', onClick);

    function Worker(restaurant, name, salary){
    this.restaurant = restaurant;
    this.name = name;
    this.salary = salary;
}

    function onClick() {
        let input = document.querySelector('textarea');
        let bestRestaurantElement = document.querySelector('#bestRestaurant p');
        let bestWorkersElement = document.querySelector('#workers p');

        // Regex patterns
        let sentencePattern = /(\"[\w\s\d-,]+\")/g;
        let restaurantNamePattern = /"(?<name>\w+)\s/g;
        let employeePattern = /\s(?<name>[A-Z][a-z]+)\s{1}(?<salaries>\d+)/g;

        // Used variables
        let sentencesArray = [];
        let restaurantsArray = [];
        let restaurantNamesArray = [];
        let bestRestaurant = '';
        let bestAvgSalary = 0;

        // Extract sentences
        for (const sentence of input.value.matchAll(sentencePattern)) {
            sentencesArray.push(sentence[1]);
        }

        // Extract restaurant's Name
        for (let sentence of sentencesArray) {
            for (const restaurant of sentence.matchAll(restaurantNamePattern)) {
                let restaurantName = restaurant.groups.name;
                if (restaurantNamesArray.includes(restaurantName) == false) {
                    restaurantNamesArray.push(restaurantName);
                }
                
                // Extract restaurant's workers
                for (const employee of sentence.matchAll(employeePattern)) {
                    restaurantsArray.push(
                        new Worker(restaurantName, employee.groups.name, employee.groups.salaries
                        )
                    );
                }
            }
        }

        // Filter restaurants and calculate average salary for all employees
        for (const restaurant of restaurantNamesArray) {
            let workers = restaurantsArray.filter(x => x.restaurant == restaurant);
            let salarySum = 0;

            for (const employee of workers) {
                salarySum += Number(employee.salary);
            }

            let avgSalary = salarySum / workers.length;

            // Check if current restaurant has bigger average salary
            if (avgSalary > bestAvgSalary) {
                bestAvgSalary = avgSalary;
                bestRestaurant = restaurant;
            }
        }
        restaurantsArray = restaurantsArray.filter(x => x.restaurant == bestRestaurant).sort((x, y) => y.salary - x.salary);

        bestRestaurantElement.textContent = `Name: ${bestRestaurant} Average Salary: ${bestAvgSalary.toFixed(2)} Best Salary: ${Number(restaurantsArray[0].salary).toFixed(2)}`;

        for (const worker of restaurantsArray) {
            bestWorkersElement.textContent += `Name: ${worker.name} With Salary: ${worker.salary} `;
        }
    }
}