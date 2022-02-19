class Company {

    constructor() {
        this.departments = {};
    }

    addEmployee(name, salary, position, department) {
        if (!name || salary < 0 || !position || !department) {
            throw new Error("Invalid input!");
        }

        if (!this.departments[department]) {
            this.departments[department] = [];
        }

        this.departments[department].push({ name, position, salary });
        console.log(this.departments[department]);
        return `New employee is hired. Name: ${name}. Position: ${position}`;
        
    }

    bestDepartment(){

        let bestDepartmentName ='';
        let bestDepartemntAvrgSalary = 0;
        let bestEmployeesInfo = [];
        for (const key in this.departments) {
            
            let currentDepartemnt = this.departments[key];
            let currentDepartemntAvrgSalary = 0;
            let countEmployees = 0;
            let employeesInfo = [];


            for (const employee of currentDepartemnt) {
                currentDepartemntAvrgSalary+=employee.salary;
                countEmployees++;
                employeesInfo.push(employee);
            }
            currentDepartemntAvrgSalary/=countEmployees;

            if(currentDepartemntAvrgSalary>bestDepartemntAvrgSalary){
                bestDepartemntAvrgSalary = currentDepartemntAvrgSalary;
                bestDepartmentName = key;
                bestEmployeesInfo = employeesInfo;
            }

        }
        let employeesStringArray = [];
        bestEmployeesInfo.sort((a,b) => b.salary - a.salary || a.name.localeCompare(b.name));
        for (let index = 0; index < bestEmployeesInfo.length; index++) {
            employeesStringArray.push(`${bestEmployeesInfo[index].name} ${bestEmployeesInfo[index].salary} ${bestEmployeesInfo[index].position}`);
        }
        
        return `Best Department is: ${bestDepartmentName}\n` +
                `Average salary: ${bestDepartemntAvrgSalary.toFixed(2)}\n` +
                `${employeesStringArray.join('\n')}`;
   
    }
}

let company = new Company();
company.addEmployee("Stanimir", 2000, "engineer", "Construction");
company.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
company.addEmployee("Slavi", 500, "dyer", "Construction");
company.addEmployee("Stan", 2000, "architect", "Construction");
company.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
company.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
company.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(company.bestDepartment());