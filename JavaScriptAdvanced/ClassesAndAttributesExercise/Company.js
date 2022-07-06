class Company {

    departmentsArray = [];
    companyArray = [];

    constructor() {
        this.departments = {};
    }

    addEmployee(name, salary, position, department) {
        if (name == "" || name == undefined || name == null ||
            salary == "" || salary == undefined || salary == null || salary < 0 ||
            position == "" || position == undefined || position == null ||
            department == "" || department == undefined || department == null) {
            throw new Error("Invalid input!");
        } else {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;

            this.departments = {
                name: this.name,
                salary: this.salary,
                position: this.position,
                department: this.department
            };

            this.companyArray.push(this.departments);
            this.departmentsArray.push(this.department);

            return `New employee is hired. Name: ${name}. Position: ${position}`;
        }
    }

    bestDepartment() {
        
        let bestDepartment = '';
        let bestAvgSalary = 0;

        for (const departmentName of this.departmentsArray) {

            let sum = 0;
            let counter = 0;

            for (const employee of this.companyArray) {

                if (employee.department == departmentName) {
                    sum += employee.salary
                    counter++;
                }
            }

            sum = sum / counter;

            if (sum > bestAvgSalary) {
                bestAvgSalary = sum;
                bestDepartment = departmentName;
            }
        }

        let returnString = `Best Department is: ${bestDepartment}\n` +
            `Average salary: ${bestAvgSalary.toFixed(2)}\n`;

        for (const currentEmployee of this.companyArray.filter(x => x.department == bestDepartment)
            .sort((x, y) => y.salary - x.salary || x.name.localeCompare(y.name))) {
            returnString += `${currentEmployee.name} ${currentEmployee.salary} ${currentEmployee.position}` + `\n`;
        }

        return returnString.trimEnd();
    }
}
